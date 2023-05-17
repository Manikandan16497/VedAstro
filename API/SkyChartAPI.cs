﻿using Microsoft.AspNetCore.Routing;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.Functions.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VedAstro.Library;

namespace API
{
    public static class SkyChartAPI
    {

        [Function("GetSkyChart")]
        public static async Task<HttpResponseData> GetSkyChart([HttpTrigger(AuthorizationLevel.Anonymous,
            "get",
            Route = "GetSkyChart/Location/{locationName}/Time/{hhmmStr}/{dateStr}/{monthStr}/{yearStr}/{offsetStr}")]
            HttpRequestData incomingRequest,
            string locationName,
            string hhmmStr,
            string dateStr,
            string monthStr,
            string yearStr,
            string offsetStr)
        {
            try
            {
                //get dasa report for sending
                var location = await GeoLocation.FromName(locationName);
                var chart = SkyChartManager.GenerateChart(Time.Now(location));

                return  APITools.SendSvgToCaller(chart, incomingRequest);

            }
            catch (Exception e)
            {
                //log error
                await APILogger.Error(e, incomingRequest);

                //format error nicely to show user
                return APITools.FailMessage(e, incomingRequest);
            }

        }

    }
}

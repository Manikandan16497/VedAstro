﻿namespace Genso.Astrology.Library
{
    /// <summary>
    /// Staticly typed name list of events,
    /// This is not the primarly list, not all events here will be checked, only events in the XML list are checked
    /// Not all events here have to have a method
    /// </summary>
    public enum EventName
    {
        EmptyEvent,
        //Lunar Day
        LunarDay1_1stBrightHalf,
        LunarDay2_2ndBrightHalf,
        LunarDay3_3rdBrightHalf,
        LunarDay4_4thBrightHalf,
        LunarDay5_5thBrightHalf,
        LunarDay6_6thBrightHalf,
        LunarDay7_7thBrightHalf,
        LunarDay8_8thBrightHalf,
        LunarDay9_9thBrightHalf,
        LunarDay10_10thBrightHalf,
        LunarDay11_11thBrightHalf,
        LunarDay12_12thBrightHalf,
        LunarDay13_13thBrightHalf,
        LunarDay14_14thBrightHalf,
        LunarDay15_FullMoon,
        LunarDay16_1stDarkHalf,
        LunarDay17_2ndDarkHalf,
        LunarDay18_3rdDarkHalf,
        LunarDay19_4thDarkHalf,
        LunarDay20_5thDarkHalf,
        LunarDay21_6thDarkHalf,
        LunarDay22_7thDarkHalf,
        LunarDay23_8thDarkHalf,
        LunarDay24_9thDarkHalf,
        LunarDay25_10thDarkHalf,
        LunarDay26_11thDarkHalf,
        LunarDay27_12thDarkHalf,
        LunarDay28_13thDarkHalf,
        LunarDay29_14thDarkHalf,
        LunarDay30_NewMoon,

        GoodTarabala,
        BadTarabala,
        GoodChandrabala,
        BadChandrabala,
        SiddhaYogaSunday,
        SiddhaYogaMonday,
        SiddhaYogaTuesday,
        SiddhaYogaWednesday,
        SiddhaYogaThursday,
        SiddhaYogaFriday,
        SiddhaYogaSaturday,
        AmritaSiddhaYoga,
        PanchangaSuddhi,
        UgraYoga,
        SuryaSankramana,
        KarthariDosha,
        ShashtashtaRiphagathaChandraDosha,
        SagrahaChandraDosha,
        UdayasthaSuddhi,
        SiddhaYoga,
        SakunaKarana,
        BadNithyaYoga,
        LagnaThyajya,
        GoodPanchaka,
        BadPanchaka,
        BadTaraChandraPanchaka,
        GoodTaraChandraPanchaka,
        GoodTaraChandra,
        BadTaraChandra,
        BhriguShatka,
        Kujasthama,
        GoodHairCutting,
        GoodNailCutting,
        FixedConstellationRuling,
        SoftConstellationRuling,
        LightConstellationRuling,
        SharpConstellationRuling,
        MovableConstellationRuling,
        DreadfulConstellationRuling,
        MixedConstellationRuling,
        BadForStartingAllAgriculture,
        LagnaLordIsWeekdayLord,
        GoodLunarDayAgriculture,
        BadLagnaForAllAgriculture,
        GoodYogaForAllAgriculture,
        GoodAnySeedsSowing,
        Ekadashi,
        NotAuspiciousDay,
        GoodPlanetsInLagna,
        GoodForPlantingFloweringPlants,
        GoodForPlantingGarlic,
        GoodForPlantingPeachAndOthers,
        GoodForPlantingTomatoesAndOthers,
        GoodForPlantingGrains,
        GoodForPlantingOnionAndOthers,
        GoodForPlantingPepperAndOthers,
        GoodForPlantingPotatoAndOthers,
        GoodForPlantingGrainsAndOthers,
        GoodForPlantingPumpkinsAndOthers,
        GoodForPlantingTrees,
        GoodForPlantingFlowerSeeds,
        GoodForPlantingSugarcane,
        GoodForPlantingFruitTrees,
        GoodForPlantingFlowerTrees,
        GoodForPlantingFlowers,
        GoodForPlantingFlowerCuttings,
        GoodRullingConstellation,
        BadRullingConstellation,
        GoodTakingInjections,
        GoodSellingForProfit,
        BavaKarana,
        TaitulaKarana,
        BhadraKarana,
        JanmaNakshatraRulling,
        SunIsStrong,
        MoonIsStrong,
        MarsIsStrong,
        MercuryIsStrong,
        JupiterIsStrong,
        VenusIsStrong,
        SaturnIsStrong,
        House1IsStrong,
        House2IsStrong,
        House3IsStrong,
        House4IsStrong,
        House5IsStrong,
        House6IsStrong,
        House7IsStrong,
        House8IsStrong,
        House9IsStrong,
        House10IsStrong,
        House11IsStrong,
        House12IsStrong,
        BadForBuyingToolsUtensilsJewellery,
        GoodForBuyingBrassVessels,
        GoodForBuyingCopperVessels,
        GoodForBuyingSteelIronVessels,
        GoodForBuyingSilverVessels,
        GoodForBuyingJewellery,
        GoodPlanetsIn11th,
        GoodPlanetsInKendra,
        Sunrise,
        Sunset,
        Midday,
        TarabalaJanmaStrong,
        TarabalaSampatStrong,
        TarabalaVipatStrong,
        TarabalaKshemaStrong,
        TarabalaPratyakStrong,
        TarabalaSadhanaStrong,
        TarabalaNaidhanaStrong,
        TarabalaMitraStrong,
        TarabalaParamaMitraStrong,
        TarabalaJanmaMiddling,
        TarabalaSampatMiddling,
        TarabalaVipatMiddling,
        TarabalaKshemaMiddling,
        TarabalaPratyakMiddling,
        TarabalaSadhanaMiddling,
        TarabalaNaidhanaMiddling,
        TarabalaMitraMiddling,
        TarabalaParamaMitraMiddling,
        TarabalaJanmaWeak,
        TarabalaSampatWeak,
        TarabalaVipatWeak,
        TarabalaKshemaWeak,
        TarabalaPratyakWeak,
        TarabalaSadhanaWeak,
        TarabalaNaidhanaWeak,
        TarabalaMitraWeak,
        TarabalaParamaMitraWeak,
        Papashadvargas,
        House1LordInHouse1,
        House1LordInHouse2,
        House1LordInHouse3,
        House1LordInHouse4,
        House1LordInHouse5,
        House1LordInHouse6,
        House1LordInHouse7,
        House1LordInHouse8,
        House1LordInHouse9,
        House1LordInHouse10,
        House1LordInHouse11,
        House1LordInHouse12,
        House2LordInHouse1,
        House2LordInHouse2,
        House2LordInHouse3,
        House2LordInHouse4,
        House2LordInHouse5,
        House2LordInHouse6,
        House2LordInHouse7,
        House2LordInHouse8,
        House2LordInHouse9,
        House2LordInHouse10,
        House2LordInHouse11,
        House2LordInHouse12,
        House3LordInHouse1,
        House3LordInHouse2,
        House3LordInHouse3,
        House3LordInHouse4,
        House3LordInHouse5,
        House3LordInHouse6,
        House3LordInHouse7,
        House3LordInHouse8,
        House3LordInHouse9,
        House3LordInHouse10,
        House3LordInHouse11,
        House3LordInHouse12,
        CombinedEvent,
        GoodMoonSignForSelling,
        GoodWeekdayForSelling,
        House4LordInHouse1,
        House4LordInHouse2,
        House4LordInHouse3,
        House4LordInHouse4,
        House4LordInHouse5,
        House4LordInHouse6,
        House4LordInHouse7,
        House4LordInHouse8,
        House4LordInHouse9,
        House4LordInHouse10,
        House4LordInHouse11,
        House4LordInHouse12,
        House5LordInHouse1,
        House5LordInHouse2,
        House5LordInHouse3,
        House5LordInHouse4,
        House5LordInHouse5,
        House5LordInHouse6,
        House5LordInHouse7,
        House5LordInHouse8,
        House5LordInHouse9,
        House5LordInHouse10,
        House5LordInHouse11,
        House5LordInHouse12,
        House6LordInHouse1,
        House6LordInHouse2,
        House6LordInHouse3,
        House6LordInHouse4,
        House6LordInHouse5,
        House6LordInHouse6,
        House6LordInHouse7,
        House6LordInHouse8,
        House6LordInHouse9,
        House6LordInHouse10,
        House6LordInHouse11,
        House6LordInHouse12,
        House7LordInHouse1,
        House7LordInHouse2,
        House7LordInHouse3,
        House7LordInHouse4,
        House7LordInHouse5,
        House7LordInHouse6,
        House7LordInHouse7,
        House7LordInHouse8,
        House7LordInHouse9,
        House7LordInHouse10,
        House7LordInHouse11,
        House7LordInHouse12,
        House8LordInHouse1,
        House8LordInHouse2,
        House8LordInHouse3,
        House8LordInHouse4,
        House8LordInHouse5,
        House8LordInHouse6,
        House8LordInHouse7,
        House8LordInHouse8,
        House8LordInHouse9,
        House8LordInHouse10,
        House8LordInHouse11,
        House8LordInHouse12,
        House9LordInHouse1,
        House9LordInHouse2,
        House9LordInHouse3,
        House9LordInHouse4,
        House9LordInHouse5,
        House9LordInHouse6,
        House9LordInHouse7,
        House9LordInHouse8,
        House9LordInHouse9,
        House9LordInHouse10,
        House9LordInHouse11,
        House9LordInHouse12,
        House10LordInHouse1,
        House10LordInHouse2,
        House10LordInHouse3,
        House10LordInHouse4,
        House10LordInHouse5,
        House10LordInHouse6,
        House10LordInHouse7,
        House10LordInHouse8,
        House10LordInHouse9,
        House10LordInHouse10,
        House10LordInHouse11,
        House10LordInHouse12,
        House11LordInHouse1,
        House11LordInHouse2,
        House11LordInHouse3,
        House11LordInHouse4,
        House11LordInHouse5,
        House11LordInHouse6,
        House11LordInHouse7,
        House11LordInHouse8,
        House11LordInHouse9,
        House11LordInHouse10,
        House11LordInHouse11,
        House11LordInHouse12,
        House12LordInHouse1,
        House12LordInHouse2,
        House12LordInHouse3,
        House12LordInHouse4,
        House12LordInHouse5,
        House12LordInHouse6,
        House12LordInHouse7,
        House12LordInHouse8,
        House12LordInHouse9,
        House12LordInHouse10,
        House12LordInHouse11,
        House12LordInHouse12,
        AriesRising,
        TaurusRising,
        GeminiRising,
        CancerRising,
        LeoRising,
        VirgoRising,
        LibraRising,
        ScorpioRising,
        SagittariusRising,
        CapricornusRising,
        AquariusRising,
        PiscesRising,
        SunInHouse1,
        MoonInHouse1,
        MarsInHouse1,
        MercuryInHouse1,
        JupiterInHouse1,
        VenusInHouse1,
        SaturnInHouse1,
        RahuInHouse1,
        KetuInHouse1,
        SunInHouse2,
        MoonInHouse2,
        MarsInHouse2,
        MercuryInHouse2,
        JupiterInHouse2,
        VenusInHouse2,
        SaturnInHouse2,
        RahuInHouse2,
        KetuInHouse2,
        SunInHouse3,
        MoonInHouse3,
        MarsInHouse3,
        MercuryInHouse3,
        JupiterInHouse3,
        VenusInHouse3,
        SaturnInHouse3,
        RahuInHouse3,
        KetuInHouse3,
        SunInHouse4,
        MoonInHouse4,
        MarsInHouse4,
        MercuryInHouse4,
        JupiterInHouse4,
        VenusInHouse4,
        SaturnInHouse4,
        RahuInHouse4,
        KetuInHouse4,
        SunInHouse5,
        MoonInHouse5,
        MarsInHouse5,
        MercuryInHouse5,
        JupiterInHouse5,
        VenusInHouse5,
        SaturnInHouse5,
        RahuInHouse5,
        KetuInHouse5,
        SunInHouse6,
        MoonInHouse6,
        MarsInHouse6,
        MercuryInHouse6,
        JupiterInHouse6,
        VenusInHouse6,
        SaturnInHouse6,
        RahuInHouse6,
        KetuInHouse6,
        SunInHouse7,
        MoonInHouse7,
        MarsInHouse7,
        MercuryInHouse7,
        JupiterInHouse7,
        VenusInHouse7,
        SaturnInHouse7,
        RahuInHouse7,
        KetuInHouse7,
        SunInHouse8,
        MoonInHouse8,
        MarsInHouse8,
        MercuryInHouse8,
        JupiterInHouse8,
        VenusInHouse8,
        SaturnInHouse8,
        RahuInHouse8,
        KetuInHouse8,
        SunInHouse9,
        MoonInHouse9,
        MarsInHouse9,
        MercuryInHouse9,
        JupiterInHouse9,
        VenusInHouse9,
        SaturnInHouse9,
        RahuInHouse9,
        KetuInHouse9,
        SunInHouse10,
        MoonInHouse10,
        MarsInHouse10,
        MercuryInHouse10,
        JupiterInHouse10,
        VenusInHouse10,
        SaturnInHouse10,
        RahuInHouse10,
        KetuInHouse10,
        SunInHouse11,
        MoonInHouse11,
        MarsInHouse11,
        MercuryInHouse11,
        JupiterInHouse11,
        VenusInHouse11,
        SaturnInHouse11,
        RahuInHouse11,
        KetuInHouse11,
        SunInHouse12,
        MoonInHouse12,
        MarsInHouse12,
        MercuryInHouse12,
        JupiterInHouse12,
        VenusInHouse12,
        SaturnInHouse12,
        RahuInHouse12,
        KetuInHouse12,
        GeminiRisingWithEvilPlanet,
        AriesRisingWithEvilPlanet,
        Lord2WithEvilInHouse,
        SaturnIn2WithVenus,
        MoonMarsIn2WithSaturnAspect,
        MercuryAndEvilIn2WithMoonAspect,
        SunIn2WithNoSaturnAspect,
        MoonIn2WithMercuryAspect,
        Lord2And3In6WithEvilPlanet,
        Lord2InHouse1,
        Lord2InHouse1AndLord1InHouse2,
        Lord2InHouse3,
        Lord2InHouse4,
        Lord2InHouse5,
        Lord2InHouse6,
        Lord2InHouse7,
        Lord2InHouse8,
        Lord2InHouse9,
        Lord2InHouse10,
        Lord2InHouse11,
        Lord2InHouse12,
        MaleficIn11FromArudha,
        BeneficIn11FromArudha,
        SunGocharaInHouse1,
        SunGocharaInHouse2,
        SunGocharaInHouse3,
        SunGocharaInHouse4,
        SunGocharaInHouse5,
        SunGocharaInHouse6,
        SunGocharaInHouse7,
        SunGocharaInHouse8,
        SunGocharaInHouse9,
        SunGocharaInHouse10,
        SunGocharaInHouse11,
        SunGocharaInHouse12,
        MoonGocharaInHouse1,
        MoonGocharaInHouse2,
        MoonGocharaInHouse3,
        MoonGocharaInHouse4,
        MoonGocharaInHouse5,
        MoonGocharaInHouse6,
        MoonGocharaInHouse7,
        MoonGocharaInHouse8,
        MoonGocharaInHouse9,
        MoonGocharaInHouse10,
        MoonGocharaInHouse11,
        MoonGocharaInHouse12,
        MarsGocharaInHouse1,
        MarsGocharaInHouse2,
        MarsGocharaInHouse3,
        MarsGocharaInHouse4,
        MarsGocharaInHouse5,
        MarsGocharaInHouse6,
        MarsGocharaInHouse7,
        MarsGocharaInHouse8,
        MarsGocharaInHouse9,
        MarsGocharaInHouse10,
        MarsGocharaInHouse11,
        MarsGocharaInHouse12,
        MercuryGocharaInHouse1,
        MercuryGocharaInHouse2,
        MercuryGocharaInHouse3,
        MercuryGocharaInHouse4,
        MercuryGocharaInHouse5,
        MercuryGocharaInHouse6,
        MercuryGocharaInHouse7,
        MercuryGocharaInHouse8,
        MercuryGocharaInHouse9,
        MercuryGocharaInHouse10,
        MercuryGocharaInHouse11,
        MercuryGocharaInHouse12,
        JupiterGocharaInHouse1,
        JupiterGocharaInHouse2,
        JupiterGocharaInHouse3,
        JupiterGocharaInHouse4,
        JupiterGocharaInHouse5,
        JupiterGocharaInHouse6,
        JupiterGocharaInHouse7,
        JupiterGocharaInHouse8,
        JupiterGocharaInHouse9,
        JupiterGocharaInHouse10,
        JupiterGocharaInHouse11,
        JupiterGocharaInHouse12,
        VenusGocharaInHouse1,
        VenusGocharaInHouse2,
        VenusGocharaInHouse3,
        VenusGocharaInHouse4,
        VenusGocharaInHouse5,
        VenusGocharaInHouse6,
        VenusGocharaInHouse7,
        VenusGocharaInHouse8,
        VenusGocharaInHouse9,
        VenusGocharaInHouse10,
        VenusGocharaInHouse11,
        VenusGocharaInHouse12,
        SaturnGocharaInHouse1,
        SaturnGocharaInHouse2,
        SaturnGocharaInHouse3,
        SaturnGocharaInHouse4,
        SaturnGocharaInHouse5,
        SaturnGocharaInHouse6,
        SaturnGocharaInHouse7,
        SaturnGocharaInHouse8,
        SaturnGocharaInHouse9,
        SaturnGocharaInHouse10,
        SaturnGocharaInHouse11,
        SaturnGocharaInHouse12,
        RahuGocharaInHouse1,
        RahuGocharaInHouse2,
        RahuGocharaInHouse3,
        RahuGocharaInHouse4,
        RahuGocharaInHouse5,
        RahuGocharaInHouse6,
        RahuGocharaInHouse7,
        RahuGocharaInHouse8,
        RahuGocharaInHouse9,
        RahuGocharaInHouse10,
        RahuGocharaInHouse11,
        RahuGocharaInHouse12,
        KetuGocharaInHouse1,
        KetuGocharaInHouse2,
        KetuGocharaInHouse3,
        KetuGocharaInHouse4,
        KetuGocharaInHouse5,
        KetuGocharaInHouse6,
        KetuGocharaInHouse7,
        KetuGocharaInHouse8,
        KetuGocharaInHouse9,
        KetuGocharaInHouse10,
        KetuGocharaInHouse11,
        KetuGocharaInHouse12,
        AriesSunDasa,
        TaurusSunDasa,
        GeminiSunDasa,
        CancerSunDasa,
        LeoSunDasa,
        VirgoSunDasa,
        LibraSunDasa,
        ScorpioSunDasa,
        SagittariusSunDasa,
        CapricornusSunDasa,
        AquariusSunDasa,
        PiscesSunDasa,
        AriesMoonDasa,
        TaurusMoonDasa,
        GeminiMoonDasa,
        CancerMoonDasa,
        LeoMoonDasa,
        VirgoMoonDasa,
        LibraMoonDasa,
        ScorpioMoonDasa,
        SagittariusMoonDasa,
        CapricornusMoonDasa,
        AquariusMoonDasa,
        PiscesMoonDasa,
        AriesMarsDasa,
        TaurusMarsDasa,
        GeminiMarsDasa,
        CancerMarsDasa,
        LeoMarsDasa,
        VirgoMarsDasa,
        LibraMarsDasa,
        ScorpioMarsDasa,
        SagittariusMarsDasa,
        CapricornusMarsDasa,
        AquariusMarsDasa,
        PiscesMarsDasa,
        AriesRahuDasa,
        TaurusRahuDasa,
        GeminiRahuDasa,
        CancerRahuDasa,
        LeoRahuDasa,
        VirgoRahuDasa,
        LibraRahuDasa,
        ScorpioRahuDasa,
        SagittariusRahuDasa,
        CapricornusRahuDasa,
        AquariusRahuDasa,
        PiscesRahuDasa,
        AriesJupiterDasa,
        TaurusJupiterDasa,
        GeminiJupiterDasa,
        CancerJupiterDasa,
        LeoJupiterDasa,
        VirgoJupiterDasa,
        LibraJupiterDasa,
        ScorpioJupiterDasa,
        SagittariusJupiterDasa,
        CapricornusJupiterDasa,
        AquariusJupiterDasa,
        PiscesJupiterDasa,
        AriesSaturnDasa,
        TaurusSaturnDasa,
        GeminiSaturnDasa,
        CancerSaturnDasa,
        LeoSaturnDasa,
        VirgoSaturnDasa,
        LibraSaturnDasa,
        ScorpioSaturnDasa,
        SagittariusSaturnDasa,
        CapricornusSaturnDasa,
        AquariusSaturnDasa,
        PiscesSaturnDasa,
        AriesMercuryDasa,
        TaurusMercuryDasa,
        GeminiMercuryDasa,
        CancerMercuryDasa,
        LeoMercuryDasa,
        VirgoMercuryDasa,
        LibraMercuryDasa,
        ScorpioMercuryDasa,
        SagittariusMercuryDasa,
        CapricornusMercuryDasa,
        AquariusMercuryDasa,
        PiscesMercuryDasa,
        AriesKetuDasa,
        TaurusKetuDasa,
        GeminiKetuDasa,
        CancerKetuDasa,
        LeoKetuDasa,
        VirgoKetuDasa,
        LibraKetuDasa,
        ScorpioKetuDasa,
        SagittariusKetuDasa,
        CapricornusKetuDasa,
        AquariusKetuDasa,
        PiscesKetuDasa,
        AriesVenusDasa,
        TaurusVenusDasa,
        GeminiVenusDasa,
        CancerVenusDasa,
        LeoVenusDasa,
        VirgoVenusDasa,
        LibraVenusDasa,
        ScorpioVenusDasa,
        SagittariusVenusDasa,
        CapricornusVenusDasa,
        AquariusVenusDasa,
        PiscesVenusDasa,
        Lord6And8Dasa,
        Lord5And9Dasa,
        BhuktiDasaLordInBadHouses,
        MarsVenusIn7th,
        MercuryOrJupiterIn7th,
        LeoLagna7thLordSaturnIn2,
        SaturnIn7thNotLagnaLord,
        MarsIn7thNoBenefics,
        SunVenusIn5th7th9th,
        Lord7And1Friends,
        Lord7And1NotFriends,
        SaturnIn7th,
        SunDasaSunBhukti,
        SunDasaMoonBhukti,
        SunDasaMarsBhukti,
        SunDasaRahuBhukti,
        SunDasaJupiterBhukti,
        SunDasaSaturnBhukti,
        SunDasaMercuryBhukti,
        SunDasaKetuBhukti,
        SunDasaVenusBhukti,
        MoonDasaSunBhukti,
        MoonDasaMoonBhukti,
        MoonDasaMarsBhukti,
        MoonDasaRahuBhukti,
        MoonDasaJupiterBhukti,
        MoonDasaSaturnBhukti,
        MoonDasaMercuryBhukti,
        MoonDasaKetuBhukti,
        MoonDasaVenusBhukti,
        MarsDasaSunBhukti,
        MarsDasaMoonBhukti,
        MarsDasaMarsBhukti,
        MarsDasaRahuBhukti,
        MarsDasaJupiterBhukti,
        MarsDasaSaturnBhukti,
        MarsDasaMercuryBhukti,
        MarsDasaKetuBhukti,
        MarsDasaVenusBhukti,
        RahuDasaSunBhukti,
        RahuDasaMoonBhukti,
        RahuDasaMarsBhukti,
        RahuDasaRahuBhukti,
        RahuDasaJupiterBhukti,
        RahuDasaSaturnBhukti,
        RahuDasaMercuryBhukti,
        RahuDasaKetuBhukti,
        RahuDasaVenusBhukti,
        JupiterDasaSunBhukti,
        JupiterDasaMoonBhukti,
        JupiterDasaMarsBhukti,
        JupiterDasaRahuBhukti,
        JupiterDasaJupiterBhukti,
        JupiterDasaSaturnBhukti,
        JupiterDasaMercuryBhukti,
        JupiterDasaKetuBhukti,
        JupiterDasaVenusBhukti,
        SaturnDasaSunBhukti,
        SaturnDasaMoonBhukti,
        SaturnDasaMarsBhukti,
        SaturnDasaRahuBhukti,
        SaturnDasaJupiterBhukti,
        SaturnDasaSaturnBhukti,
        SaturnDasaMercuryBhukti,
        SaturnDasaKetuBhukti,
        SaturnDasaVenusBhukti,
        MercuryDasaSunBhukti,
        MercuryDasaMoonBhukti,
        MercuryDasaMarsBhukti,
        MercuryDasaRahuBhukti,
        MercuryDasaJupiterBhukti,
        MercuryDasaSaturnBhukti,
        MercuryDasaMercuryBhukti,
        MercuryDasaKetuBhukti,
        MercuryDasaVenusBhukti,
        KetuDasaSunBhukti,
        KetuDasaMoonBhukti,
        KetuDasaMarsBhukti,
        KetuDasaRahuBhukti,
        KetuDasaJupiterBhukti,
        KetuDasaSaturnBhukti,
        KetuDasaMercuryBhukti,
        KetuDasaKetuBhukti,
        KetuDasaVenusBhukti,
        VenusDasaSunBhukti,
        VenusDasaMoonBhukti,
        VenusDasaMarsBhukti,
        VenusDasaRahuBhukti,
        VenusDasaJupiterBhukti,
        VenusDasaSaturnBhukti,
        VenusDasaMercuryBhukti,
        VenusDasaKetuBhukti,
        VenusDasaVenusBhukti,
        SunAntaram,
        MoonAntaram,
        MarsAntaram,
        RahuAntaram,
        JupiterAntaram,
        SaturnAntaram,
        MercuryAntaram,
        KetuAntaram,
        VenusAntaram,
        SunInAries,
        SunInTaurus,
        SunInGemini,
        SunInCancer,
        SunInLeo,
        SunInVirgo,
        SunInLibra,
        SunInScorpio,
        SunInSagittarius,
        SunInCapricornus,
        SunInAquarius,
        SunInPisces,
        MoonInAries,
        MoonInTaurus,
        MoonInGemini,
        MoonInCancer,
        MoonInLeo,
        MoonInVirgo,
        MoonInLibra,
        MoonInScorpio,
        MoonInSagittarius,
        MoonInCapricornus,
        MoonInAquarius,
        MoonInPisces,
        MarsInAries,
        MarsInTaurus,
        MarsInGemini,
        MarsInCancer,
        MarsInLeo,
        MarsInVirgo,
        MarsInLibra,
        MarsInScorpio,
        MarsInSagittarius,
        MarsInCapricornus,
        MarsInAquarius,
        MarsInPisces,
        MercuryInAries,
        MercuryInTaurus,
        MercuryInGemini,
        MercuryInCancer,
        MercuryInLeo,
        MercuryInVirgo,
        MercuryInLibra,
        MercuryInScorpio,
        MercuryInSagittarius,
        MercuryInCapricornus,
        MercuryInAquarius,
        MercuryInPisces,
        JupiterInAries,
        JupiterInTaurus,
        JupiterInGemini,
        JupiterInCancer,
        JupiterInLeo,
        JupiterInVirgo,
        JupiterInLibra,
        JupiterInScorpio,
        JupiterInSagittarius,
        JupiterInCapricornus,
        JupiterInAquarius,
        JupiterInPisces,
        VenusInAries,
        VenusInTaurus,
        VenusInGemini,
        VenusInCancer,
        VenusInLeo,
        VenusInVirgo,
        VenusInLibra,
        VenusInScorpio,
        VenusInSagittarius,
        VenusInCapricornus,
        VenusInAquarius,
        VenusInPisces,
        SaturnInAries,
        SaturnInTaurus,
        SaturnInGemini,
        SaturnInCancer,
        SaturnInLeo,
        SaturnInVirgo,
        SaturnInLibra,
        SaturnInScorpio,
        SaturnInSagittarius,
        SaturnInCapricornus,
        SaturnInAquarius,
        SaturnInPisces,
        BadLunarMonthForBuilding,
        GoodSunSignForBuilding,
        BadSunSignForBuilding,
        GoodLunarDayForBuilding,
        GoodWeekDayForBuilding,
        BadLunarPhaseForBuilding,
        BadWeekDayForBuilding,
        BadWeekDayForRepairs,
        GoodYogaForRepairs,
        GoodYogaForRepairs2
    }
}
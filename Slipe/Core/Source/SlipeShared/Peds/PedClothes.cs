﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Peds
{
    /// <summary>
    /// Represents the slot of cothes
    /// </summary>
    public enum ClothesSlot
    {
        Shirt,
        Head,
        Trousers,
        Shoes,
        LeftUpperArmTattoo,
        LeftLowerArmTattoo,
        RightUpperArmTattoo,
        RightLowerArmTattoo,
        BackTattoo,
        LeftChestTattoo,
        RightChestTatto,
        StomachTattoo,
        LowerBackTattoo,
        Necklace,
        Watch,
        Glasses,
        Hat,
        Extra
    }

    /// <summary>
    /// Represents the texture that is used for a clothes slot
    /// </summary>
    public enum ClothesTexture
    {
        player_torso,
        vestblack,
        vest,
        tshirt2horiz,
        tshirtwhite,
        tshirtilovels,
        tshirtblunts,
        shirtbplaid,
        shirtbcheck,
        field,
        tshirterisyell,
        tshirterisorn,
        trackytop2eris,
        bbjackrim,
        bballjackrstar,
        baskballdrib,
        baskballrim,
        sixtyniners,
        bandits,
        tshirtprored,
        tshirtproblk,
        trackytop1pro,
        hockeytop,
        bbjersey,
        shellsuit,
        tshirtheatwht,
        tshirtbobomonk,
        tshirtbobored,
        tshirtbase5,
        tshirtsuburb,
        hoodyamerc,
        hoodyabase5,
        hoodyarockstar,
        wcoatblue,
        coach,
        coachsemi,
        sweatrstar,
        hoodyAblue,
        hoodyAblack,
        hoodyAgreen,
        sleevtbrown,
        shirtablue,
        shirtayellow,
        shirtagrey,
        shirtbgang,
        tshirtzipcrm,
        tshirtzipgry,
        denimfade,
        bowling,
        hoodjackbeige,
        baskballloc,
        tshirtlocgrey,
        tshirtmaddgrey,
        tshirtmaddgrn,
        suit1grey,
        suit1blk,
        leather,
        painter,
        hawaiiwht,
        hawaiired,
        sportjack,
        suit1red,
        suit1blue,
        suit1yellow,
        suit2grn,
        tuxedo,
        suit1gang,
        letter,
        player_face,
        hairblond,
        hairred,
        hairblue,
        hairgreen,
        hairpink,
        bald,
        baldbeard,
        baldtash,
        baldgoatee,
        highfade,
        highafro,
        wedge,
        slope,
        jhericurl,
        cornrows,
        cornrowsb,
        tramline,
        groovecut,
        mohawk,
        mohawkblond,
        mohawkpink,
        mohawkbeard,
        afro,
        afrotash,
        afrobeard,
        afroblond,
        flattop,
        elvishair,
        beard,
        tash,
        goatee,
        afrogoatee,
        player_legs,
        worktrcamogrn,
        worktrcamogry,
        worktrgrey,
        worktrkhaki,
        tracktr,
        tracktreris,
        jeansdenim,
        legsblack,
        legsheart,
        biegetr,
        tracktrpro,
        tracktrwhstr,
        tracktrblue,
        tracktrgang,
        bbshortwht,
        boxshort,
        bbshortred,
        shellsuittr,
        shortsgrey,
        shortskhaki,
        chongergrey,
        chongergang,
        chongerred,
        chongerblue,
        shortsgang,
        denimsgang,
        denimsred,
        chinosbiege,
        chinoskhaki,
        cutoffchinos,
        cutoffchinosblue,
        chinosblack,
        chinosblue,
        leathertr,
        leathertrchaps,
        suit1trgrey,
        suit1trblk,
        cutoffdenims,
        suit1trred,
        suit1trblue,
        suit1tryellow,
        suit1trgreen,
        suit1trblk2,
        suit1trgang,
        foot,
        cowboyboot2,
        bask2semi,
        bask1eris,
        sneakerbincgang,
        sneakerbincblue,
        sneakerbincblk,
        sandal,
        sandalsock,
        flipflop,
        hitop,
        convproblk,
        convproblu,
        convprogrn,
        sneakerprored,
        sneakerproblu,
        sneakerprowht,
        bask1prowht,
        bask1problk,
        boxingshoe,
        convheatblk,
        convheatred,
        convheatorn,
        sneakerheatwht,
        sneakerheatgry,
        sneakerheatblk,
        bask2heatwht,
        bask2heatband,
        timbergrey,
        timberred,
        timberfawn,
        timberhike,
        cowboyboot,
        biker,
        snakeskin,
        shoedressblk,
        shoedressbrn,
        shoespatz,
        WEED,
        RIP,
        SPIDER,
        GUN,
        GUN2,
        CROSS,
        CROSS2,
        CROSS3,
        AZTEC,
        CROWN,
        CLOWN,
        AFRICA,
        MARY,
        SA,
        SA2,
        SA3,
        WESTSD,
        SANTOS,
        POKER,
        HOMBY,
        BULLT,
        RASTA,
        LS,
        LS2,
        LS3,
        LS4,
        LS5,
        OG,
        GROVE,
        GROV2,
        GROV3,
        DICE,
        DICE2,
        JAIL,
        GGFIT,
        ANGEL,
        MAYBR,
        DAGER,
        BNDIT,
        MYFAC,
        dogtag,
        neckafrica,
        stopwatch,
        necksaints,
        neckhash,
        necksilver,
        neckgold,
        neckropes,
        neckropeg,
        neckls,
        neckdollar,
        neckcross,
        watchpink,
        watchyellow,
        watchpro,
        watchpro2,
        watchsub1,
        watchsub2,
        watchzip1,
        watchzip2,
        watchgno,
        watchgno2,
        watchcro,
        watchcro2,
        groucho,
        zorro,
        eyepatch,
        glasses01,
        glasses04,
        bandred3,
        bandblue3,
        bandgang3,
        bandblack3,
        glasses01dark,
        glasses04dark,
        glasses03,
        glasses03red,
        glasses03blue,
        glasses03dark,
        glasses05dark,
        glasses05,
        bandred,
        bandblue,
        bandgang,
        bandblack,
        bandred2,
        bandblue2,
        bandblack2,
        bandgang2,
        capknitgrn,
        captruck,
        cowboy,
        hattiger,
        helmet,
        moto,
        boxingcap,
        hockey,
        capgang,
        capgangback,
        capgangside,
        capgangover,
        capgangup,
        bikerhelmet,
        capred,
        capredback,
        capredside,
        capredover,
        capredup,
        capblue,
        capblueback,
        capblueside,
        capblueover,
        capblueup,
        skullyblk,
        skullygrn,
        hatmancblk,
        hatmancplaid,
        capzip,
        capzipback,
        capzipside,
        capzipover,
        capzipup,
        beretred,
        beretblk,
        capblk,
        capblkback,
        capblkside,
        capblkover,
        capblkup,
        trilbydrk,
        trilbylght,
        bowler,
        bowlerred,
        bowlerblue,
        bowleryellow,
        boater,
        bowlergang,
        boaterblk,
        gimpleg,
        valet,
        countrytr,
        croupier,
        policetr,
        balaclava,
        pimptr,
        garageleg,
        medictr
    }

    /// <summary>
    /// Represents the model that is used for a clothes slot
    /// </summary>
    public enum ClothesModel
    {
        torso,
        vest,
        tshirt2,
        tshirt,
        shirtb,
        field,
        trackytop1,
        bbjack,
        baskball,
        baseball,
        sweat,
        sleevt,
        hoodya,
        wcoat,
        coach,
        hoodyA,
        shirta,
        denim,
        hawaii,
        hoodjack,
        suit1,
        leather,
        painter,
        suit2,
        head,
        highafro,
        wedge,
        slope,
        jheri,
        cornrows,
        tramline,
        groovecut,
        mohawk,
        afro,
        flattop,
        elvishair,
        legs,
        worktr,
        tracktr,
        jeans,
        chinosb,
        boxingshort,
        shorts,
        chonger,
        leathertr,
        suit1tr,
        feet,
        biker,
        bask1,
        sneaker,
        flipflop,
        conv,
        shoe,
        weed,
        rip,
        spider,
        gun,
        gun2,
        cross,
        cross2,
        cross3,
        aztec,
        crown,
        clown,
        africa,
        mary,
        sa,
        sa2,
        sa3,
        westside,
        santos,
        poker,
        homeboy,
        bullet,
        rasta,
        ls,
        ls2,
        ls3,
        ls4,
        ls5,
        og,
        grove,
        grove2,
        grove3,
        dice,
        dice2,
        jail,
        godsgift,
        angels,
        mayabird,
        dagger,
        bandit,
        cross7,
        mayafce,
        neck,
        neck2,
        watch,
        grouchos,
        zorromask,
        eyepatch,
        glasses01,
        glasses04,
        bandmask,
        glasses03,
        bandana,
        bandknots,
        capknit,
        captruck,
        cowboy,
        helmet,
        moto,
        boxingcap,
        hockeymask,
        cap,
        capback,
        capside,
        capovereye,
        caprimup,
        bikerhelmet,
        skullycap,
        hatmanc,
        beret,
        trilby,
        bowler,
        boater,
        gimpleg,
        valet,
        countrytr,
        policetr,
        balaclava,
        pimptr,
        garagetr,
        medictr
    }
}
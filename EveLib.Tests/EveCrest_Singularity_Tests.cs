﻿using System.Threading.Tasks;
using eZet.EveLib.Core.RequestHandlers;
using eZet.EveLib.EveCrestModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eZet.EveLib.Test {
    [TestClass]
    public class EveCrest_Singularity_Tests {
        private readonly string encodedKey =
            "Y2VmZTYwMWQ5ZjVhNDQ0MTgzZjhjNzMyNjc2NzA5ZmI6R3dnM0pOVDhWMERMWndiN1ptUmtlOXpKRFlwMWVQblVtOVY1enZqWQ==";

        private readonly string refreshToken = "UHtPutexwinz1u6xWC5S2Dj39GTDLgnLgUTQSyTvM1nTryMU7NbsmKWL9I32vTPd0";

        public EveCrest_Singularity_Tests() {
            Crest = new EveCrest(refreshToken, encodedKey);
            Crest.Host = "https://api-sisi.testeveonline.com/";
            Crest.EveAuth.Host = "sisilogin.testeveonline.com";
            Crest.RequestHandler.ThrowOnDeprecated = true;
            Crest.RequestHandler.ThrowOnMissingContentType = true;
            Crest.EnableAutomaticPaging = true;
            Crest.RequestHandler.CacheLevel = CacheLevel.BypassCache;
        }


        public EveCrest Crest { get; set; }

     
    }
}
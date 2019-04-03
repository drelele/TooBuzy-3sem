using Funq;
using ServiceStack.WebHost.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("TooBuzy Services", typeof(AppHost).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            //Smid konfiguration ind, som ServiceStack skal bruge til containeren.
        }
    }
}
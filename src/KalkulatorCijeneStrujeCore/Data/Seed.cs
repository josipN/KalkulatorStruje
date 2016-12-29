using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KalkulatorCijeneStrujeCore.Models.MojeKlase;

namespace KalkulatorCijeneStrujeCore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MojContext context)
        {
            /*context.Database.EnsureCreated();

            if (context.Izvijestaji.Any())
            {
                return;
            }

            var izvijestaji = new Izvijestaj[]
            {
            new Izvijestaj{UID="5292e653-f55d-427f-9286-6877a1e0f430",DatumUnosa=DateTime.Now,Value=33.33},
            new Izvijestaj{ UID="5292e653-f55d-427f-9286-6877a1e0f430",DatumUnosa=DateTime.Now,Value=34.33},
            new Izvijestaj{UID="5292e653-f55d-427f-9286-6877a1e0f430",DatumUnosa=DateTime.Now,Value=35.33},
            new Izvijestaj{UID="5292e653-f55d-427f-9286-6877a1e0f430",DatumUnosa=DateTime.Now,Value=36.33},

            new Izvijestaj{UID="b218bbd1-d83f-45ac-9ff1-e30be3c72b1c",DatumUnosa=DateTime.Now,Value=36.33},
            new Izvijestaj{  UID="b218bbd1-d83f-45ac-9ff1-e30be3c72b1c",DatumUnosa=DateTime.Now,Value=36.33},
            new Izvijestaj{ UID="b218bbd1-d83f-45ac-9ff1-e30be3c72b1c",DatumUnosa=DateTime.Now,Value=36.33},

            new Izvijestaj{ UID="c1aa278e -dd99-4de8-b85d-70d40b36f73e",DatumUnosa=DateTime.Now,Value=36.33}
            };
            foreach (Izvijestaj s in izvijestaji)
            {
                context.Izvijestaji.Add(s);
            }*/
            context.SaveChanges();
        }
    }
}

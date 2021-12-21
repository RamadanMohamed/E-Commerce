using core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(storecontext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.producBrands.Any())
                {
                    var brandData =
                    File.ReadAllText("../infrastructure/Data/SeedData/brands.json");
                    var brands = JsonSerializer.Deserialize<List<ProducBrand>>(brandData);
                    foreach (var item in brands)
                    {
                        context.producBrands.Add(item);
                        await context.SaveChangesAsync();
                    }
                }
                if (!context.prodctTypes.Any())
                {
                    var typesdData =
                    File.ReadAllText("../infrastructure/Data/SeedData/types.json");
                    var types = JsonSerializer.Deserialize<List<prodctType>>(typesdData);
                    foreach (var item in types)
                    {
                        context.prodctTypes.Add(item);
                        await context.SaveChangesAsync();
                    }
                }
                if (!context.products.Any())
                {
                    var ProductData =
                    File.ReadAllText("../infrastructure/Data/SeedData/products.json");
                    var Prducts = JsonSerializer.Deserialize<List<product>>(ProductData);
                    foreach (var item in Prducts)
                    {
                        context.products.Add(item);
                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                var loggerfactory = loggerFactory.CreateLogger<StoreContextSeed>();
                loggerfactory.LogError(ex.Message);
            }







        }
            }
            }

    


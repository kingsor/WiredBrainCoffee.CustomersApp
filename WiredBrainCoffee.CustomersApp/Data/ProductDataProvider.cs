// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomersApp.Models;

namespace WiredBrainCoffee.CustomersApp.Data
{
    public class ProductDataProvider : IProductDataProvider
    {
        public async Task<IEnumerable<Product>?> GetAllAsync()
        {
            await Task.Delay(100);

            return new List<Product>
            {
                new Product { Name = "Cappuccino", Description = "Espresso with milk and milk foam"},
                new Product { Name = "Doppio", Description = "Double Espresso"},
                new Product { Name = "Espresso", Description = "Pure coffee to keep you awake! :-)"},
                new Product { Name = "Latte", Description = "Cappuccino with more streamed milk"},
                new Product { Name = "Macchiato", Description = "Espresso with milk foam"},
                new Product { Name = "Mocha", Description = "Espresso with hot chocolate and milk foam"}
            };
        }
    }
}

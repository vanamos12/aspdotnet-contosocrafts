﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContainsCraftWebsite.Models;
using ContainsCraftWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContainsCraftWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductsService ProductService;
        public IEnumerable<Product> products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductsService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            products = ProductService.GetProducts();
        }
    }
}

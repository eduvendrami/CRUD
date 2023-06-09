﻿using CRUD_Products.Models.Products.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Products.Models.Product.Service
{
    public interface IProductService
    {
        public Task<ActionResult<string>> RegisterProductAsync(
            ProductRequest product);

        public Task<ActionResult<IEnumerable<ProductResponse>>> ReadProductAsync(
            ProductRequest product);

        public Task<ActionResult<string>> UpdateProductAsync(
            ProductRequest product);
        public Task<ActionResult<string>> DeleteProductAsync(
            ProductRequest product);
    }
}

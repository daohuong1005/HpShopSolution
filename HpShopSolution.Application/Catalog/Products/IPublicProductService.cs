using HpShopSolution.Application.Catalog.Products.Dtos;
using HpShopSolution.Application.Catalog.Products.Dtos.Public;
using HpShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HpShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}

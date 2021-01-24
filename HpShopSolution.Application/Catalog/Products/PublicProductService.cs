using HpShopSolution.Application.Catalog.Products.Dtos;
using HpShopSolution.Application.Catalog.Products.Dtos.Manage;
using HpShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HpShopSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {

        public PageResult<ProductViewModel> GetAllByCategoryId(Dtos.Public.GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

using HpShopSolution.Application.Catalog.Products.Dtos;
using HpShopSolution.Application.Catalog.Products.Dtos.Manage;
using HpShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HpShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int ProductId);
        Task<List<ProductViewModel>> GetAll();
        Task<bool> UpdatePrice(int ProductId, decimal NewPrice);
        Task<bool> UpdateStock(int ProductId, int addedQuantity);
        Task AddViewCount(int ProductId);
        Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}

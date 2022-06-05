using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Persistence.Concrete
{
    public class ProductService : IProductService
    {
        // Target Type özelliğidir bu nesnenin tipini belirtmeden new () diyerek tanımlamaya denir.
        public List<Product> GetProducts() => new() { 
                new() { Id = new Guid(), Name ="Product 1" , Stock=10,Price=100},        
                new() { Id = new Guid(), Name ="Product 2" , Stock=12,Price=200},        
                new() { Id = new Guid(), Name ="Product 3" , Stock=13,Price=300},        
                new() { Id = new Guid(), Name ="Product 4" , Stock=14,Price=400},
        };
    }
}

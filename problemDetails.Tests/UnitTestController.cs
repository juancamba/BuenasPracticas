using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using problemDetails.Controllers;
using problemDetails.Data;
using problemDetails.Models;
using Xunit;

namespace problemDetails.Tests;

public class UnitTestController
{

    private readonly Mock<IProductRepo> _productRepo;
    public UnitTestController()
    {
        _productRepo = new Mock<IProductRepo>();
    }


    [Fact]
    public async void Test1()
    {
        var productList = GetProductsData();
        _productRepo.Setup(x => x.GetProducts()).ReturnsAsync(productList);
        //mock of ilogger
        var logger = Mock.Of<ILogger<ProductController>>();
        var productController = new ProductController(_productRepo.Object, logger);


        //act
        var actionResult = await productController.ProductList() ;
        
        //assert
        Assert.NotNull(actionResult);

        Assert.Equal(productList, ((ObjectResult)actionResult.Result).Value); // Try this it should work
     



    }

    private List<Product> GetProductsData()
    {
        List<Product> products = new List<Product>(){
            new Product() { Sku = "2345mhg", Name = "Dodge Charger", Units = 5 , Price = 25.6 },
                    new Product() { Sku = "camaro01", Name = "Chevrolet Cambar", Units = 15 , Price = 16.5 }

        };

        return products;

    }
}
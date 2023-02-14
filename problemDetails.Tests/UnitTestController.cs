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
    public void Test1()
    {
        var productList = GetProductsData();
        _productRepo.Setup(x => x.GetProducts()).Returns(productList);
        //mock of ilogger
        var logger = Mock.Of<ILogger<ProductController>>();
        var productController = new ProductController(_productRepo.Object, logger);


        //act
        var result = productController.ProductList();

        //assert
        Assert.NotNull(result);

        //var items = Assert.IsType<ActionResult<IEnumerable<Product>>>(productResult.Value);
        //Assert.Equal(productList.Count, items.Result.);
        //Assert.Equal(GetProductsData().ToString(), productResult.ToString());
        //Assert.True(productList.Equals(productResult));

        var okResult = result.Result as OkObjectResult;

        okResult.Should().NotBeNull();
        okResult?.StatusCode.Should().Be(200);


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
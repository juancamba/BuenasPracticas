// Ejemplo de como guardar datos relacionados: basado en el ejemplos
// https://learn.microsoft.com/en-us/aspnet/web-api/overview/older-versions/using-web-api-1-with-entity-framework-5/using-web-api-with-entity-framework-part-6

using EFOrderDetail;

Console.WriteLine("Hello, World!");
using (var context = new OrderContext())
{
    // creamos productos
    var products = new List<Product>()
            {
                new Product() { Name = "Tomato Soup", Price = 1.39M, ActualCost = .99M },
                new Product() { Name = "Hammer", Price = 16.99M, ActualCost = 10 },
                new Product() { Name = "Yo yo", Price = 6.99M, ActualCost = 2.05M }
            };
    products.ForEach(p => context.Products.Add(p));
    context.SaveChanges();
    // creamos un order
    var order = new Order() { Customer = "Bob" };
    var od = new List<OrderDetail>()
            {
                new OrderDetail() { Product = products[0], Quantity = 2, Order = order},
                new OrderDetail() { Product = products[1], Quantity = 4, Order = order }
            };
    context.Orders.Add(order);
    od.ForEach(o => context.OrderDetails.Add(o));

    context.SaveChanges();

    var orders = context.Orders.ToList();
}



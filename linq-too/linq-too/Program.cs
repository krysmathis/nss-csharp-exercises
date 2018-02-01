using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace linq_too
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer(1,"Jim","Jiminy"),
                new Customer(2,"Bob","Bobiny")

            };

            List<Order> orders = new List<Order>{
                new Order(1,1,1,DateTime.Now),
                new Order(2,1,1,DateTime.Now)
            };

            List<OrderProduct> orderProducts = new List<OrderProduct>{
                new OrderProduct(orderProductId:1 ,orderId: 1, productId: 1),
                new OrderProduct(orderProductId:2 ,orderId: 1, productId: 2)
            };

            List<Product> products = new List<Product>{
                new Product(productId:1, productCategoryId: 1, customerId:1,name:"Hammer",price:25.00,description:"Single handled hammer",quantity:5),
                new Product(productId:2, productCategoryId: 1, customerId:1,name:"Nail",price:25.00,description:"Bag of nails",quantity:5)
            };

            var prodResults = products
                            .Where(p => orderProducts
                                .Where(op => op.OrderId == 1)
                                .Any(op => op.ProductId == p.ProductId));

            var orderObj = orders
                .Where(o => o.OrderId == 1)
                .Select(o => new 
                {
                    orderId = o.OrderId,
                    customerId = o.CustomerId,
                    products = prodResults
                }).Single();

          
            var customer = customers.Where(c =>
                orders.Any(o => o.CustomerId == c.CustomerId));
        

            Console.WriteLine($"{orderObj.customerId}");
            Console.WriteLine($"{orderObj.orderId}");

            foreach (var item in orderObj.products)
            {
                Console.WriteLine(item.Name);
            }
         
        
        
        }

}

[DataContract]
public class OrderDetail
{

    public OrderDetail(int orderId, int customerId, IEnumerable products)
    {
        this.OrderId = orderId;
        this.CustomerId = customerId;
        this.Products = products;

    }
    [DataMember] 
    public int OrderId { get; set; }
    [DataMember] 
    public int CustomerId { get; set; }
    [DataMember] 
    public IEnumerable Products { get; set; }

}

public class Customer
{



    public Customer(int customerId, string firstName, string lastName)
    {
        this.CustomerId = customerId;
        this.FirstName = firstName;
        this.LastName = lastName;

    }
    public int CustomerId { get; set; }

    [Required]
    [StringLength(55)]
    public string FirstName { get; set; }
    [Required]
    [StringLength(55)]
    public string LastName { get; set; }

}


public class Order
{
    public Order(int orderId, int customerId, int paymentTypeId, DateTime completedDate)
    {
        this.OrderId = orderId;
        this.CustomerId = customerId;
        this.PaymentTypeId = paymentTypeId;
        this.CompletedDate = completedDate;

    }
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public int PaymentTypeId { get; set; }
    public DateTime CompletedDate { get; set; }
}

public class OrderProduct
{


    public OrderProduct(int orderProductId, int orderId, int productId)
    {
        this.OrderProductId = orderProductId;
        this.OrderId = orderId;
        this.ProductId = productId;

    }
    public int OrderProductId { get; set; }

    [Required]
    public int OrderId { get; set; }

    [Required]
    public int ProductId { get; set; }
}

public class Product
{

    public Product(int productId, int productCategoryId, int customerId, string name, double price, string description, int quantity)
    {
        this.ProductId = productId;
        this.ProductCategoryId = productCategoryId;
        this.CustomerId = customerId;
        this.Name = name;
        this.Price = price;
        this.Description = description;
        this.Quantity = quantity;

    }
    public int ProductId { get; set; }

    [Required]
    public int ProductCategoryId { get; set; }

    [Required]
    public int CustomerId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public int Quantity { get; set; }

}

public class ProductCategory
{

    public int ProductCategoryId { get; set; }

    [Required]
    [StringLength(55)]
    public string Name { get; set; }


}
}


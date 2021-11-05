using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;

namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                var products = AWEntities.Product;

                //IQueryable<String> productNames = from p in products
                //                                  select p.Name;

                //IQueryable<String> productNames = products.Select(p => p.Name);

                IQueryable<Product> productsQuery = from p in products
                                                    select p;

                IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");



                Console.WriteLine("Productos de tamaño 'L' : ");
                foreach (var product in largeProducts)
                {
                    Console.WriteLine(product.Name + " - " + product.ProductID);
                }
                Console.ReadKey();
            }

            // ejercicio 8
            int orderQtyMin = 5;
            int orderQtyMax = 6;

            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var query = from order in context.SalesOrderDetail
                            where order.OrderQty > orderQtyMin
                            && order.OrderQty < orderQtyMax
                            select new
                            {
                                SalesOrderID = order.SalesOrderID,
                                OrderQty = order.OrderQty
                            };

                foreach (var order in query)
                {
                    Console.WriteLine("Order ID: {0} Order quantity: {1}",
                        order.SalesOrderID, order.OrderQty);
                }
                Console.ReadKey();

            }

            //ejercicio 10
            using (AdventureWorksEntities eje10Entities = new AdventureWorksEntities())
            {
                int?[] productModelIds = { 19, 26, 118 };
                var products = from p in eje10Entities.Product
                               where productModelIds.Contains(p.ProductModelID)
                               select p;

                foreach (var product in products)
                {
                    Console.WriteLine("{0}: {1}",
                        product.ProductModelID, product.ProductID);
                }
                Console.ReadKey();
            }

            //ejercicio 14
            using (AdventureWorksEntities eje14 = new AdventureWorksEntities())
            {
                var products = eje14.Product;
                var query = from product in products
                            group product by product.Style into g
                            select new
                            {
                                Style = g.Key,
                                AverageListPrice = g.Average(product => product.ListPrice)
                            };

                foreach (var product in query)
                {
                    Console.WriteLine("Estilo: {0} Precio promedio: {1}",
                        product.Style, product.AverageListPrice);
                }
                Console.ReadKey();

            }
            //ejercicio 15
            using (AdventureWorksEntities eje15 = new AdventureWorksEntities())
            {
                var products = eje15.Product;
                var query = from product in products
                            group product by product.Color into g
                            select new
                            {
                                Color = g.Key,
                                ProductCount = g.Count()
                            };

                foreach (var product in query)
                {
                    Console.WriteLine("Color: {0} Cantidad: {1}",
                        product.Color, product.ProductCount);
                }
                Console.ReadKey();

            }

            //ejercicio 16
            using (AdventureWorksEntities eje16 = new AdventureWorksEntities())
            {
                var orders = eje16.SalesOrderHeader;
                var query = from order in orders
                            group order by order.SalesPersonID into g
                            select new
                            {
                                Category = g.Key,
                                maxTotalDue = g.Max(order => order.TotalDue)
                            };

                foreach (var order in query)
                {
                    Console.WriteLine("PersonID: {0} TotalDue Máximo : {1}",
                        order.Category,order.maxTotalDue);
                }
                Console.ReadKey();

            }
        }
    }
}

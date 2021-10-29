using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            //var query = from p in context.Products
            //            select p;

            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            //insertar datos
            //Products np = new Products();
            //np.ProductName = "Peruvian Coffee";
            //np.SupplierID = 20;
            //np.CategoryID = 1;
            //np.QuantityPerUnit = "10 pkgs";
            //np.UnitPrice = 25;

            //context.Products.InsertOnSubmit(np);
            //context.SubmitChanges();

            //modificar datos

            //var query1 = from pq1 in context.Products
            //            where pq1.ProductName == "Tofu"
            //            select pq1;

            //foreach (var prod1 in query1)
            //{
            //    Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod1.ProductID, prod1.UnitPrice, prod1.ProductName);
            //}
            

            //var product = (from p in context.Products
            //               where p.ProductName == "Tofu"
            //               select p).FirstOrDefault();

            //product.UnitPrice = 100;
            //product.UnitsInStock = 15;
            //product.Discontinued = true;

            //context.SubmitChanges();

            //var query2 = from pq2 in context.Products
            //             where pq2.ProductName == "Tofu"
            //             select pq2;
            
            //foreach (var prod2 in query2)
            //{
            //    Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod2.ProductID, prod2.UnitPrice, prod2.ProductName);
            //}

            ////eliminacion
            //var productEliminar = (from pe in context.Products
            //                       where pe.ProductID == 78
            //                       select pe).FirstOrDefault();

            //context.Products.DeleteOnSubmit(productEliminar);
            //context.SubmitChanges();

            var query3 = from pq3 in context.Products
                         where pq3.CategoryID == 1
                         select pq3;

            Console.WriteLine("{0,-5} {1,-30} {2,5}\n", "ID", "Name", "Price");
            foreach (var prod3 in query3)
            {
                Console.WriteLine("{0,-5} {1,-30} {2,5}", prod3.ProductID, prod3.ProductName,prod3.UnitPrice);
            }


            Console.ReadKey();
        }
    }
}

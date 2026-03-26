using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem1
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();
            var result = products.Where(p => p.ProCategory == "FMCG").ToList();

            //1.Write a LINQ query to search and display all products with category “FMCG”.

            foreach (var item in result)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }
            Console.WriteLine();

            //2.Write a LINQ query to search and display all products with category “Grain”.

            Console.WriteLine("All products with category “Grain”");
            var res1 = products.Where(p => p.ProCategory == "Grain");
            foreach (var item in res1)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }
            Console.WriteLine();

            //3. Write a LINQ query to sort products in ascending order by product code.

            Console.WriteLine("Sort products in ascending order by product code");
            var res3 = products.OrderBy(p => p.ProCode);
            foreach (var item in res3)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }
            Console.WriteLine();

            //4.Write a LINQ query to sort products in ascending order by product Category.

            Console.WriteLine("Sort products in ascending order by product Category");
            var res4 = products.OrderBy(p => p.ProCategory);
            foreach (var item in res4)
            {
                Console.WriteLine($"{item.ProCategory}\t{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }
            Console.WriteLine();

            //5. Write a LINQ query to sort products in ascending order by product Mrp.

            Console.WriteLine("Sort products in ascending order by product Mrp");
            var res5 = products.OrderBy(p => p.ProMrp);
            foreach (var item in res5)
            {
                Console.WriteLine($"{item.ProMrp}\t{item.ProCategory}\t{item.ProCode}\t{item.ProName}");
            }
            Console.WriteLine();

            //6. Write a LINQ query to sort products in descending order by product Mrp

            Console.WriteLine("Sort products in descending order by product Mrp");

            var res6 = products.OrderByDescending(p => p.ProMrp);
            foreach (var item in res6)
            {
                Console.WriteLine($"{item.ProMrp}\t{item.ProCategory}\t{item.ProCode}\t{item.ProName}");
            }
            Console.WriteLine();

            //7. Write a LINQ query to display products group by product Category.

            Console.WriteLine("Display products group by product Category");
            var res7 = products.GroupBy(p => p.ProCategory);
            foreach (var group in res7)
            {
                Console.WriteLine("Category: " + group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine($"   {item.ProName} {item.ProMrp}");
                }
            }

            //8. Write a LINQ query to display products group by product Mrp.

            Console.WriteLine("Display products group by product Mrp");
            var res8 = products.GroupBy(p => p.ProMrp);
            foreach (var group in res8)
            {
                Console.WriteLine("Mrp: " + group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine($"{item.ProCode} {item.ProName} {item.ProCategory}");
                }
            }

            //9.Write a LINQ query to display product detail with highest price in FMCG category.

            Console.WriteLine("display product detail with highest price in FMCG category");

            var res9 = products.Where(p => p.ProCategory == "FMCG").OrderByDescending(p => p.ProMrp).FirstOrDefault();

            if (res9 != null)
            {
                Console.WriteLine($"{res9.ProCode} {res9.ProName} {res9.ProMrp}");
            }

            //10. Write a LINQ query to display count of total products.

            Console.WriteLine("display count of total products");
            var res10 = products.Count();
            Console.WriteLine($"{res10}");

            // 11. Write a LINQ query to display count of total products with category FMCG.
            Console.WriteLine("display count of total products with category FMCG");
            var res11 = products.Count(p => p.ProCategory == "FMCG");
            Console.WriteLine("FMCG Count: " + res11);

            //12.Write a LINQ query to display Max price.

            var res12 = products.Max(p => p.ProMrp);
            Console.WriteLine("Max Price: " + res12);

            //13.Write a LINQ query to display Min price.

            var res13 = products.Min(p => p.ProMrp);
            Console.WriteLine("Min Price: " + res13);

            //14. Write a LINQ query to display whether all products are below Mrp Rs.30 or not.

            var res14 = products.All(p => p.ProMrp < 30);

            Console.WriteLine("All below 30: " + res14);


        }
    }
}

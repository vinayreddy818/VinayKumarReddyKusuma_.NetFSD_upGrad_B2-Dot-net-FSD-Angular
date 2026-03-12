using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day4
{
    internal class ECommerceOrderCalculator
    {
        static void Main()
        {
            ECommerceOrderCalculator Ec = new ECommerceOrderCalculator();
            Console.WriteLine("Enter Product Price :");
            double productPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            double discountApplied;
            double subtotal;
            double finalAmount = Ec.CalculateFinalAmount(productPrice, quantity, out discountApplied, out subtotal);
            Console.WriteLine($"Sub Total : {subtotal}\nDiscount Applied : {discountApplied}\nFinal Amount : {finalAmount}");
        }
        public double CalculateFinalAmount(double productPrice, int quantity, out double discountApplied, out double subtotal, int discount = 0, int shippingCharge = 50)
            {
                subtotal = productPrice * quantity;
                discountApplied = subtotal * ((discount) / 100);
                double finalPrice = (subtotal - discountApplied) + shippingCharge;
                return finalPrice;
            }
    }
}

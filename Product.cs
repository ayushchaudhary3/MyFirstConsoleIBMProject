using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class Product
    {
        //data members
        private string productName;
        private double productPrice;
        private int productQuantity;

        //constructor
        public Product() // Default constructor
        {
        }
        // Parameterized constructor (overloaded constructor)
        public Product(string name, double price, int quantity)
        {
            productName = name;
            productPrice = price;
            productQuantity = quantity;
        }

        //properties
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public int ProductQuantity
        {
            get { return productQuantity; }
            set { productQuantity = value; }
        }
        //method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("------Product Details-------");
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Product Price: " + productPrice);
            Console.WriteLine("Product Quantity: " + productQuantity);
            Console.WriteLine("----------------------------");
        }
        //method to calculate total price
        public double CalculateTotalPrice()
        {
            return productPrice * productQuantity;
        }
        //method to apply discount
        public void AskAndApplyDiscount()
        {
            Console.WriteLine("Do you want to apply a discount? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Console.WriteLine("Enter discount percentage:");
                double discountPercentage = Convert.ToDouble(Console.ReadLine());
                if (discountPercentage > 0 && discountPercentage <= 100)
                {
                    double discountAmount = (discountPercentage / 100) * productPrice;
                    productPrice -= discountAmount;
                    Console.WriteLine($"Discount applied! New price: {productPrice}");
                }
                else
                {
                    Console.WriteLine("Invalid discount percentage.");
                }
            }
            else
            {
                Console.WriteLine("No discount applied.");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
        }
        //method to check stock availability
        public bool IsInStock()
        {
            return productQuantity > 0;
        }
        //method to restock product
        public void Restock(int additionalQuantity)
        {
            if (additionalQuantity > 0)
            {
                productQuantity += additionalQuantity;
                Console.WriteLine($"{additionalQuantity} units added to stock.");
                Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine("Invalid quantity for restocking.");
                Console.WriteLine("----------------------------");
            }
        }
        //method to sell product
        public void Sell(int quantitySold)
        {
            if (quantitySold > 0 && quantitySold <= productQuantity)
            {
                productQuantity -= quantitySold;
                Console.WriteLine($"{quantitySold} units sold.");
                Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine("Invalid quantity for sale. Check stock availability.");
                Console.WriteLine("----------------------------");
            }
        }
        //method to update product details
        public void UpdateProductDetails()
        {
            Console.Write("Enter new product name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter new product price: ");
            double newPrice;
            while (!double.TryParse(Console.ReadLine(), out newPrice) || newPrice <= 0)
            {
                Console.Write("Invalid price. Enter a valid positive number: ");
            }

            Console.Write("Enter new product quantity: ");
            int newQuantity;
            while (!int.TryParse(Console.ReadLine(), out newQuantity) || newQuantity < 0)
            {
                Console.Write("Invalid quantity. Enter a valid non-negative integer: ");
            }

            productName = newName;
            productPrice = newPrice;
            productQuantity = newQuantity;

            Console.WriteLine("Product details updated successfully.");
            Console.WriteLine("----------------------------");
        }
        // Interactive method menu for product operations
        public void InteractiveMethodMenu()
        {
            while (true)
            {
                Console.WriteLine("\n\n--- Product Method Menu ---");
                Console.WriteLine("1. Display Product Details");
                Console.WriteLine("2. Calculate Total Price");
                Console.WriteLine("3. Apply Discount");
                Console.WriteLine("4. Check Stock");
                Console.WriteLine("5. Restock Product");
                Console.WriteLine("6. Sell Product");
                Console.WriteLine("7. Update Product Details");
                Console.WriteLine("8. Exit");
                Console.Write("Choose a method to apply (1-8): ");
                string input = Console.ReadLine();
                Console.WriteLine("\n");
                int choice;
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        DisplayProductDetails();
                        break;
                    case 2:
                        double total = CalculateTotalPrice();
                        Console.WriteLine($"Total Price: {total}");
                        Console.WriteLine("----------------------------");
                        break;
                    case 3:
                        AskAndApplyDiscount();
                        break;
                    case 4:
                        Console.WriteLine(IsInStock() ? "Product is in stock." : "Product is out of stock.");
                        Console.WriteLine("----------------------------");
                        break;
                    case 5:
                        Console.Write("Enter quantity to restock: ");
                        int restockQty;
                        if (int.TryParse(Console.ReadLine(), out restockQty))
                            Restock(restockQty);
                        else
                            Console.WriteLine("Invalid quantity.");
                        break;
                    case 6:
                        Console.Write("Enter quantity to sell: ");
                        int sellQty;
                        if (int.TryParse(Console.ReadLine(), out sellQty))
                            Sell(sellQty);
                        else
                            Console.WriteLine("Invalid quantity.");
                        break;
                    case 7:
                        UpdateProductDetails();
                        break;
                    case 8:
                        Console.WriteLine("Exiting Product Method Menu.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}

namespace S12345678_PosApp
{
    class Program
    {
        static string DisplayMenuAndGetOption()
        {
            Console.WriteLine("\n---------------- M E N U -----------------");
            Console.WriteLine("[1] List all products and prices");
            Console.WriteLine("[2] Add item to cart");
            Console.WriteLine("[3] View cart items");
            Console.WriteLine("[4] Remove item from cart");
            Console.WriteLine("[5] Clear cart items");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter your option: ");

            string userOption = Console.ReadLine();
            return userOption;
        }

        static void ListProducts(Dictionary<string, Product> pDict)
        {
            Console.WriteLine($"\n{"Code", -4} {"Name", -15} {"Price", -7}");
            foreach (Product product in pDict.Values)
            {
                Console.WriteLine(product);
            }
        }

        static void AddItemToCart(Dictionary<string, Product> pDict, ShoppingCart cart)
        {
            ListProducts(pDict);

            Console.Write("\nEnter product code: ");
            string userItemCode = Console.ReadLine();

            Console.Write("Enter quantity: ");
            int userItemQuantity = Convert.ToInt32(Console.ReadLine());


            bool itemInCart = false;
            foreach (CartItem item in cart.ItemList)
            {
                if (userItemCode == item.Code)
                {
                    item.Qty += userItemQuantity;
                    itemInCart = true;
                    break;
                }
            }
            if (!itemInCart) cart.AddItem(new CartItem(userItemCode, pDict[userItemCode].Name, pDict[userItemCode].Price, userItemQuantity));
        }

        static void ViewCartItems(ShoppingCart cart)
        {
            Console.WriteLine($"\n{"Code", -4} {"Name", -15} {"Price", -7} {"Quantity", -8} {"Subtotal", -9}");
            double cartTotal = 0;

            foreach (CartItem item in cart.ItemList)
            {
                double itemSubtotal = item.Qty * item.Price;
                Console.WriteLine($"{item} {itemSubtotal, -9:F2}");
                cartTotal += itemSubtotal;
            }

            Console.WriteLine($"\nCart total: {cartTotal:C}");
        }

        static void RemoveCartItem(ShoppingCart cart)
        {
            ViewCartItems(cart);

            Console.Write("\nEnter item code to remove: ");
            int userItemCode = Convert.ToInt32(Console.ReadLine());

            bool canRemove = cart.RemoveItem(userItemCode);
            
            if (canRemove) Console.WriteLine("Item removed.");
            else Console.WriteLine("Invalid item code.");
        }

        static void ClearShoppingCart(ShoppingCart cart)
        {
            cart.ClearCart();
            Console.WriteLine("\nCart Cleared.");
        }

        static void Main()
        {
            Dictionary<string, Product> productDict = new Dictionary<string, Product>();

            productDict.Add("1001", new Product("1001", "Apple iPhone", 1088.00));
            productDict.Add("1005", new Product("1005", "HTC Sensation", 888.00));
            productDict.Add("1013", new Product("1013", "LG Optimus 2X", 788.00));
            productDict.Add("1022", new Product("1022", "Motorola Atrix", 958.00));
            productDict.Add("1027", new Product("1027", "Samsung Galaxy", 988.00));

            ShoppingCart cart1 = new ShoppingCart();

            while (true)
            {
                string userOption = DisplayMenuAndGetOption();

                if (userOption == "0")
                {
                    break;
                }

                switch (userOption)
                {
                    case "1":
                        ListProducts(productDict);
                        break;

                    case "2":
                        AddItemToCart(productDict, cart1);
                        break;

                    case "3":
                        ViewCartItems(cart1);
                        break;

                    case "4":
                        RemoveCartItem(cart1);
                        break;

                    case "5":
                        ClearShoppingCart(cart1);
                        break;
                }
            }
        }
    }
}

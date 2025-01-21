namespace Inventory_Management_System
{
    internal class Program
    {
        const int IncentoryCapavity = 50;
        static string[,] Inventory = new string[IncentoryCapavity, 3];
        static int  ProductCount =0;
        static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine("Welcome To Inventory System");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Please Enter Number Of Operation");
                Console.WriteLine("1.Add Proudct");
                Console.WriteLine("2.Update Proudct");
                Console.WriteLine("3.View Proudct");
                Console.WriteLine("4.Exit");

                int no_Of_Operation = int.Parse(Console.ReadLine());

                switch (no_Of_Operation)
                {
                    case 1:
                        //Add Product
                        AddProduct();
                        break;
                    case 2:
                        //Upate Product
                        UpdateProduct();
                        break;
                    case 3:
                        //View Products
                        viewProducts();
                        break;
                    case 4:
                        //Exit
                        Environment.Exit(0);
                        break;

                }
            }

        }
           

        
        static void AddProduct()
        {
            Console.WriteLine("Please Enter The name of The Product");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter The Quantity of The Product");
            string quantity = Console.ReadLine();

            Console.WriteLine("Please Enter The Price of The Product");
            string price = Console.ReadLine();


            Inventory[ProductCount, 0] = name;
            Inventory[ProductCount, 1] = quantity;
            Inventory[ProductCount, 2] = price;

            Console.WriteLine("Product is Added To Your Inventory");

            ProductCount++;


        }

        static void viewProducts()
        {
            if (ProductCount > 0) {

                for (int i = 0; i < ProductCount; i++)
                {
                    Console.WriteLine($"Product ID : {i} , Product name : {Inventory[i, 0]} , Product Quantity : {Inventory[i, 1]} , Product Price : {Inventory[i, 2]} ");
                }

            }
           
        }

        static void UpdateProduct()
        {
            Console.WriteLine("Please Enter The name Of product you want to update");
            string searchedname = Console.ReadLine();
            int searchindex = -1;

            if(ProductCount > 0)
            {
                for(int i = 0;i < ProductCount;i++)
                {
                    if (searchedname == Inventory[i, 0])
                        searchindex = i;
                    break;

                }

                if(searchindex != -1)
                {
                    Console.WriteLine("Enter new Quantity");
                    string newQuantity = Console.ReadLine();

                    
                    Inventory[searchindex, 1] = newQuantity;
                    


                }



            }
            else
            {
                Console.WriteLine("No Products in Your Inventory");
            }


        }




    }
}

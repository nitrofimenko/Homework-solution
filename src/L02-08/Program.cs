using L02_08;

void ShowAllProducts(Product[] products, int productsNumber)
{
    Console.WriteLine("Number Name                Price");
    for (int i = 0; i < productsNumber; i++)
    {
        Console.WriteLine($"{i,-7}{products[i].Name,-20}{products[i].Price}");
    }
}

const int LIMIT = 100;
ProductFactory productFabric = new ProductFactory();
Product[] products = new Product[LIMIT];
Invoice[] invoice = new Invoice[1];
int productsNumber = 0;
bool invoiceAvailable = false;
do
{
    Console.WriteLine($"Number of products available: {productsNumber}");
    Console.WriteLine(productsNumber < LIMIT ? "1 - add new product." : "Can't add new product. Limit is reached.");
    if (productsNumber > 0)
    {
        Console.WriteLine("2 - show information about all available products.");
        Console.WriteLine(invoiceAvailable ? "3 - show invoice" : "3 - choose product to buy (one product to one invoice).");
    }
    Console.WriteLine("e - exit");
    Console.Write("Make your choice: ");

    var choice = Console.ReadLine();
    Console.WriteLine();
    if (choice == "1" && productsNumber < LIMIT)
    {
        products[productsNumber] = productFabric.CreateProduct();
        Console.WriteLine("Ok");
        Console.WriteLine();
        productsNumber++;
    }
    else if (choice == "2" && productsNumber > 0)
    {
        ShowAllProducts(products, productsNumber);
        Console.WriteLine();
    }
    else if (choice == "3" && productsNumber > 0)
    {
        if (invoiceAvailable)
        {
            invoice[0].Show();
            Console.WriteLine();
        }
        else
        {
            int productNumber = -1;
            do
            {
                Console.Write("Input number of product which you want to order or \"s\" to show products list: ");
                var answer = Console.ReadLine();
                if (answer == "s")
                {
                    ShowAllProducts(products, productsNumber);
                    Console.WriteLine();
                }
                else if (int.TryParse(answer, out productNumber) && productNumber >= 0 && productNumber < productsNumber)
                {
                    break;
                }
            } while (true);
            int quantity = 0;
            do
            {
                Console.Write($"How many {products[productNumber].Name} you want? : ");
            } while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0);
            Console.Write("Input customer (name): ");
            string customer = Console.ReadLine();
            invoice[0] = new Invoice(1, customer, products[productNumber].Provider, products[productNumber].Name, quantity, products[productNumber].Price);
            Console.WriteLine("Invoice #1 create Ok");
            Console.WriteLine();
            invoiceAvailable = true;
        }
    }
    else if (choice == "e")
    {
        break;
    }
} while (true);
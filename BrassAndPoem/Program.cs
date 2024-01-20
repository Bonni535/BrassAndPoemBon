
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trombone",
        Price = 800M,
        ProductTypeId = 1,

    },
     new Product()
    {
        Name = "Tuba",
        Price = 300M,
        ProductTypeId = 1,

    },
      new Product()
    {
        Name = "Sousaphone",
        Price = 500M,
        ProductTypeId = 1,

    },
       new Product()
    {
        Name = "The Good Life",
        Price = 130M,
        ProductTypeId = 2,

    },
       new Product()
    {
        Name = "Did I Miss Anything?",
        Price = 60M,
        ProductTypeId = 2,

    },
        new Product()
    {
        Name = "Bad Day",
        Price = 46M,
        ProductTypeId = 2,

    }

};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

List<ProductType> productTyoes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1,
    },
    new ProductType()
    {
        Title = "Poem",
        Id = 2,
    },
};
//put your greeting here

Console.WriteLine("Welcome to the BrassAndPoem Shop!");

//implement your loop here
string choice = null;
while (choice != "5")
{
    DisplayMenu();
    choice = Console.ReadLine();
    if (choice == "1")
    {
        DisplayAllProducts(products, productTyoes);
    }
    else if (choice == "2")
    {
        DeleteProduct(products, productTyoes);  
    }
    else if (choice == "3")
    {
       AddProduct(products, productTyoes);
    }
    else if (choice == "4")
    {
        UpdateProduct(products, productTyoes);
    }
    else if (choice == "5")
    {
        Console.WriteLine("Goodbye and Thanks for shopping with us!");
    }
}
void DisplayMenu()
{
    Console.WriteLine(@"Menu:
1. Display all Products
2. Delete a Product
3. Add a Product
4. Update a Product
5. Exit
");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i=0; i < products.Count; i++)
    {
        Product product = products[i];
        ProductType productType = productTypes.FirstOrDefault(pt => pt.Id == product.ProductTypeId);
        Console.WriteLine($"{i + 1}. {product.Name}, Product type {productType.Id}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    int response = int.Parse(Console.ReadLine().Trim());
    if (response >= 1 && response <= products.Count)
    {
        products.RemoveAt(response - 1);
        Console.WriteLine("Product Deleted!");
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter Product Name: ");
    string Name = Console.ReadLine();
    Console.WriteLine("Enter Product Price: ");
    decimal Price = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Enter Product type: 1. Brass, 2. Poem");
    int Id = int.Parse(Console.ReadLine());

    Product newProduct = new Product
    {
        Name = Name,
        Price = Price,
        ProductTypeId = Id
    };
    products.Add(newProduct);
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.WriteLine("Would you like to update this Product?");
    
    int userChoice = int.Parse(Console.ReadLine().Trim());
    int productToUpdate = userChoice - 1;

    Product selectedProduct = products[productToUpdate];
    Console.WriteLine($"You chose {selectedProduct.Name}. Its price is {selectedProduct.Price} and its type is {selectedProduct.ProductTypeId}");
    Console.WriteLine("Insert New Name");
    string response1 = Console.ReadLine();
    Console.WriteLine("Insert New Price");
    string response2 = Console.ReadLine();
    Console.WriteLine("Insert New Type");
    string response3 = Console.ReadLine();

    if (!string.IsNullOrEmpty(response1))
    {
        selectedProduct.Name = response1;
    }
    else
    {
        selectedProduct.Name = selectedProduct.Name;
    }
    if (!string.IsNullOrEmpty(response2)) 
    {
        selectedProduct.Price = decimal.Parse(response2);
    }
    else
    {
        selectedProduct.Price = selectedProduct.Price;
    }
    if (!string.IsNullOrEmpty (response3))
    {
        int productId = int.Parse(response3);
        selectedProduct.ProductTypeId = productId;

    }
    else
    {
        selectedProduct.ProductTypeId = selectedProduct.ProductTypeId;
    }
    Product updatedProduct = new Product
    {
        Name = selectedProduct.Name,
        Price = selectedProduct.Price,
        ProductTypeId = selectedProduct.ProductTypeId,
    };
    selectedProduct = updatedProduct;

    Console.WriteLine("You update the Product!");
}

// don't move or change this!
public partial class Program { }
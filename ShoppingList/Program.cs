Dictionary<string, decimal> fruitStandList = new Dictionary<string, decimal>()
{
    
    {"Papaya", 3.75m }, 
    {"Mango" , 4.15m},
    {"Watermelon", 5.50m},
    {"Dragonfruit", 3.75m},
    {"Apple", 3.00m},
    {"Pear", 3.00m},
    {"Bananas", 3.00m},
    {"Orange", 3.00m}
};
List<string> customersCart = new List<string>();

Console.WriteLine("Hello! welcome to Rizzo's Fruit Stand! Our menu is as follows:");
Console.WriteLine("======================================");

foreach (string item in fruitStandList.Keys)
{
    Console.WriteLine($" {item}  Price: {fruitStandList[item]:c} ");
}

bool keepOrdering = true;

while (keepOrdering == true)
{
    Console.WriteLine("What would you like to order? (Note: case sensitive)");
    string userOrder = Console.ReadLine();
    if (fruitStandList.ContainsKey(userOrder))
    {
        Console.WriteLine($"Let me add that {userOrder} to your cart! thats gonna cost {fruitStandList[userOrder]}");
        customersCart.Add(userOrder);
    }
    else
    {
        Console.WriteLine("Please enter a menu item (Note: entry is case sensitive)");
        continue;
    }
    Console.WriteLine("Would you like to choose another fruit? enter y or yes to continue, any other key will close your tab out and give you your total");
    string userChooseAgain = Console.ReadLine().ToLower();
    
    switch (userChooseAgain)
    {
        case "y":
        case "yes":
        case "Yes":
        case "Y":
            continue;
        default:
            decimal totalSum = 0;
            int timesLooped = 0;
            Console.WriteLine("Thanks for your order!");
            Console.WriteLine("Your order is as follows");
            foreach (string item in customersCart)
            {
                Console.WriteLine($"{item}  {fruitStandList[item]}");
                timesLooped++;
                if (timesLooped > 1)
                {
                    totalSum = fruitStandList[item] + fruitStandList[item];
                }
                else
                {
                    totalSum = fruitStandList[item];
                }
            }
            Console.WriteLine($"The total cost of your order is {totalSum}");
            customersCart.Clear();
            keepOrdering = false;
            break;
           
    }


}
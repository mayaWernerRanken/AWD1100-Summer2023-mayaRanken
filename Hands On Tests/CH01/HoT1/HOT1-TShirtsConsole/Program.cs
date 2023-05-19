//All variables
string userName;
string userAddress;
string userCity;
string userState;
int userZip;
int shirtNum = 0;
const decimal shirtPrice = 14.99M;
decimal subTotal = 0.00M;
const float salesTax = 1.08f;
float grandTotal;

//Name
Console.Write("Please enter your name: ");
userName = Convert.ToString(Console.ReadLine());

//Address
Console.Write("Please enter your address: ");
userAddress = Convert.ToString(Console.ReadLine());

//City and state
Console.Write("Please enter your city: ");
userCity = Convert.ToString(Console.ReadLine());
Console.Write("Please enter your state: ");
userState = Convert.ToString(Console.ReadLine());

//Zip code
Console.Write("Please enter your zip code: ");
userZip = Convert.ToInt32(Console.ReadLine());

//Number of shirts ordered
Console.Write("Please enter the number of shirts you want to order: ");
shirtNum = shirtNum + Convert.ToInt32(Console.ReadLine());

//Subtotal
subTotal = shirtPrice * shirtNum;

//Grand total
grandTotal = Convert.ToSingle(subTotal) * salesTax;

//Receipt
Console.Write("\nReceipt for: \n");
Console.Write($"{userName}\n" +
$"{userAddress}\n" +
$"{userCity}," + $" {userState}" + $" {userZip}");
Console.WriteLine($"{shirtNum} T-shirts ordered @ $14.99 each\n");

Console.WriteLine($"Subtotal:       {subTotal:c}\n" +
                  $"Tax:            {subTotal * 0.08M:c}\n" +
                  $"---------------------------\n" +
                  $"Total:          {grandTotal:c}");

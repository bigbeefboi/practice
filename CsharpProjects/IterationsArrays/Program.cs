//string[] fraudulentOrderIDs = new string[3];
//array is a collection of a data type
//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

//string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

/*Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");*/
/*foreach (string id in fraudulentOrderIDs)
{
    Console.WriteLine(id);
}

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
Console.WriteLine();*/

/*int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");*/

/*
string[] fraudIDS = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string id in fraudIDS)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
    
}*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

/*
//this code
// convert the message into a char array
// Reverse the chars
// count the o's
// convert it back to a string
// print it out
*/

string message = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = message.ToCharArray();

Array.Reverse(charMessage);
int letterCount = 0;

foreach (char letter in charMessage) 
{ 
    if(letter == 'o') 
    { 
        letterCount++; 
    } 
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
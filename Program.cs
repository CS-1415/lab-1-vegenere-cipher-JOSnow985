Console.Clear();
Console.WriteLine("Let's encrypt a message using the Vigenere method!");
Console.WriteLine("Please give us a message to encrypt:");
string userMessage = Console.ReadLine();
Console.WriteLine("Please enter the encryption key you want to use:");
string userKey = Console.ReadLine();
Console.WriteLine($"Your message: {userMessage}");
Console.WriteLine($"Your encryption key: {userKey}");

// Checks the given character and returns true if lowercase, false otherwise
static bool IsLowercaseLetter(char c)
{
    return false;
}
using System.Diagnostics;

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

// Tests for the Lowercase method
static void TestIsLowercaseLetter()
{
    Debug.Assert(IsLowercaseLetter('a'));
    Debug.Assert(IsLowercaseLetter('b'));
    Debug.Assert(IsLowercaseLetter('z'));
    Debug.Assert(!IsLowercaseLetter('A'));
    Debug.Assert(!IsLowercaseLetter('`'));
    Debug.Assert(!IsLowercaseLetter('{'));
}
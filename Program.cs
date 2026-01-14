using System.Diagnostics;
TestIsLowercaseLetter();

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
    if (c >= 'a' && c <= 'z')
    {
        return true;
    }
    else
        return false;
}

// Checks passed string to make sure it only contains lowercase letters
static bool IsValidInput(string str)
{
    return false;
}

// Tests for the Lowercase method
static void TestIsLowercaseLetter()
{
    // True
    Debug.Assert(IsLowercaseLetter('a'));
    Debug.Assert(IsLowercaseLetter('b'));
    Debug.Assert(IsLowercaseLetter('z'));
    // False
    Debug.Assert(!IsLowercaseLetter('A'));
    Debug.Assert(!IsLowercaseLetter('`'));
    Debug.Assert(!IsLowercaseLetter('{'));
}

// Tests for IsValidInput method
static void TestIsValidInput()
{
    // True
    Debug.Assert(IsValidInput("apple"));
    Debug.Assert(IsValidInput("spaceship"));
    Debug.Assert(IsValidInput("apple"));
    // False
    Debug.Assert(!IsValidInput("FaCtOR"));
    Debug.Assert(!IsValidInput("5U1*3R"));
    Debug.Assert(!IsValidInput(" apple"));
}
using System.Diagnostics;
TestIsLowercaseLetter();
TestIsValidInput();

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

// Checks each character in the passed string using IsLowercaseLetter, returns false if any fail, otherwise true
static bool IsValidInput(string str)
{
    foreach (char c in str)
    {
        if (IsLowercaseLetter(c) == false)
            return false;
    }
    return true;
}

// Shifts a passed message character using a passed key character, returning the resulting character
static char ShiftLetter(char cMsg, char cKey)
{
    return 'a';
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

// Tests for ShiftLetter method
static void TestShiftLetter()
{
    // True
    Debug.Assert(ShiftLetter('g','a') == 'g');
    Debug.Assert(ShiftLetter('x','f') == 'c');
    Debug.Assert(ShiftLetter('t','u') == 'n');
    // False
    Debug.Assert(ShiftLetter('a','a') != 'b');
    Debug.Assert(ShiftLetter('a','l') != 'k');
    Debug.Assert(ShiftLetter('j','k') != 's');
}
using System.Diagnostics;
// Tests
TestIsLowercaseLetter();
TestIsValidInput();
TestShiftLetter();

// Main Driver(?)
Console.Clear();
Console.WriteLine("Let's encrypt a message using the Vigenere method!");
Console.WriteLine("Please give us a message to encrypt:");
string userMessage = Console.ReadLine();
Console.WriteLine("Please enter the encryption key you want to use:");
string userKey = Console.ReadLine();
Console.WriteLine($"Your message: {userMessage}");
Console.WriteLine($"Your encryption key: {userKey}");

// Methods
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
static char ShiftLetter(char charInput, char charKey)
{
    // Offset by -97 to line up the key to 0-25, zero indexed lower case alphabet
    int intShifted = charInput + charKey - 97;
    // If the character value exceeds z, we want to wrap back to 97, 'a', 26 letters so subtract 26.
    if (intShifted > 122)
        return (char)(intShifted - 26); 
    else
        return (char)intShifted;
}

// Takes two strings and shifts the first string letter by letter using the second string
static string ShiftMessage(string strInput, string strKey)
{
    string strShifted = "placeholder";
    return strShifted;
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

static void TestShiftMessage()
{
    // True
    Debug.Assert(ShiftMessage("endzz", "b") == "foeaa");
    Debug.Assert(ShiftMessage("apple", "bcb") == "brqmg");
    Debug.Assert(ShiftMessage("zero", "o") == "bqqmf");
}
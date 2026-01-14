using System.Diagnostics;
using System.Text;
// Tests
TestIsLowercaseLetter();
TestIsValidInput();
TestShiftLetter();
TestShiftMessage();

// Main Driver(?)
Console.Clear();
Console.WriteLine("Let's encrypt a message using the Vigenere method!");

// Collect a valid user input to shift before continuing
bool inputValidated = false;
string userMessage = "";
while (inputValidated == false)
{
    Console.WriteLine("Please give us a message to encrypt:");
    userMessage = Console.ReadLine();
    if (string.IsNullOrEmpty(userMessage) == false)
        inputValidated = IsValidInput(userMessage);
    if (inputValidated == false)
        Console.WriteLine("Sorry, we can only use lower-case letters!");
}

// Same as above but for the key this time
inputValidated = false;
string userKey = "";
while (inputValidated == false)
{
    Console.WriteLine("Please enter the encryption key you want to use:");
    userKey = Console.ReadLine();
    if (string.IsNullOrEmpty(userKey) == false)
        inputValidated = IsValidInput(userKey);
    if (inputValidated == false)
        Console.WriteLine("Sorry, we can only use lower-case letters!");
}

// Run user inputs through the ShiftMessage method and display it
string shiftedMessage = ShiftMessage(userMessage, userKey);
Console.WriteLine($"Here is your encrypted message: {shiftedMessage}");

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
    var shiftedBuilder = new StringBuilder();
    for (int i = 0; i < strInput.Length;)
    {
        foreach (char letter in strKey)
        {
            if (i < strInput.Length)
            {
                shiftedBuilder.Append(ShiftLetter(strInput[i], letter));
            }
            i++;
        }
    }
    return shiftedBuilder.ToString();
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
    Debug.Assert(IsValidInput("structure"));
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
    Debug.Assert(ShiftMessage("spaceship", "wombat") == "odmdeldwb");
    Debug.Assert(ShiftMessage("zelda", "macncheese") == "lenqc");
}
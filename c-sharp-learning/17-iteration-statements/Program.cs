// PROJECT 1
/* 
- Your solution must use a Console.ReadLine() statement to obtain input from the user.
- Your solution must ensure that the input is a valid representation of an integer.
- If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
- Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration. */

/* 
string? readResult;
bool validNumber = false;
int numValue = 0;

Console.WriteLine("Enter an integer value between 5 and 10");

do {
    readResult = Console.ReadLine();
    if (readResult != null) {
        validNumber = int.TryParse(readResult, out numValue);

        if (validNumber == true) {
            if (numValue < 5 || numValue > 10) {
                validNumber = false;
                Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
            }
        } else {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    } 

} while (validNumber == false);
Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine(); 
*/

// PROJECT 2
/* 
- Your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.
- Inside the iteration block:
    - Your solution must use a Console.ReadLine() statement to obtain input from the user.
    - Your solution must ensure that the value entered matches one of the three role options.
    - Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
    - Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry. */

/* string? readResult;
bool validInput = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do {
    readResult = Console.ReadLine();
    if (readResult != null) {
        if ((readResult.Trim().ToLower() == "administrator") ||
            (readResult.Trim().ToLower() == "manager") ||
            (readResult.Trim().ToLower() == "user") ){
                validInput = true;
            }
        else {
            Console.WriteLine($"The role name that you entered, {readResult} is not valid. Enter your role name (Administrator, Manager, or User) Administrator");
        }
    }
} while (validInput == false);
Console.WriteLine($"Your input value {readResult} has been accepted."); */

// PROJECT 3
/* 
- Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
- Your solution must include an outer foreach or for loop that can be used to process each string element in the array. 
  The string variable that you'll process inside the loops should be named myString.
- In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. 
  The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
- Your solution must include an inner do-while or while loop that can be used to process the myString variable.
- In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
- In the inner loop, your solution must not display the period character.
- In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information. */

// copy, didn't make it...
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++) {
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1) {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
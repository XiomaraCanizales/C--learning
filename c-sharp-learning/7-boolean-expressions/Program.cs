Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
Console.WriteLine();

// using string's built-in helper methods
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
Console.WriteLine();

// comparison operators
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
Console.WriteLine();

// method that returns a Boolean
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine();

// using logical negation operator
string pangram2 = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram2.Contains("fox"));
Console.WriteLine(!pangram2.Contains("cow"));
Console.WriteLine();

// inequality operator versus logical negation
// The inequality operator returns true if its operands aren't equal, and returns false if the operands are equal.
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
Console.WriteLine();

// conditional operator
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}
Console.WriteLine();

// using break
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
    if (i == 7) break;
}
Console.WriteLine();

// looping through each element of an array
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--) {
    Console.WriteLine(names[i]);
}
Console.WriteLine();

// overcoming the limitation of the foreach statement using the for statement
string[] names2 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names2.Length; i++)
    if (names2[i] == "David") names2[i] = "Sammy";

foreach (var name in names2) Console.WriteLine(name);
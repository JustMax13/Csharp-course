// ??= позволяет писать намм не так
//string str = null;
//string result = str ?? "Defolt string";
//Console.WriteLine("Number of characrers in a line " + result.Length);
// а так:
string str = null;
str ??= string.Empty;
Console.WriteLine("Number of characrers in a line: " + str.Length);
//Индексы и диапазоны в массивах

int[] myaaray1 = { 2, 4, 6, 543, 76, 45, 86 };
int[] myarray2 = myaaray1[3..];

Console.WriteLine();

//Индексы и диапазоны в строках

string str = "Hi Max! =)";

Console.WriteLine(str[..2] + " " + str[^2..]);
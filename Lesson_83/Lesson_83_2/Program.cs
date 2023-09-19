using System.Collections;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>(); // создать лист
        list.Add(1);//добавить елемент с значением 1
        list.Remove(1); // удаляем по значению

        ArrayList arrayList = new ArrayList(); // содержит в себе тип данных object, тоесть можем делать так:
        arrayList.Add(8);
        arrayList.Add("Lol"); // но минус тут в том, что тут идет запаковка и распаковка :(
    }
}
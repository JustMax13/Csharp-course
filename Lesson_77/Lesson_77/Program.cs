/*
 интерфейс и полиморфизм
 */
interface IDataProvider
{
    string GetData();
}
interface IDataProcessor
{
    void ProcessData(IDataProvider dataProvider);
}
class DBDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные пришли с БД";
    }
}
class FileDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные пришли с файла";
    }
}
class APIDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные пришли с API";
    }
}

class ConsoleDataProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider)
    {
        Console.WriteLine(dataProvider.GetData());
    }
}

class Program
{
    static void Main()
    {
        IDataProcessor dataProcessor = new ConsoleDataProcessor();
        dataProcessor.ProcessData(new APIDataProvider());
        dataProcessor.ProcessData(new DBDataProvider());
        dataProcessor.ProcessData(new FileDataProvider());
    }
}
namespace DirectoryFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo NicksDir = new DirectoryInfo(@"C:\Пользователи\Pukich");

            Console.WriteLine(NicksDir.FullName);
            Console.WriteLine(NicksDir.Name);
            Console.WriteLine(NicksDir.Parent);
            Console.WriteLine(NicksDir.Attributes);
            Console.WriteLine(NicksDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Пользователи\Pukich\C#Data");
            dataDir.Create();
        }
    }
}

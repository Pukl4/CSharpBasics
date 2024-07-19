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
            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };
            string textFilePath = @"C:\Пользователи\Pukich\C#Data\testfile1.txt";
            File.WriteAllLines(textFilePath, customers);

            foreach (string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust}");   
            }

            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Пользователи\Pukich\C#Data");
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Matches :{0}", txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }
        }
    }
}

namespace StrWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath3 = @"C:\Пользователи\Pukich\C#Data\testfile3.txt";
            StreamWriter sw = new StreamWriter(textFilePath3);
            sw.Write("Random");
            sw.WriteLine(" sentence.");
            sw.WriteLine("Another random sentence");
            sw.Close();

            StreamReader sr = new StreamReader(textFilePath3);
            Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));
            Console.WriteLine("1st string : {0}", sr.ReadLine());
            Console.WriteLine("Everything Else : {0}", sr.ReadToEnd());
            sr.Close();
        }
    }
}

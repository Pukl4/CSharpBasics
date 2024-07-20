namespace BinarWriter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string textFilePath4 = @"C:\Пользователи\Pukich\C#Data\testfile4.txt";
            FileInfo datFile = new FileInfo(textFilePath4);
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());
            string randText = "Random Text";
            int myAge = 23;
            double height = 6.25;
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);
            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();


        }
    }
}

using System.Text;

namespace FileStreams
{
    public class Program
    {
        static void Main(string[] args)
        {
            string textFilePath2 = @"C:\Пользователи\Pukich\C#Data\testfile2.txt";
            FileStream fs = File.Open(textFilePath2, FileMode.Create);
            string randString = "Random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];

            for (int i = 0; i < fileByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();
        }
    }
}

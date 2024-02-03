using System.Globalization;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // ternary oprator
        //  condition?true:false
        // ? :
        //int? a = -2 > 1 ? 3 :null;
        //bool isTrue = 2==1 ? true : false;
        //Console.WriteLine(isTrue);

        // break and continue in loop

        //for (int i = 0; i <= 7; i++)
        //{
        //    if (i == 4)
        //        continue; // it steps this proccess

        //    Console.WriteLine($"i : {i}");




        //}


        // data types

        #region numeric
        // numeric data types 
        //sbyte byt2 = 127;
        //byte byt = 14; // 256 simvol

        ////1111 1111 1111 1111 1111 1111 1111 1111



        //short shrt = 15;
        //ushort shrt2 = 16;

        //int _int = 17;
        //uint _uint = 18;

        //long _long = 19;
        //ulong _ulong = 20;

        //// numeric floating point 
        //decimal ss = 12.3m;
        //double dbl = 12.4; // default
        //float slt = 12.5f;
        #endregion

        #region non numeric
        //bool bl = false; // default
        //char ch = 'a';
        //string str = "salam";
        #endregion


        // value and reference types


        // file read and write

        #region writing to files        
        //string path = "C:\\Users\\Admino\\OneDrive\\Desktop";
        //string fileName = "Yeni Metin Belgesi.txt";
        //string fullPath = Path.Combine(path, fileName);

        //with StreamWriter
        //using (StreamWriter str = new StreamWriter(fullPath))
        //{
        //    str.Write("Hello");  // overwrite
        //}

        //with FileInfo
        //FileInfo fileInfo = new FileInfo(fullPath);
        //using (StreamWriter str = fileInfo.AppendText())
        //{
        //    str.WriteLine("Hello");
        //}
        #endregion

        #region reading from files
        //string path = "C:\\Users\\Admino\\OneDrive\\Desktop";
        //string fileName = "Yeni Metin Belgesi.txt";
        //string fullPath = Path.Combine(path, fileName);

        ////with StreamReader
        //using (StreamReader str = new StreamReader(fullPath))
        //{
        //    Console.WriteLine(str.ReadLine());
        //}

        ////with FileInfo
        //FileInfo fileInfo = new FileInfo(fullPath);
        //using (StreamReader srt = fileInfo.OpenText())
        //{
        //    Console.WriteLine(srt.ReadToEnd());
        //}
        #endregion



        // working with string and char

        #region useful char functions
        //bool isTrue = char.IsDigit('*');
        //Console.WriteLine(isTrue);

        //bool isTrue = char.IsLetter('a');
        //Console.WriteLine(isTrue);

        //bool isTrue = char.IsPunctuation('a');
        //Console.WriteLine(isTrue);

        //bool isTrue = char.IsUpper('A');
        //Console.WriteLine(isTrue);

        //bool isTrue = char.IsLower('a');
        //Console.WriteLine(isTrue);

        //bool isTrue = char.IsWhiteSpace(' ');
        //Console.WriteLine(isTrue);
        #endregion

        #region string functions
        //string str="";



        //int length = str.Length;
        //Console.WriteLine(length);

        //str = str.ToUpper();
        //Console.WriteLine(str);

        //str = str.ToLower();
        //Console.WriteLine(str);

        //string str1 = "Hello";
        //string str2 = "World";
        //string joinedString = string.Concat(str1, str2);
        //Console.WriteLine(joinedString);

        //bool ifContains = str.Contains(" ");
        //Console.WriteLine(ifContains);

        //bool isTrue = string.IsNullOrEmpty(str);
        //Console.WriteLine(isTrue);
        #endregion

        #region speacial points in string
        //string str = "Salam"; // 
        //string str1 = "Hello ";

        //str1 += "World";
        //Console.WriteLine(str1);
        // Hello 
        // Hello World
        // Hello World we learn c#

        // string intern

        //object str = new string("We learn C# programming");
        //object str1 = new string("We learn C# programming");



        //bool b = (str == str1); // ==  value, adress 
        //bool c = str.Equals(str1); // value 
        //Console.ReadKey();

        //17 10
        #endregion

        #region why we need stringbuilder
        StringBuilder myFirstStringBuilder = new StringBuilder("Staring");

        //myFirstStringBuilder.Append(" World!");
        //Console.WriteLine(myFirstStringBuilder.ToString());
        // Staring World!

        //myFirstStringBuilder.Clear();
        //Console.WriteLine(myFirstStringBuilder.ToString());

        //myFirstStringBuilder.Remove(2, 2);
        //Console.WriteLine(myFirstStringBuilder.ToString());

        //myFirstStringBuilder.Insert(4, "tyty");
        //Console.WriteLine(myFirstStringBuilder.ToString());


        //myFirstStringBuilder.Replace("Star", "Go");
        //Console.WriteLine(myFirstStringBuilder.ToString());
        #endregion


        // string is only reference type that is immutable 

        

        // StringBuilder mutable because it is reference


    }
}
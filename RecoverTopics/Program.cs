using System.Text;
using MathClass;
internal class Program
{
    private static void Main(string[] args)
    {
        //double c = MathClassExample.Multiply(2, 3);
        //Console.WriteLine(c);

        Func();
    }

    static void Func()
    {
        int a = 2; // value type or primitve type // immutable

        int b = 2; //value type or primitve type // immutable

        a = b;

        b = 3;

        //Console.WriteLine(a);
        //Console.WriteLine(b);

        StringBuilder sb = new StringBuilder("object 1"); // reference type // mutable
        StringBuilder sb1 = new StringBuilder("object 2"); // reference type // mutable
        Console.WriteLine(sb.ToString());
        Console.WriteLine(sb1.ToString());

        sb = sb1;

        //sb1.Append(" new");
        Console.WriteLine(sb.ToString());
        Console.WriteLine(sb1.ToString());

    }
}
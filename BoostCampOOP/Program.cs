using BoostCampOOP;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // OOP - part 1

        // 1
        // access modifiers
        // default access modifier of class members => private
        // deafult access modifiers of class => internal
        // fields of class
        // Object initialization
        #region class
        // Person => name, surname, age
        // Book => author, pagecount, price

        //Person person = new Person() { name = "Test1", surname="Test2"}; // Object initialization

        #endregion


        // 2
        // why properties
        // access modifiers for get and set
        // required and nullable
        // how to disable nullable in csproj
        #region property

        //Person person = new Person() { surname="a"} ;

        //person.Name = "Test";
        //string s = person.Name;
        //Console.WriteLine(/*person.*/);


        #endregion

        // 3
        // why methods | DRY (Don't repeat yourself)
        // default access modifier of method
        // method signature
        // return type of method and parameter list
        // return reference type
        // call method inside same class
        // why params keyword
        // params with different parameter
        // named and optional parameters
        #region method

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("test");
        //    Console.WriteLine( i ); 
        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("test");
        //    Console.WriteLine(i);
        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("test");
        //    Console.WriteLine(i);
        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("test");
        //    Console.WriteLine(i);
        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("test");
        //    Console.WriteLine(i);
        //}
        //Person person = new Person();
        //double a  = person.Sum("+", b:3); // named and optional
        //Console.WriteLine(a);   
        //person.name= "Test";
        //int a = 1;
        //person.SetDataToPerson("TestAd", "TestSOyad");
        ////person.ShowPerson();
        //Console.WriteLine(person.name + " " + a);
        //changge(person, a);
        //void changge(Person person, int a)
        //{
        //    person.name = "Test123";
        //    a = 2;
        //}
        //Console.WriteLine(person.name + " " + a);

        //Person person2 = new Person();
        //person2.name= "Example";
        //person2.SetDataToPerson("ExampleAd", "ExampleSoyad");
        //person2.ShowPerson();
        //person.PrintSomethin();
        //person.PrintSomethin();
        //person.PrintSomethin();
        //person.PrintSomethin();
        //person.PrintSomethin();

        //var sum = person.Sum();
        //Console.WriteLine(sum);

        //TestClass testClass = new TestClass();
        //Person prs = testClass.SetDataToPerson("TestName1", "TestSurname2");
        //testClass.ShowPerson(prs);



        #endregion

        // 4
        // Constructors | Default Constructor
        // Parameterized Constructor        
        #region constructor



        #endregion

        // 5 
        // use case of static keyword
        #region static class and constructor

        //Person person = new Person();
        //person.surname = "Test";
        //Console.WriteLine(person.surname + " " + Person.name);
        //Person person2 = new Person();
        //person2.surname = "Test1";
        //Console.WriteLine(person2.surname + " " + Person.name);
        //Person person3 = new Person();
        //person3.surname = "Test3";
        //Console.WriteLine(person3.surname + " " + Person.name);




        #endregion

        // 6
        // const and readonly keywords
        #region const and readonly

        //const int num1 = 4; // you should initialize its value when declaring
        //Console.WriteLine(num1);    

        //Person person = new Person("Name", "Surname", 29);

        //Console.WriteLine(person.name);
        //person = new Person("Turqut", "Mehdiyev", 21);
        //Console.WriteLine(person.name);
        #endregion

        // 7
        // why extension methods
        #region extension methods
        //string str = "Hello World";
        //Console.WriteLine(str.IsLowerThanFour());
        //int num = 4;
        //Console.WriteLine(StringFeature.IsHigherThanThis(num, 7)); 
        #endregion

        // 8
        // records 
        // diffrence between record and class
        // positional properties
        #region records
        //Car car = new Car("TestAd", "TestSoyad");

        //Car car = new Car(); 
        //car.Name = "Test1";  
        //car.Description = "Fast";   
        //Car car2 = new Car();
        //car2.Name = "Test";
        //car2.Description = "Fast";
        //Console.WriteLine(car == car2);

        //Person person = new Person("Name");
        //Person person1 = new Person("Name");
        //Console.WriteLine(person==person1);
        #endregion

        // 9 
        // why enums
        // integral values of enum
        #region enums
        //Person person = new Person("Turqut", "Mehdiyev", Role.Middle);
        //Person person1 = new Person("Zakir", "Gözəlov", Role.Junior);

        //if (person.Role == Role.Middle)
        //    TestClass.Advanced();            


        //if (person1.Role == Role.Junior)
        //    TestClass.Intermediate();
        #endregion
        //string.Ca
        //StringBuilder stringBuilder = new StringBuilder();  

    }
}
//public record Car (string Name, string Descriotion);

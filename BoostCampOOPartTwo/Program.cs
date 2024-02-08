
using BoostCampOOPartTwo;

internal class Program
{
    private static void Main(string[] args)
    {
        // OOP part 2

        #region encapsulation

        #endregion

        // protected keyword
        // hierarchy of constructors
        // base keyword 
        // multi inheritance
        #region inheritance
        // name, surname, age
        // Developer ProgLang 
        // Doctor Cetrificate
        // Teacher Subject

        //Doctor doctor = new Doctor(){Name="name1", Surname="surname1", Age=29, Cetrificate="Doctor certificate" }; 
        //Developer developer = new Developer() {Name="name2", Surname="surname2", Age=30, ProgLang="C#" };
        //Teacher teacher = new Teacher() {Name="name3", Surname="surname3", Age=33, Subject="Chemistry" };

        //string doctorInfo = doctor.GetInfo();
        //Console.WriteLine(doctorInfo);

        //developer.GetInfo();
        //developer.PrintName();



        #endregion

        #region sealed keyword

        #endregion

        // abstract class
        // abstract method
        // constructors
        #region abstraction

        //Doctor doctor = new Doctor() { Name = "name1", Surname = "surname1", Age = 29, Cetrificate = "Doctor certificate" };
        //Developer developer = new Developer() { Name = "name2", Surname = "surname2", Age = 30, ProgLang = "C#" };
        //Teacher teacher = new Teacher() { Name = "name3", Surname = "surname3", Age = 33, Subject = "Chemistry" };

        //Person person = new Doctor(); // more detailed next time
        //Person person => object decleration
        // new Person() => object initialization
        //person.WriteSomething();
        //person.PrintName();
        //doctor.PrintName();
        //developer.PrintName();
        //teacher.PrintName();    

        #endregion


        // polymorphism

        #region overload
        /*
         In overload, we keep return type same, but change parameter list or paremter type
         
         int Calculate()
         int Calculate(int a, int b)
         int Calculate(int a, int b, int b)
         int Calculate(int a, int b, string oprationType)
         */
        //MathExample mathExample = new MathExample();
        //int a  = mathExample.Calculate();
        //Console.WriteLine(a);
        //Console.WriteLine(mathExample.Calculate(2, 3));
        //Console.WriteLine(mathExample.Calculate(2, 3, "+"));

        #endregion

        #region override
        //Doctor doctor = new Doctor() { Name = "name1", Surname = "surname1", Age = 29, Cetrificate = "Doctor certificate" };
        //Developer developer = new Developer() { Name = "name2", Surname = "surname2", Age = 30, ProgLang = "C#" };
        //Teacher teacher = new Teacher() { Name = "name3", Surname = "surname3", Age = 33, Subject = "Chemistry" };

        //Console.WriteLine(doctor.CalculateSalary());
        //Console.WriteLine(developer.CalculateSalary());
        //Console.WriteLine(teacher.CalculateSalary());
        #endregion

        // pure OOP
        // encapsulation
        // inheritance => hierarchy of working of constructors, sealed keyword
        // abstraction => asbtract classes, asbtract methods
        // polymorphism => overloading methods and overriding methods, virtual methods


        // constructor and field
        #region interface
        //ICard card = new Person();
        //IPerson person = new Person();
        //IPerson person1 = new WorkerClass();
        //person.ShowID();
        //person1.ShowID();
        

        #endregion

        // class as return type, parameter and property
        #region return class type
        //Methods methods = new Methods();        
        //Person person = methods.ReturnPerson("name1", "surname1", 29); // creates a new person object with its data        
        //methods.ShowPersonData(person); // takes input as Person type then prints its properties 



        
        #endregion
    }
}

// interface vs abstract class 

// 

// diamond problem => one class cannot derive from multiple classes .
// In this case, if base classes have methods with same signature,
// when we create object of derived class and want to use this method,
// it may not decide which method of class should it use .
// Example below, We try to derive D class from C and B classes, it cannot be done in pure OOP 
//class A
//{

//}

//class B:A
//{
//    public void WriteSomething()
//    {

//    }
//}

//class C : B
//{
//    public void WriteSomething()
//    {

//    }
//}

//class D : C, B
//{

//}
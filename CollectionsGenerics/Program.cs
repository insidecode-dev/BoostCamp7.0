using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // collections
        // generic and non generic
        // IEnumerable, ICollections, IList
        #region entry to collections

        // generic collection
        // List<T> list = new List<T>(); => T is type

        //List<string> stringList = new List<string>() {"str1", "str2", "str3"};
        //stringList.Add("str4");
        //stringList.Add("str5");
        //stringList.Add("str6");
        //stringList.Add("str6");
        //stringList.Add("str4");
        //stringList.Add("str4");
        //stringList.Add("str4");
        ////stringList[1] = "23";

        //int[] intArray = { 1, 2, 3 , 4, 5, 6, 6, 7, 9};


        //foreach (int num in intArray) {
        //    if (num%2==0)
        //    {
        //        stringList.Add(num.ToString());
        //    }
        //}

        //IEnumerable<string> strings = new List<string>() { "str1", "str2", "str3" }; // iterate
        //ICollection<string> strings1 = new List<string>() { "str1", "str2", "str3" }; // removes, addds item        
        //IList<string> strings2 = new List<string>(); //RemoveAt, Insert  

        //List<string> strings3 = new List<string>(); 





        //stringList.AddRange(stringList);



        //stringList.AddRange({ "atr1", });









        #endregion   

        // non-generic collection
        #region ArrayList
        //ArrayList arrayList = new ArrayList();
        //arrayList.Add(1);
        //arrayList.Add(true);
        //arrayList.Add(2.3);
        //arrayList.Add(DateTime.Now);

        // float
        // double => default
        // decimal


        #endregion

        // generic collection
        #region Dictionary<T>
        //Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>() {
        //    { 1, new List<int> { 1, 2, 3} },
        //    { 4, new List<int> { 4, 6} } };

        //List<int> newList = dictionary[1];

        //foreach (int i in newList)
        //{
        //    Console.WriteLine(i);
        //}
        #endregion
    }
}
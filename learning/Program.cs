using System;
using Learning;

namespace HelloWorld
{
    public class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // Array in C#
            string[] strArr = ["Prasanth", "Deva"];
            string[] exp2 = new string[2];

            exp2[0] = "Vennila";
            Console.WriteLine(exp2[0]);

            List<string> mylist = new List<string>();


            mylist.Add("Miruthula");

            // int[] a;
            // a[0] = 1; // thorwing you used the variable but value is not initalized

            IEnumerable<string> temp = mylist;

            List<string> backto = temp.ToList();

            foreach (var a in temp)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Multi Dimensional Array");
            //2d array
            int[,] multiDArr = {
            {1,2},//0
            {3,4}//1
        };

            // [0,1] 0 represents arrays first index and 1 represent 0 array index value array
            Console.WriteLine(multiDArr[0, 1]);

            //3d array
            int[,,] multiDArr2 = {
{//0
    {1,2},//0
    {3,4} //1
},
{//1
    {5,6}, //0
    {7,8} //1
}
};

            Console.WriteLine(multiDArr2[0, 1, 0]);


            Console.WriteLine("Dictionary");

            Dictionary<int, string> studentdata = new Dictionary<int, string>();

            studentdata.Add(80, "Prasanth");
            studentdata.Add(90, "Vennila");

            Console.WriteLine(studentdata[80]);

            int aa = 10;

            Console.WriteLine($"this is the number aa:{aa}");
            Exercise.Run();
        }
    }
}
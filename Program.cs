//(((((((((((((((1)))))))))))))))
//Array
//class a
//{
//    static void Main(string[] args)
//    {
//        int[] arr = new int[5];
//        arr[0] = 1;
//        arr[1] = 2;
//        arr[2] = 3;
//        arr[3] = 4;

//        Console.WriteLine("grade1={0}", arr[0]);
//        Console.WriteLine("grade2={0}", arr[1]);
//        Console.WriteLine("grade3={0}", arr[2]);
//        Console.WriteLine("grade4={0}", arr[3]);
//    }

//}
//(((((((((((((((2)))))))))))))))
//Array method
//class a
//{
//    static void main()
//    {
//        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 3 };
//        Console.WriteLine("first number ={0} {1} {2}", arr[0], arr[1], arr[2]);
//    }
//}
//(((((((((((((((3)))))))))))))))
//foreach
//class a
//{
//    static void Main()
//    {
//        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        foreach(int i in arr)
//        {
//            Console.WriteLine("element number{0}={1}",i,i);
//        }
//    }
//}
//(((((((((((((((4)))))))))))))))
// 2d array ,3d array [num of matrix,rows,cols]
//class a
//{
//    static void Main()
//    {
//        int[,] arr = new int[,] {
//            { 1,1,1},{2,2,22 }
//        };
//        Console.WriteLine(arr[1,2]);
//    }
//}
//(((((((((((((((5)))))))))))))))
//nested array
//class a
//{
//    static void Main()
//    {
//        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
//        for (int i = 0; i < arr.GetLength(0); i++)
//        {
//            for (int j = 0; j < arr.GetLength(1); j++)
//            {
//                Console.WriteLine(arr[i, j]);
//            }

//        }
//    }

//}
//(((((((((((((((6)))))))))))))))
// jagged array
//class a
//{
//    static void Main()
//    {
//        int[][] arr = new int[][]
//        {
//            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
//            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 }
//        };
//        Console.WriteLine(arr[0][2]);
//    }
//}
//(((((((((((((((7)))))))))))))))
//Array list
//using System;
//using System.Collections;
//class a
//{
//    static void Main()
//    {
//        ArrayList a1 = new ArrayList();
//        ArrayList a2 = new ArrayList(100); 
//        a1.Add(1);
//        a1.Add(3);
//        a1.Add(5);
//        a1.Add("hello from a1");
//        a1.Add(11.11);
//        a1.Add(12.12);
//        a1.Add(13.13);
//        a1.Remove(13);
//        Console.WriteLine(a1.Count);
//        double sum = 0;
//        foreach (object a in a1)
//        {
//            if(a is int)
//            {
//                 sum+=Convert.ToDouble(a);
//            }else if(a is double)
//            {
//                 sum+=(double)a;
//            }else if(a is string)
//            {
//                Console.WriteLine(a);
//            }
//        }
//        Console.WriteLine(sum);


//    }
//}
//(((((((((((((((8)))))))))))))))
//List
using System;
using System.Collections;
using System.Collections.Generic;
class a
{
    static void Main()
    {
        var friends=new List<string> { "mo","mi","mu","ml","mk","mj","mh" };
        //Console.WriteLine(friends[0]);
        var f1 = GetP1(friends, 3);
        foreach (var f in f1)
        {
            Console.WriteLine(f);
        }

    }
    static List<string> GetP1(List<string> list,int ctr)
    {
        var p1=new List<string>();
        while (p1.Count<ctr)
        {
            var curP = GetP(list);
            p1.Add(curP);
            list.Remove(curP);
        }
        return p1;
    }
    static string GetP(List<string> list)
    {
        string fName = list[0];
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Length<fName.Length)
            {
                fName = list[i];
            }
        }
        return fName;
    }
}
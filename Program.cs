using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Lab2._2
{
    class Library1
    {
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib.dll", CallingConvention = CallingConvention.Cdecl)] /*импорт dll*/
        public static extern double TheFunc(double x);
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern char FuncName();

        public char CallTheFuncName()
        {
            try { return FuncName(); }
            catch { return ('-'); }
        }
        public double CallTheFunc(double x)
        {
            try { return TheFunc(x); }
            catch { throw new Exception("График не может быть построен"); }
        }
    }
    class Library2
    {
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-2-1.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-2-1.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern char FuncName();

        public char CallTheFuncName()
        {
            try { return FuncName(); }
            catch { return ('-'); }
        }
        public double CallTheFunc(double x)
        {
            try { return TheFunc(x); }
            catch { throw new Exception("График не может быть построен"); }
        }
    }
    class Library3
    {
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-2-2.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-2-2.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern char FuncName();

        public char CallTheFuncName()
        {
            try { return FuncName(); }
            catch { return ('-'); }
        }
        public double CallTheFunc(double x)
        {
            try { return TheFunc(x); }
            catch { throw new Exception("График не может быть построен"); }
        }
    }
    class Library4
    {
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-2-3-1.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-2-3-1.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern char FuncName();

        public char CallTheFuncName()
        {
            try { return FuncName(); }
            catch { return '-'; }
        }
        public double CallTheFunc(double x)
        {
            try { return TheFunc(x); }
            catch { throw new Exception("График не может быть построен"); }
        }
    }
    class Library5
    {
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-3-2.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-3-2.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern char FuncName();

        public char CallTheFuncName()
        {
            try { return FuncName(); }
            catch { return ('-'); }
        }
        public double CallTheFunc(double x)
        {
            try { return TheFunc(x); }
            catch { throw new Exception("График не может быть построен"); }
        }
    }
    class Library6
    {
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-2-3.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double TheFunc(double x);
        [DllImport(@"C:\Users\User\source\repos\Lab2.2\Lab2.2\Lib2-2-3.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern char FuncName();

        public char CallTheFuncName()
        {
            try { return FuncName(); }
            catch { return '-'; }
        }
        public double CallTheFunc(double x)
        {
            try { return TheFunc(x); }
            catch { throw new Exception("График не может быть построен"); }
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {

            Library1 name1 = new Library1();
            char names1 = name1.CallTheFuncName();

            Library2 name2 = new Library2();
            char names2 = name2.CallTheFuncName();

            Library3 name3 = new Library3();
            char names3 = name3.CallTheFuncName();

            Library4 name4 = new Library4();
            char names4 = name4.CallTheFuncName();

            Library5 name5 = new Library5();
            char names5 = name5.CallTheFuncName();

            Library6 name6 = new Library6();
            char names6 = name6.CallTheFuncName();


            Console.WriteLine("Какую функцию хотите посчитать?(Если написан -, то функция отсутствует или dll не загружена)   "+" 1)" + names1+" 2)" + names2+" 3)"+names3+" 4)"+names4+" 5)" + names5 + " 6)"+names6);

            var xCoord = new List<double>();     
            var yCoord = new List<double>();

            string answer = Console.ReadLine();
            if (answer == "1") 
            {
                Library1 call1 = new Library1();
                
                for (double x = 0; x <= 10; x += 1)
                {
                    double calls1 = call1.CallTheFunc(x);
                    xCoord.Add(x);
                    yCoord.Add(calls1);
                }
                var graphic = new ScottPlot.Plot(300, 300);                   
                graphic.PlotScatter(xCoord.ToArray(), yCoord.ToArray());
                graphic.SaveFig("Function_1.png");

            }

            if (answer == "2")
            {
                Library2 call1 = new Library2();
                for (var x = 0; x <= 10; x += 1)
                {
                    double calls1 = call1.CallTheFunc(x);
                    xCoord.Add(x);
                    yCoord.Add(calls1);
                }
                var graphic = new ScottPlot.Plot(300, 300);                   
                graphic.PlotScatter(xCoord.ToArray(), yCoord.ToArray());
                graphic.SaveFig("Function_2.png");

            }
            if (answer == "3")
            {
                
                Library3 call1 = new Library3();
                for (var x = 0; x <= 10; x += 1)
                {
                    double calls1 = call1.CallTheFunc(x);
                    
                    xCoord.Add(x);
                    yCoord.Add(calls1);
                }
                var graphic = new ScottPlot.Plot(300, 300);                   
                graphic.PlotScatter(xCoord.ToArray(), yCoord.ToArray());
                graphic.SaveFig("Function_3.png");

            }
            if (answer == "4")
            {
                Library4 call1 = new Library4();
                for (var x = 0; x <= 10; x += 1)
                {
                    double calls1 = call1.CallTheFunc(x);
                    Console.WriteLine(calls1);
                    xCoord.Add(x);
                    yCoord.Add(calls1);
                }
                var graphic = new ScottPlot.Plot(300, 300);                  
                graphic.PlotScatter(xCoord.ToArray(), yCoord.ToArray());
                graphic.SaveFig("Function_4.png");

            }
            if (answer == "5")
            {
                Library5 call1 = new Library5();
                for (var x = 0; x <= 10; x += 1)
                {
                    double calls1 = call1.CallTheFunc(x);
                    Console.WriteLine(calls1);
                    xCoord.Add(x);
                    yCoord.Add(calls1);
                }
                var graphic = new ScottPlot.Plot(300, 300);                   
                graphic.PlotScatter(xCoord.ToArray(), yCoord.ToArray());
                graphic.SaveFig("Function_5.png");

            }
            if (answer == "6")
            {
                Library6 call1 = new Library6();
                for (var x = 0; x <= 10; x += 1)
                {
                    double calls1 = call1.CallTheFunc(x);
                    xCoord.Add(x);
                    yCoord.Add(calls1);
                }
                var graphic = new ScottPlot.Plot(300, 300);                  
                graphic.PlotScatter(xCoord.ToArray(), yCoord.ToArray());
                graphic.SaveFig("Function_6.png");

            }
            Console.ReadKey();
        }
    }
}

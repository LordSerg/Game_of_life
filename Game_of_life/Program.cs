using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_of_life
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("First programm");

        /*
        Application.EnableVisualStyles();
        Application.Run(new Form1());
          */


        //strt:
            //Console.ReadKey();

            //Form1 form = new Form1();
            //form.Show();
            //goto strt;


            //Console.ReadKey();


            
            Console.SetWindowSize(150, 50);
            Console.CursorSize=100;
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            //Microorganism M = new Microorganism(0, 0);
            int i = 1, j = 1,y=1,x=1;
            //bool b = true;
            
        x:
            if (i < Console.WindowHeight-1 && i > 0)
                i += y;
            else
            {
                i -= y;
                if (y == 1)
                    y = -1;
                else
                    y = 1;
            }
            if (j < Console.WindowWidth-1 && j > 0)
                j += x;
            else
            {
                j -= x;
                if (x == 1)
                    x = -1;
                else
                    x = 1;
            }
            Console.CursorTop = i;
            Console.CursorLeft = j;
            //Console.ForegroundColor=ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" ");
            //Console.WriteLine("i = {0}; j = {1}", i, j);
            Thread.Sleep(1);
            //Console.ResetColor();
            //Console.Clear();
            goto x;
            //Console.ReadKey();
            
        }
        
        class Microorganism
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Microorganism() { }

            public Microorganism(int coord_x,int coord_y):this()
            {
                X = coord_x;
                Y = coord_y;
            }
        }
        class M1: Microorganism
        {
            public M1(int x,int y,string n):base(coord_x,coord_y)
            {

            }
        }

    }
}

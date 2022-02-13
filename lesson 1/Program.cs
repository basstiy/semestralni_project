using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    internal class Program
    {
        static void Main(string[] args){
            double X = 0.5; //X=<0:1>  
            double R = 3.75; //MESICNI KOFICENT
            double X1;
            int akceZaDen = 130;
            int mamDolaru = 100;
            int mojeBassCoin = 5;


            //logistic map. pokud R bude kolem 3.75 je možny dostat rondomny čisla.
            for (int mesic = 0; mesic < 10; mesic++){
                int[] sloupec = new int[akceZaDen];

                //tady dostavam 10 randomne čislo pro jeden den a ukladam je na pole.
                for (int den = 0; den < akceZaDen; den++){
                    X1 = 1 - X;
                    X = R * X * X1;
                    int someInt = (int)(X*10);
                    sloupec[den] = someInt;
                }
                for (int i = 0; i < akceZaDen; i++)
                {
                    Console.Write(sloupec[i] + " ");
                }
                Console.WriteLine("\n");

                for (int i = 10; i > 0; i--) {
                    for (int j = 0; j < akceZaDen; j++){

                        mojeBassCoin = 


                        drawMap(sloupec[j], i);

                    }
                    Console.WriteLine("");

                }
                Console.WriteLine("\n");
            }

        }
        
        static void drawMap(int sloupec, int i)
        {
            if (sloupec == i) { Console.Write("X"); }
            else
            {
                Console.Write(".");

            }
        }
       

    }

}

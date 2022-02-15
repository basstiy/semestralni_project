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
            double bassKoint_soucastnaCena = 0.5; //X=<0:1>  
            double R = 3.75; //MESICNI KOFICENT
            
            int akceZaDen = 130;
            

            double mamDolaru = 100;
            double mojeBassCoin = 0;

            /*
             
            BassCoin je moje virtualni kripto mena.
            1 dolar = <0.1:0.9> bassCoin

            Formule Kvadratické Mapování Xn+1 = R*Xn *(1 - X n) je velmi dobra formule pro vytvaření houtického grafu.
            

            //logistic map. pokud R bude kolem 3.75 je možny dostat rondomny čisla.
            */





            for (int mesic = 0; mesic < 10; mesic++){
                int[] sloupec = new int[akceZaDen];
                double[] mapaBassCoinu = new double[akceZaDen];

                //tady dostavam 10 randomne čislo pro jeden den a ukladam je na pole.
                for (int den = 0; den < akceZaDen; den++){
                    double tmp = 1 - bassKoint_soucastnaCena;
                    mapaBassCoinu[den]= bassKoint_soucastnaCena = R * bassKoint_soucastnaCena * tmp;
                    sloupec[den] = (int)(bassKoint_soucastnaCena * 10);
                }
                
                for (int i = 0; i < akceZaDen; i++)
                {
                    Console.Write(mapaBassCoinu[i] + " ");
                    if (mapaBassCoinu[i] < 0.4 && mamDolaru > 0)
                    {
                        mamDolaru -= mapaBassCoinu[i]*2;
                        mojeBassCoin = mojeBassCoin +2 ;
                    }



                        /*
                        if (mapaBassCoinu[i] > 0.5 && mamDolaru>0)
                        {
                            mamDolaru = mamDolaru - 2;
                            mojeBassCoin = mojeBassCoin + (mapaBassCoinu[i] * 2);
                        } 
                        else if (mapaBassCoinu[i] < 0.4 && mojeBassCoin> 0)
                        {
                            mamDolaru = mamDolaru + (mojeBassCoin / mapaBassCoinu[i]);
                            mojeBassCoin = 0;
                        }
                        */  
                    }


                Console.WriteLine("\n");

                for (int row = 10; row > 0; row--) {
                    for (int j = 0; j < akceZaDen; j++){
                        drawMap(sloupec[j], row,j);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("\nMam dolaru:{0}. Mam BassCoinu: {1}. ", mamDolaru, mojeBassCoin);


            }

        }
        
        static void drawMap(int mapa, int row,int sloupec)
        {
            if (sloupec == 0) { Console.Write(row + ":"); }
            if (mapa == row) { Console.Write("X"); }
            else
            {
                Console.Write(".");

            }
        }
       

    }

}

using System;

namespace Kino_projekt
{
    struct Pretplata
    { //ovo je jos jedan test
        public string kupac;
        public int godina;
        public double uplata;

        public static Pretplata[] Red(int n)
        {
            Pretplata[] niz = new Pretplata[n];

            for (int i = 0; i < n; i++)
            {
                string kupac = "";
                bool resu = false;
                while (resu == false)
                {

                    Console.WriteLine("Unesite naziv");
                    string kupacTrim = Console.ReadLine();
                    kupac = kupacTrim.Trim();
                    if (string.IsNullOrEmpty(kupac))
                    {
                        Console.WriteLine("Pogrešan unos");
                        Console.WriteLine("");
                    }
                    else
                    {
                        resu = true;
                    }



                }

                var Random = new Random();
                int godina = Random.Next(1940, 2017);
                //int godina = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Upišite uplatu");
                double uplata = 0;
                while (uplata == 0 || uplata < 0)
                {
                    bool res;
                    double novci = 0;
                    string uplataNovaca = Console.ReadLine();
                    res = double.TryParse(uplataNovaca, out novci);
                    if (res == true)
                    {
                        uplata = novci;
                    }


                }



                Pretplata pretplata = new Pretplata();
                pretplata.kupac = kupac;
                pretplata.godina = godina;
                pretplata.uplata = uplata;

                niz[i] = pretplata;

            }

            return niz;
        }

        public static void ListaSvih(Pretplata[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine("Kupac " + niz[i].kupac + " je rođen " + niz[i].godina + ". godine" + " te je uplatio " + niz[i].uplata + "kuna");

            }


        }

        public static void Popust(Pretplata[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
            {
                int godine = 2020 - niz[i].godina;

                if (godine < 12)
                {
                    double popust = niz[i].uplata * 0.5;
                    niz[i].uplata = popust;

                    //Console.WriteLine(" test " + niz[i].uplata);
                    Console.WriteLine("Cijena za " + niz[i].kupac + " je " + popust);
                }
                else if (godine > 65)
                {
                    double popust = niz[i].uplata * 0.9;
                    niz[i].uplata = popust;
                    //Console.WriteLine(" test " + niz[i].uplata);
                    Console.WriteLine("Cijena za " + niz[i].kupac + " je " + popust);
                }


            }

            // test 

            if (niz.Length > 3)
            {
                bool nisuIsti = false;

                while (nisuIsti != true)
                {

                    Random random = new Random();
                    int start1 = random.Next(0, niz.Length);
                    int start2 = random.Next(0, niz.Length);

                    if (start1 != start2)
                    {
                        Console.WriteLine("Kupci " + niz[start1].kupac + " i " + niz[start2].kupac + " ostvaruju besplatnu preplatu. ");
                        niz[start1].uplata = 0;
                        niz[start2].uplata = 0;
                        nisuIsti = true;


                    }

                }



            }










            /*double najmanji = double.MinValue;
            double najmanji1 = double.MinValue;
            double najmanji2 = double.MinValue;

            for(int i = 0; i < niz.Length; i++)
            {
                if(niz.Length < 3)
                {

               
                double uplata = niz[i].uplata;

                if(uplata > najmanji)
                {
                    najmanji2 = najmanji1;
                    najmanji1 = najmanji;
                    najmanji = uplata;

                }

                else if(uplata > najmanji2)
                {
                    najmanji2 = najmanji1;
                    najmanji1 = uplata;

                }

                else if(uplata > najmanji1)
                {
                    najmanji2 = uplata;
                }
                }

                
                if(niz.Length > 3)
                {
                    

                    for (int a = 0; a < 4; a++)
                    {
                        Random random = new Random();
                        int start1 = random.Next(0, niz.Length);
                        Console.WriteLine("test" + niz[start1].kupac);

                    }

                    /*Random random = new Random();
                    int start1 = random.Next(0, niz.Length);
                    int start2 = random.Next(0, niz.Length);
                    int start3 = random.Next(0, niz.Length);
                    Console.WriteLine("test" + niz[start1].kupac);
                    Console.WriteLine("test" + niz[start2].kupac);
                    Console.WriteLine("test" + niz[start3].kupac);
                    
                }

                else
                {
                    Console.WriteLine("Najmanju cijenu karte imaju: ");
                    for(int d = 0; d <niz.Length- 1; i++)
                    {
                        if (niz[d].uplata == najmanji)
                        {
                            Console.WriteLine(niz[d].kupac);
                        }
                        else if (niz[i].uplata == najmanji1)
                            Console.WriteLine(niz[d].kupac);
                        else if (niz[i].uplata == najmanji2)
                            Console.WriteLine(niz[d].kupac);
                        Console.WriteLine("");

                    }
                }
            }*/


        }


        /* public static void Inicijali(Pretplata[] niz)
         {
             for(int i = 0; i < niz.Length; i++)
             {

                 string[] prvaSlova = 
                 prvaSlova = Convert.ToString(niz[i].kupac[0]);


                 /*for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
                 {
                     if(prvoSlovo == alphabet)
                     {

                     }
                 }

             }

         }*/



        class Program
        {

            static void Main(string[] args)
            {
                int brojPreplata = 0;
                int pretplata = 0;

                while (pretplata < 1 || pretplata > 50)
                {

                    bool res;

                    Console.WriteLine("Unesite broj pretplata");
                    string pret = Console.ReadLine();
                    res = int.TryParse(pret, out pretplata);
                    if (res == true)
                    {
                        brojPreplata = pretplata;
                    }

                }



                Pretplata[] niz = Red(brojPreplata);

                Console.WriteLine(brojPreplata);

                ListaSvih(niz);
                Popust(niz);
                //Inicijali(niz);

            }
        }
    }
}

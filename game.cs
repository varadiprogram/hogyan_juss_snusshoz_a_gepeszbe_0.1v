﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int inventory = 0;

            Console.WriteLine("Hogyan juss snüsszhöz a Gépészben 0.1");
            Console.WriteLine("");
            Console.WriteLine("Ebben a játékban a nyertes folyamatosan változik, mivel itt az nyer, aki a legtöbb snüsszt gyűjti a játékban.");
            Console.WriteLine("A JÁTÉK UTÁN ÍRD FEL IDE, HÁNY SNÜSSZT SZEREZTÉL ÖSSZESEN:");
            Console.WriteLine("https://docs.google.com/spreadsheets/d/1TEZsWnq3irG0vdi6JIUd_1V90FYKk4JwnP0pJbL4ans/edit?usp=sharing");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Nem lesz nyertes vagy vesztes, hanem az fog nyerni, aki a legtöbb snüsszt szerzi a nap végén.");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ad meg a neved:");
            string nev = Console.ReadLine();
            Console.WriteLine(nev + " vagyok, és szereznem kellene pár snüsszt. Mit csináljak?");
            Console.WriteLine("");

            int valasz;
            do
            {
                Console.WriteLine("Snüsszhöz kell jutnod, mert függő vagy. Mit csinálsz?");
                Console.WriteLine("1 - veszel");
                Console.WriteLine("2 - megpróbálsz kérni pár haverodtól");
                Console.WriteLine("3 - inventory");
                Console.WriteLine("4 - kilépés");

                valasz = int.Parse(Console.ReadLine());

                if (valasz == 1)
                {
                    Random penzt = new Random();

                    Console.WriteLine("Venni akarok snüsszt, és 250 Ft-ba kerül. Nézzük meg, mennyi pénzem van.");
                    Console.WriteLine("Nyomj egy Enter-t a pénzed megtekintéséhez.");
                    Console.ReadLine();

                    int RandomPenz = penzt.Next(2, 20000);
                    Console.WriteLine("Ennyi pénzed van: " + RandomPenz + " Ft");
                    Console.WriteLine("");
                    Console.WriteLine("Oda mész Harcsához, és megkérdezed, ki árul snüsszt a Gépészben.");
                    Console.WriteLine("Harcsa: Szia bátyús, most sehol sincs, én is pangok.");
                    Console.WriteLine("Harcsa: Szia bátya, menjünk, vegyünk!");
                    Console.WriteLine(nev + ": Menjünk.");
                    Console.WriteLine("");
                    Console.WriteLine("Harcsa elvezet egy random csávóhoz.");
                    Console.WriteLine("Random csávó: Mennyi kell?");

                    int mennyikell = int.Parse(Console.ReadLine());

                    if (250 * mennyikell > RandomPenz)
                    {
                        Console.WriteLine("Nincs elegendő vagyonod.");
                    }
                    else
                    {
                        int osszeg = mennyikell * 250;
                        RandomPenz -= osszeg;

                        inventory += mennyikell;

                        Console.WriteLine("Vásároltál " + mennyikell + " snüsszt.");
                        Console.WriteLine("A pénzed most: " + RandomPenz + " Ft.");
                    }
                }
                else if (valasz == 2)
                {
                    Random rand = new Random();

                    int RandomBarat = rand.Next(1, 11);
                    Console.WriteLine("Ennyi barátodtól próbálsz kérni: " + RandomBarat);

                    for (int i = 1; i <= RandomBarat; i++)
                    {
                        int valasztas = rand.Next(0, 2);

                        if (valasztas == 0)
                        {
                            Console.WriteLine("Barát " + i + ": ÁÁÁÁ tesóm, bocsi, de nincs, tudod, adnám.");
                        }
                        else
                        {
                            Console.WriteLine("Barát " + i + ": Persze, tesóm, itt egy.");
                            inventory++;
                            Console.WriteLine("Kaptál egy snüsszt, és bekerült az inventoryba.");
                        }
                    }
                }
                else if (valasz == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Jelenlegi snüsszok száma az inventoryban: " + inventory);
                    Console.WriteLine("");
                }

            } while (valasz != 4);

            Console.WriteLine("Ennyi snüsszt gyűjtöttél összesen: " + inventory);
            Console.WriteLine("NE FELEJSD EL FELVINNI, HÁNY SNÜSSZT GYŰJTÖTTÉL!");
            Console.WriteLine("https://docs.google.com/spreadsheets/d/1TEZsWnq3irG0vdi6JIUd_1V90FYKk4JwnP0pJbL4ans/edit?usp=sharing");
            Console.ReadKey();




        }
}
}

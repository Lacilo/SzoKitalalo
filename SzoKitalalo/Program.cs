using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzoKitalalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROGRAMHOZ SZÜKSÉGES VÁLTOZÓK, LISTÁK INICIALIZÁLÁSA
            string[] szavak = { "alma", "körte", "medence", "bálna", "béka", "mennyezet" };
            string szo = "";
            int szoHossz = 0;
            Random rnd = new Random();
            string[] eredLista;
            string[] helyesLista;
            string tipp = "";
            bool benneVan = false;
            int eletero = 10;

            // MEGJELENÍTÉSRE HASZNÁLHATÓ LISTA LÉTREHOZÁSA ÉS A HELYES KARAKTEREKET SORRENDBEN TARTALMAZÓ LISTA
            szo = szavak[rnd.Next(szavak.Length)];
            szoHossz = szo.Length;
            eredLista = new string[szoHossz];
            helyesLista = new string[szoHossz];


            // EREDMÉNY LISTA FELTÖLTÉSE _ KARAKTEREKKEL ( KEZDETI ÁLLAPOTHOZ )
            EredListaFeltoltes(szoHossz, eredLista);

            // A HELYES SZÓ KARAKTEREIT TARTALMAZÓ LISTA FELTÖLTÉSE
            HelyesListaFeltoltes(szo, szoHossz, helyesLista);

            // KEZDETI MEGJELENÍTÉS
            Megjelenit(eredLista, "Kezdheti a játékot!", eletero);


            // FŐCIKLUS, ADDIG MEGY AMÍGY A JÁTÉKOS TIPPJEIT TARTALMAZÓ LISTA NEM EGYEZIK MEG A SZÓVAL
            do
            {
                // A FELHASZNÁLÓ TIPPJÉNEK BEKÉRÉSE
                Console.Write("\nAdja meg a tippjét \\-$ ");
                tipp = Console.ReadLine().ToString();

                if (tipp == "")
                {
                    Megjelenit(eredLista, "Kérem adjon meg egy karaktert!", eletero);
                }
                else
                {
                    // ELLENŐZIZZÜK HOGY TARTALMAZZA-E A TIPPET A SZÓ
                    int[] indexek;
                    BenneVanE(szo, helyesLista, tipp, out benneVan, out indexek);


                    // ANNAK MEGFELELŐEN JÁRUNK EL HOGY A TIPP BENNE VAN-E A SZÓBAN
                    if (benneVan) // HA BENNE VAN
                    {
                        foreach (var i in indexek)
                        {
                            Console.WriteLine(i);
                            eredLista[i] = tipp;
                        }

                        // EDDIGI EREDMÉNY MEGJELENÍTÉSE BENNE VAN SZÖVEGGEL
                        Megjelenit(eredLista, "Benne van!", eletero);

                    }
                    else // HA NINCS BENNE
                    {
                        // ÉLETERŐ CSÖKKENTÉSE
                        eletero--;

                        // EDDIGI EREDMÉNY MEGJELENÍTÉSE NINCS BENNE SZÖVEGGEL
                        Megjelenit(eredLista, "Nincs benne !", eletero);

                    }
                }

            } while (string.Join("", eredLista) != szo && eletero != 0);           

            // FŐ LOOPBÓL VALÓ KILÉPÉS VIZSGÁLATA
            if (string.Join("", eredLista) == szo) // HA ELTALÁLTA A SZÓ
            {
                Console.WriteLine("\negnyerte a játékot!");
            }
            else // HA NEM TALÁLTA EL A SZÓT
            {
                Console.WriteLine("\nElvesztette a játékot mivel elfogyott az életereje!");
            }

            
        }    



        // A HELYES MEGOLDÁST TARTALMAZÓ LISTA FELTÖLTÉSÉRE HASZNÁLHATÓ
        private static void HelyesListaFeltoltes(string szo, int szoHossz, string[] helyesLista)
        {
            for (int i = 0; i < szoHossz; i++)
            {
                helyesLista[i] = szo[i].ToString();
            }
        }


        // A FELHASZNÁLÓ EREDMÉNYÉT TARTALMAZÓ LISTA FELTÖLTÉSÉRE HASZNÁLHATÓ
        private static void EredListaFeltoltes(int szoHossz, string[] eredLista)
        {
            for (int i = 0; i < szoHossz; i++)
            {
                eredLista[i] = "_";
            }
        }


        // ELLENŐRZI, BENNE VAN-E A FELHASZNÁLÓ TIPPJE, HA IGEN VISSZAADJA HOGY IGEN ÉS AZ ELŐFORDULÁS INDEXEIT
        private static void BenneVanE(string szo, string[] helyesLista, string tipp, out bool benneVan, out int[] indexek)
        {
            int index = 0;
            indexek = new int[szo.Count(c => c == char.Parse(tipp))];
            benneVan = false;
            int indexSzaml = 0;

            foreach (string s in helyesLista)
            {
                if (s == tipp)
                {
                    benneVan = true;
                    indexek[indexSzaml] = index;
                    indexSzaml++;
                }

                index++;
            }
        }


        // AZON LISTA MEGJELENÍTÉSE AMELYET A MEGJELENÍTŐ FELÜLET HASZNÁL TEHÁT eredLista MEGJELENÍTÉSE
        static void Megjelenit(string[] eredLista, string uzenet, int eletero) 
        {
            // KONZOL LETISZÍTÁSA
            Console.Clear();

            // FELHASZNÁLÓ EDDIGI EREDMÉNYÉT TARTALMAZÓ LISTA KIÍRÁSA
            foreach (var b in eredLista)
            {                
                Console.Write(b + " ");
            }

            // ELTALÁLTA / NEM TALÁLTA EL ÜZENET KIÍRÁSA
            Console.WriteLine("\n\n" + uzenet + "\n");

            // ÉLETERŐ KIÍRÁSA
            Console.WriteLine("életerő: " + eletero);

        }
    }
}

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
            Megjelenit(eredLista, "Kezdheti a játékot!");


            // FŐCIKLUS, ADDIG MEGY AMÍGY A JÁTÉKOS TIPPJEIT TARTALMAZÓ LISTA NEM EGYEZIK MEG A SZÓVAL
            do
            {
                // A FELHASZNÁLÓ TIPPJÉNEK BEKÉRÉSE
                Console.Write("\nAdja meg a tippjét \\-$ ");
                tipp = Console.ReadLine().ToString();

                if (tipp == "")
                {
                    Megjelenit(eredLista, "Kérem adjon meg egy karaktert!");
                }
                else
                {
                    // ELLENŐZIZZÜK HOGY TARTALMAZZA-E A TIPPET A SZÓ
                    int[] indexek;
                    BenneVanE(szo, helyesLista, tipp, out benneVan, out indexek);


                    // ANNAK MEGFELELŐEN JÁRUNK EL HOGY A TIPP BENNE VAN-E A SZÓBAN
                    if (benneVan)
                    {
                        foreach (var i in indexek)
                        {
                            Console.WriteLine(i);
                            eredLista[i] = tipp;
                        }

                        // AMENNYIBEN BENNE VAN ENNEK MEGFELELŐ MEGJELENÍTÉS
                        Megjelenit(eredLista, "Benne van!");
                    }
                    else
                    {
                        // AMENNYIBEN NINCS BENNE ENNEK MEGFELELŐ MEGJELENÍTÉS
                        Megjelenit(eredLista, "Nincs benne !");
                    }
                }

            } while (string.Join("", eredLista) != szo);

        }

        private static void HelyesListaFeltoltes(string szo, int szoHossz, string[] helyesLista)
        {
            for (int i = 0; i < szoHossz; i++)
            {
                helyesLista[i] = szo[i].ToString();
            }
        }

        private static void EredListaFeltoltes(int szoHossz, string[] eredLista)
        {
            for (int i = 0; i < szoHossz; i++)
            {
                eredLista[i] = "_";
            }
        }

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
        static void Megjelenit(string[] eredLista, string uzenet) 
        {
            // KONZOL LETISZÍTÁSA
            Console.Clear();

            // FELHASZNÁLÓ EDDIGI EREDMÉNYÉT TARTALMAZÓ LISTA KIÍRÁSA
            foreach (var b in eredLista)
            {                
                Console.Write(b + " ");
            }

            // ELTALÁLTA / NEM TALÁLTA EL ÜZENET KIÍRÁSA
            Console.WriteLine("\n" + uzenet);
        }
    }
}

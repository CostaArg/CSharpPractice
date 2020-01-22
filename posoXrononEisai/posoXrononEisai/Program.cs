using System;

namespace posoXrononEisai
{
    class Program
    {
        static void Main(string[] args)
        {
            string poli;
            int ilikia;

            do
            {
                Console.WriteLine("Apo pou eisai? Athina h Thessaloniki? ");
                poli = Console.ReadLine();

            } while (poli != "Athina" && poli != "Thessaloniki");

            do
            { 
                Console.WriteLine("Dwse thn hlikia sou metaksi tou 1 kai tou 100: ");
                ilikia = Int32.Parse(Console.ReadLine());

            } while (ilikia >100 || ilikia<1);

            if (ilikia < 18)
            {
                Console.WriteLine("Den mporeis na dwseis gia eksetaseis");
            }
            else
            {
                if (poli == "Athina")
                {
                    Console.WriteLine("Mporeis na dwseis eksetaseis sto eksetastiko kentro ths Athinas");
                }
                else
                {
                    Console.WriteLine("Mporeis na dwseis eksetaseis sto eksetastiko ketro ths Thessalonikis");
                }
            }

        }
    }
}

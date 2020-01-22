using System;

namespace posoXrononVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            string poli;
            int ilikia;

                Console.WriteLine("Se poia poli meneis? ");
                poli = Console.ReadLine();


            do
            {
                Console.WriteLine("Dwse thn hlikia sou metaksi tou 1 kai tou 100: ");
                ilikia = Int32.Parse(Console.ReadLine());

            } while (ilikia > 100 || ilikia < 1);

            if (ilikia < 18)
            {
                Console.WriteLine("Den mporeis na dwseis gia eksetaseis");
            }
            else
            {
                if (poli.ToUpper() == "ATHINA")
                {
                    Console.WriteLine("Mporeis na dwseis eksetaseis sto eksetastiko kentro ths Athinas");
                }
                else if (poli.ToUpper() == "THESSALONIKI")
                {
                    Console.WriteLine("Mporeis na dwseis eksetaseis sto eksetastiko kentro ths Thessalonikis");
                }
                else
                {
                    Console.WriteLine("Mporeis na dwseis eksetaseis eite sto eksetastiko kentro \nths Athinas eite ths Thessalonikis");
                }
            }

        }
    }
}

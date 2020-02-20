using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract3
{
    class Program
    {
        static void Main(string[] args)
        {

            
        }
    }

    abstract class Product1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int VAT { get; set; }

        public abstract void Output();
        
    }

    abstract class Cigarette : Product1
    {
        public int Pisa { get; set; }
        public int Nicotine { get; set; }
        public int MonoksidioTouAnthraka { get; set; }

        public abstract void DisplayContents();

    }

    class Kapnos : Cigarette
    {
        public Kapnos(int id, string name, int price, int vac, )
        {

        }

        public override void DisplayContents()
        {
            throw new NotImplementedException();
        }

        public override void Output()
        {
            throw new NotImplementedException();
        }
    }
}

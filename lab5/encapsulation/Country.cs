using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Country
    {
        //use "private" for information (data) hiding
        private string capital;

        public Country(string capital)
        {
            this.capital = capital;
        }

        public void show()
        {
            Console.WriteLine(capital);
        }

        //getter
        public string getCapital() {
            return capital;
        }

        //setter
        public void setCapital(string capital) { 
            this.capital = capital;
        }
    }
}

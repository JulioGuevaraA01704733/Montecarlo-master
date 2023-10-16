using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montecarlo.Modelos
{
    public class Satelite
    {
        public int IdSatelite { get; set; }
        public int NumPaneles { get; set; }

        public List<int> ListaValores { get; set; }

        public int Xi {  get; set; }  

        public Satelite(int idSatelite, int numPaneles, List<int> listaValores, int xi)
        {
            IdSatelite = idSatelite;
            NumPaneles = numPaneles;
            ListaValores = listaValores;
            Xi = xi;
        }
        public Satelite() 
        {
            ListaValores = new List<int>();
        }

    }
}

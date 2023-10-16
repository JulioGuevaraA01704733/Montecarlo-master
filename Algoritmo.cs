using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Montecarlo.Modelos;

namespace Montecarlo.Montecarlo
{
    public class Algoritmo
    {
        public List<Satelite> lista = new List<Satelite>();
        public List<Satelite> GenerarLista(int paneles, int experimento, int a, int b)
        {
            List<Satelite> lista = new List<Satelite>();
            for (int i = 0; i < experimento; i++)
            {
                Satelite satelite = new Satelite();
                for (int j = 0; j < paneles; j++)
                {
                    //List<int> AleatoriosPaneles = new List<int>();
                    Random rand = new Random();
                    int numeroAleatorio = rand.Next(a, b + 1);
                    //List<int> listadepaneles;
                    //listadepaneles.Add(numeroAleatorio);

                    //AleatoriosPaneles.Add(numeroAleatorio);
                    satelite.ListaValores.Add(numeroAleatorio);

                    //satelite.ListaValores = listadepaneles;
                    //satelite.ListaValores = numeroAleatorio;
                    

                    //satelite.ListaValores.Add(numeroAleatorio1); 
                }
                Random randxi = new Random();
                int indicexi = randxi.Next(0, paneles);
                satelite.Xi = satelite.ListaValores[indicexi];
                lista.Add(satelite);
            }
            return lista;
        }
        /*
                public List<Satelite> Panel2(int experimento, int a, int b)
                {
                    List<int> listaPanel2 = new List<int>();
                    for (int i = 0; i < experimento; i++)
                    {
                        Random rand = new Random();
                        int numeroAleatorio2 = rand.Next(a, b + 1);

                        listaPanel2.Add(numeroAleatorio2);
                    }

                    return Panel2;
                }
                public List<Satelite> Panel3(int experimento, int a, int b)
                {
                    List<int> listaPanel3 = new List<int>();
                    for (int i = 0; i < experimento; i++)
                    {
                        Random rand = new Random();
                        int numeroAleatorio3 = rand.Next(a, b + 1);

                        listaPanel3.Add(numeroAleatorio3);
                    }

                    return Panel3;
                }
                public List<Satelite> Panel4(int experimento, int a, int b)
                {
                    List<int> listaPanel4 = new List<int>();
                    for (int i = 0; i < experimento; i++)
                    {
                        Random rand = new Random();
                        int numeroAleatorio4 = rand.Next(a, b + 1);

                        listaPanel4.Add(numeroAleatorio4);
                    }

                    return Panel4;
                }
                public List<Satelite> Panel5(int experimento, int a, int b)
                {
                    List<int> listaPanel5 = new List<int>();
                    for (int i = 0; i < experimento; i++)
                    {
                        Random rand = new Random();
                        int numeroAleatorio5 = rand.Next(a, b + 1);

                        listaPanel5.Add(numeroAleatorio5);
                    }

                    return Panel5;
                }
                public List<Satelite> ListaXi(int experimento, List<Satelite> Panel1, List<Satelite> Panel2, List<Satelite> Panel3, List<Satelite> Panel4, List<Satelite> Panel5)
                {
                    List<int> listaXi = new List<int>();
                    for (int i = 0; i < experimento; i++)
                    {
                        int valorLista1 = Panel1[i];
                        int valorLista2 = Panel2[i];
                        int valorLista3 = Panel3[i];
                        int valorLista4 = Panel4[i];
                        int valorLista5 = Panel5[i];

                        List<int> valores = new List<int> { valorLista1, valorLista2, valorLista3, valorLista4, valorLista5 };
                        Random rand = new Random();
                        int valorFinal = valores[rand.Next(valores.Count)];


                        listaXi.Add(valorFinal);
                    }

                    return listaXi;
                }

                public double CalcularMedia(List<Satelite> ListaXi)
                {
                    double media = 0, suma = 0;
                    foreach (Satelite satelite in ListaXi)
                    {
                        suma = suma + satelite.NumPaneles;

                    }
                    if (ListaXi.Count > 0)
                    {
                        media = suma / ListaXi.Count;
                    }

                    return media;
                }

        */
    }
}

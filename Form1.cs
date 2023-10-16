using Montecarlo.Modelos;
using Montecarlo.Montecarlo;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Montecarlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            // Condición de vacío
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show(" Los numeros tiene que ser no vacíos");
                return;
            }

            int paneles = Convert.ToInt32(textBox1.Text);
            int experimentos = Convert.ToInt32(textBox2.Text);
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);

            // Condición :  Paneles y experimento mayor que cero
            //if (paneles > 5)
            //{
            //  MessageBox.Show("Paneles debe ser mayor que 5");
            //return;
            // }
            if (paneles <= 0 || experimentos <= 0)
            {
                MessageBox.Show("Los números deben ser mayor que cero");
                return;
            }

            // Condición a y b
            if (a < 1000 || a > 5000)
            {
                MessageBox.Show("Los valores de a deben estar entre 1000 y 5000");
                return;
            }

            if (b < 1000 || b > 5000)
            {
                MessageBox.Show("Los valores de b deben estar entre 1000 y 5000");
                return;
            }

            Algoritmo algoritmo = new Algoritmo();
            //List<Satelite> listaValores = algoritmo.GenerarLista(paneles, experimentos, a, b);
            List<Satelite> ListaValores = algoritmo.GenerarLista(paneles, experimentos, a, b);

            llenarGrid1(ListaValores, paneles, experimentos);

        }


        public void llenarGrid1(List<Satelite> lista, int paneles, int experimentos)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";
            string numeroColumna6 = "6";
            string numeroColumna7 = "7";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Experimento");
            dataGridView1.Columns.Add(numeroColumna2, "Panel1");
            dataGridView1.Columns.Add(numeroColumna3, "Panel2");
            dataGridView1.Columns.Add(numeroColumna4, "Panel3");
            dataGridView1.Columns.Add(numeroColumna5, "Panel4");
            dataGridView1.Columns.Add(numeroColumna6, "Panel5");
            dataGridView1.Columns.Add(numeroColumna7, "X(i)");

            dataGridView1.Rows.Clear();

            for (int i = 0; i < experimentos; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString(); // Experimento
              
                for (int j = 0; j < paneles; j++)
                {
                    dataGridView1.Rows[i].Cells[j+1].Value = lista[i].ListaValores[j].ToString(); // Panel
                    //dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                    //dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
                }
                dataGridView1.Rows[i].Cells[6].Value = lista[i].Xi.ToString(); // X(i)

            }
        }
        
    }

}

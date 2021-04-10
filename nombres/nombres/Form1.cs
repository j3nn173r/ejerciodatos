using nombres.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nombres
{
    public partial class name1resultado : Form
    {
        private string[] ArregloNotas;
        public name1resultado()
        {
            InitializeComponent();
        }




        private void buttonCargarArchivos_Click(object sender, EventArgs e)
        {
            CLSArchivos ar = new CLSArchivos();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "seleciona tu archivo plano porfavor";
            ofd.InitialDirectory = @"C:\Users\HP-PC\Documents\documento plano";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeertodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBox1.Text = resultado;

            }
        }


        private void buttonArreglosss_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 9;
            arreglo[2] = 15;
            arreglo[3] = 16;
            arreglo[4] = 5;

            clsarreglos objetcarreglo = new clsarreglos(arreglo);
            int[] resultado = objetcarreglo.MetodoBurbuja();

            foreach (int r in resultado)
            {
                listBoxResultado.Items.Add(r);
            }
        }

        private void button2PROMEDIO_Click(object sender, EventArgs e)
        {
            int evaluacion1;
            int evaluacion2;
            int evaluacion3;
            int sumas;

            foreach (string nom in ArregloNotas)
            {
                string[] unitario = nom.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                evaluacion1 = Convert.ToInt32(nom[2]);
                evaluacion2 = Convert.ToInt32(nom[3]);
                evaluacion3 = Convert.ToInt32(nom[4]);
                sumas = (evaluacion1 + evaluacion2 + evaluacion3) / 3;

                listBoxResultado.Items.Add($"{unitario[1]});el promedio es {sumas}");

            }
        }

        private void button2general_Click(object sender, EventArgs e)
        {
            int evaluacion1;
            int evaluacion2;
            int evaluacion3;
            int suma1 = 0;
            int suma2 = 0;
            int suma3 = 0;
            int gen1 = 0;
            int gen2 = 0;
            int gen3 = 0;

            foreach (string nom in ArregloNotas)
            {
                string[] unitario = nom.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                evaluacion1 = Convert.ToInt32(nom[2]);
                evaluacion2 = Convert.ToInt32(nom[3]);
                evaluacion3 = Convert.ToInt32(nom[4]);
                suma1 += evaluacion1;
                suma2 += evaluacion2;
                suma3 += evaluacion3;

            }
            gen1 = suma1 / 60;
            gen2 = suma2 / 60;
            gen2 = suma3 / 60;

            listBoxResultado.Items.Add($"el promedio es:{gen1} del primer parcial   el promedio es:{gen2} del segundo parcial  el promedio es:{gen3} del tercer parcial");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int evaluacion1;
            int evaluacion2;
            int evaluacion3;
            int sumas;
            int mayor = 0;
            int menor = 20;

            foreach (string nom in ArregloNotas)
            {
                string[] unitario = nom.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                evaluacion1 = Convert.ToInt32(nom[2]);
                evaluacion2 = Convert.ToInt32(nom[3]);
                evaluacion3 = Convert.ToInt32(nom[4]);
                sumas = (evaluacion1 + evaluacion2 + evaluacion3) / 3;

                if (sumas != 0)
                {
                    if (sumas > mayor)
                    {
                        mayor = sumas;
                    }
                    if (sumas < menor)
                    {
                        menor = sumas;
                    }

                }
                else
                {
                    mayor = sumas;
                    menor = sumas;
                }


            }
            listBoxResultado.Items.Add($"el promedio mayor es:{mayor}); el  promedio menor es:{menor} ");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}













using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginunisur2
{
    public partial class Form1 : Form
    {
        int intentos = 0;
        int totales = 3;
        string nombre = "zazil";
        string contra = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e);
        

          switch 
                {case 1: 
                
                tbuser.Text != nombre && this.tbcontrasena.Text != contra;
                totales = +1;
                aviso.Text = "Te quedan" + Convert.ToString{totales - intentos } "oportunidades para ingresar";

                if (totales => 3)
                {
                messageBox.Show("Te has quedado sin oportunidad para ingresar");
                pictureBox1.Image = new Bitmap(@"C:\Users\Zazil Laptop\Downloads\cerradura2.png");
    tbentrar.enable = false;
                }

                case 2: 
                
                tbuser.Text == "zazil" && this.tbcontrasena.Text == "12345";
                pictureBox1.Image = new Bitmap(@"C:\Users\Zazil Laptop\Downloads\cerradura.png");
                MessageBox.Show("Bienvenido");
                }







            /*string usuario = tbuser.Text;
            string password = tbcontrasena.Text;
            if(this.tbuser.Text == "Pancho" && this.tbcontrasena.Text == "Barco100")
            {
                intentos = 0;
                //si coincide usuario y contraseña ya no se necesitan los intentos
                pictureBox1.Image = new Bitmap(@"C:\Users\Zazil Laptop\Downloads\cerradura.png");
                MessageBox.Show("Bienvenido");
            }
            /*else if (intentos > 0 && intentos <= 3)
            {
                //avisar cuántos intentos le quedan; al tercer intento bloquear botón
                aviso.Text = "Solo tienes" + Convert.ToString(intentos)+ "intentos más";
                //intentos--;
            }*/
            /*else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
             }*/

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {

        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

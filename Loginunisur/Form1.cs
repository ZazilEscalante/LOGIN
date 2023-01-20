using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginunisur
{
    public partial class Form1 : Form
    {
                int intento = 0;
                int total = 3;
                string usuario = "zazil";
                string contra = "7410";

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.cerradura2;
        }

        
        private void login_Click(object sender, EventArgs e)
        {

            {
                if (tbuser.Text == usuario & tbcontrasena.Text == contra)
                {
                    MessageBox.Show("Bienvenido");
                    pictureBox1.Image = Properties.Resources.cerradura;
                    //pictureBox1.Image = (@"C:\Users\Zazil Laptop\Downloads\cerradura.png)";
                   
                }
                else

                {
                    intento = intento + 1;


                    if (intento >= 3)
                    { 
                        login.Enabled = false;
                    
                        MessageBox.Show("Demasiados intentos fallidos");

                        aviso.Text = "El programa se ha bloqueado";
                        pictureBox1.Image = Properties.Resources.cerradura2;                     }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña Incorrectas. Intenta otra vez; tienes " + (total - intento) + " intentos.");

                    }

                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

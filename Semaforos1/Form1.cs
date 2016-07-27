using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Semaforos1
{
    public partial class Form1 : Form
    {
        int x;
        public Form1()
        {
            InitializeComponent();
            x = 0;

            Rojo1OvalShape.BackColor = Color.Red;
            Rojo2OvalShape.BackColor = Color.Red;
            Rojo3OvalShape.BackColor = Color.Red;

            Amarillo1OvalShape.BackColor = Color.Gray;
            Amarillo2OvalShape.BackColor = Color.Gray;
            Amarillo3OvalShape.BackColor = Color.Gray;

            Verde1OvalShape.BackColor = Color.Gray;
            Verde2OvalShape.BackColor = Color.Gray;
            Verde3OvalShape.BackColor = Color.Gray;
            Verde2DOvalShape.BackColor = Color.Gray;

        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {

                
                if (x == 1)
                {
                    Verde1OvalShape.BackColor = Color.Lime;
                    Rojo1OvalShape.BackColor = Color.Gray;
                    Amarillo1OvalShape.BackColor = Color.Gray;
                    Rojo2OvalShape.BackColor = Color.Gray;
                    Verde2OvalShape.BackColor = Color.Lime;
                    Verde2DOvalShape.BackColor = Color.Gray;
                    Rojo3OvalShape.BackColor = Color.Red;
                    Verde3OvalShape.BackColor = Color.Gray;
                    Amarillo3OvalShape.BackColor = Color.Gray;
                    Thread.Sleep(1000);
                }

                if (x == 2)
                {
                    Verde1OvalShape.BackColor = Color.Gray;
                    Rojo1OvalShape.BackColor = Color.Gray;
                    Amarillo1OvalShape.BackColor = Color.Gold;
                    Rojo1OvalShape.BackColor = Color.Gray;
                    Verde2OvalShape.BackColor = Color.Lime;
                    Verde2DOvalShape.BackColor = Color.Gray;
                    Rojo3OvalShape.BackColor = Color.Red;
                    Verde3OvalShape.BackColor = Color.Gray;
                    
                }

                if (x == 3)
                {
                    Verde1OvalShape.BackColor = Color.Gray;
                    Amarillo1OvalShape.BackColor = Color.Gray;
                    Rojo1OvalShape.BackColor = Color.Red;
                    Rojo3OvalShape.BackColor = Color.Red;
                    Verde2DOvalShape.BackColor = Color.Gray;
                    Verde2OvalShape.BackColor = Color.Gray;
                    Rojo2OvalShape.BackColor = Color.Gray;
                    Amarillo2OvalShape.BackColor = Color.Gold;
                    
                }


                if (x == 4)
                {
                    Rojo2OvalShape.BackColor = Color.Red;
                    Amarillo2OvalShape.BackColor = Color.Gray;
                    Verde2DOvalShape.BackColor = Color.Lime;


                }


                if (x == 5)
                {
                    Verde1OvalShape.BackColor = Color.Gray;
                    Amarillo1OvalShape.BackColor = Color.Gray;
                    Rojo1OvalShape.BackColor = Color.Red;
                    Rojo3OvalShape.BackColor = Color.Gray;
                    Verde2DOvalShape.BackColor = Color.Gray;
                    Verde2OvalShape.BackColor = Color.Gray;
                    Rojo2OvalShape.BackColor = Color.Red;
                    Verde3OvalShape.BackColor = Color.Lime;

                }


                if (x == 6)
                {
                    Amarillo3OvalShape.BackColor = Color.Gold;
                    Verde3OvalShape.BackColor = Color.Gray;
                    x = 0;

                }


                x++;
                
            }

        }

        private void Rojo1OvalShape_Click(object sender, EventArgs e)
        {
            Rojo1OvalShape.BackColor = Color.Red;
        }

        private void Rojo2OvalShape_Click(object sender, EventArgs e)
        {
            Rojo2OvalShape.BackColor = Color.Red;
        }

        private void Rojo3OvalShape_Click(object sender, EventArgs e)
        {
            Rojo3OvalShape.BackColor = Color.Red;
        }

        private void Amarillo1OvalShape_Click(object sender, EventArgs e)
        {
            Amarillo1OvalShape.BackColor = Color.Gold;
        }

        private void Amarillo2OvalShape_Click(object sender, EventArgs e)
        {
            Amarillo2OvalShape.BackColor = Color.Gold;
        }

        private void Amarillo3OvalShape_Click(object sender, EventArgs e)
        {
            Amarillo3OvalShape.BackColor = Color.Gold;
        }

        private void Verde1OvalShape_Click(object sender, EventArgs e)
        {
            Verde1OvalShape.BackColor = Color.Gray;
        }

        private void Verde2OvalShape_Click(object sender, EventArgs e)
        {
            Verde2OvalShape.BackColor = Color.Gray;
        }

        private void Verde2DOvalShape_Click(object sender, EventArgs e)
        {
            Verde2DOvalShape.BackColor = Color.Gray;
        }

        private void Verde3OvalShape_Click(object sender, EventArgs e)
        {
            Verde3OvalShape.BackColor = Color.Gray;
        }
    }
}

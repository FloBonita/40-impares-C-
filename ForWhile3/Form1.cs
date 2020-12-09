using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForWhile3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            int i;
            for (i=1; i <=40; i++)
            {
               if (i % 2 != 0)
                {
                    lstShow.Items.Add(i);
                }               
            }
            
            
            //Faça um programa que calcule e imprima os 40 primeiros números ímpares maiores que zero.

        }
    }
}

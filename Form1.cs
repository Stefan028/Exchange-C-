using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menjacnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        double kes;
        double eur;
        double usd;
        double rub; 
        double chf;
        double gbp;
        double jpy;
        double aud;
        double cad;
        double egp;

        private void kurs()
        {
            StreamReader citaj = new StreamReader("kursevi.txt");
            eur = Convert.ToDouble(citaj.ReadLine());
            usd = Convert.ToDouble(citaj.ReadLine());
            rub = Convert.ToDouble(citaj.ReadLine());
            chf = Convert.ToDouble(citaj.ReadLine());
            gbp = Convert.ToDouble(citaj.ReadLine());
            jpy = Convert.ToDouble(citaj.ReadLine());
            aud = Convert.ToDouble(citaj.ReadLine());
            cad = Convert.ToDouble(citaj.ReadLine());
            egp = Convert.ToDouble(citaj.ReadLine());
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            kurs();
            labelKurs.Text = "1.  1 EUR = "+ eur+"RSD\n2.  1 USD ="+usd+ "RSD";
            labelKurs.Text += "\n3.  1 RUB = "+rub+"RSD\n4.  1 CHF = "+chf+ "RSD";
            labelKurs.Text += "\n5.  1 GBP = "+gbp+" RSD\n6.  1 JPY = "+jpy+"RSD";
            labelKurs.Text += "\n7.  1 AUD ="+aud+" RSD\n8.  1CAD = "+cad+ "RSD";
            labelKurs.Text += "\n9.  1 EGP = "+egp+ "RSD";
        }

        private void buttonPrebaci_Click(object sender, EventArgs e)
        {
            kes = double.Parse(txtUnos.Text);
            

            if(radioEur.Checked )
            {
                double kes1 = kes;
                kes *= eur;
                MessageBox.Show("Vasih " + kes1 + " EUR iznose " + kes + " RSD");
            }

            if(radioUsd.Checked )
            {
                double kes1 = kes;
                kes *= usd;
                MessageBox.Show("Vasih " + kes1 + " USD iznose " + kes + " RSD");
            }

            if(radioRub.Checked)
            {
                double kes1 = kes;
                kes *= rub;
                MessageBox.Show("Vasih " + kes1 + " RUB iznose " + kes + " RSD");
            }

            if(radioChf.Checked )
            {
                double kes1 = kes;
                kes *= chf;
                MessageBox.Show("Vasih " + kes1 + " CHF iznose " + kes + " RSD");
            }

            if(radioGbp.Checked )
            {
                double kes1 = kes;
                kes *= gbp;
                MessageBox.Show("Vasih " + kes1 + " GBP iznose " + kes + " RSD");
            }

            if(radioJpy.Checked )
            {
                double kes1 = kes;
                kes *= jpy;
                MessageBox.Show("Vasih " + kes1 + " JPY iznose " + kes + "  RSD");
            }

            if(radioAud.Checked )
            {
                double kes1 = kes;
                kes *= aud;
                MessageBox.Show("Vasih " + kes1 + " AUD iznose " + kes + "  RSD");
            }

            if(radioCad.Checked )
            {
                double kes1 = kes;
                kes *= cad;
                MessageBox.Show("Vasih " + kes1 + " CAD iznose " + kes + "  RSD");
            }

            if(radioEgp.Checked )
            {
                double kes1 = kes;
                kes *= egp;
                MessageBox.Show("Vasih " + kes1 + " EGP iznose " + kes + "  RSD");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUnos.Text = "";
            radioAud.Checked = false;
            radioCad.Checked = false;
            radioEgp.Checked = false;
            radioEur.Checked = false;
            radioChf.Checked = false;
            radioGbp.Checked = false;
            radioUsd.Checked = false;
            radioRub.Checked = false;
            radioJpy.Checked = false;

            
        }
    }
}

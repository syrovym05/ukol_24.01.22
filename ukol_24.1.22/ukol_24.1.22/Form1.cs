using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_24._1._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            { label1.Text = ""; label2.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = ""; label6.Text = ""; }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cislo, prumer = 0,soucet = 0, minimum = double.MaxValue, prvni = 0, posledni=0;
            int pocet_vintervalu = 0;
            double pocet = 0;
            try
            {
                
                for (int i = 0 ; i < textBox1.Lines.Count(); i++)
                {
                   
                    if (textBox1.Lines[i] != "")
                    {
                        cislo = Convert.ToDouble(textBox1.Lines[i]);
                        prumer += cislo;
                        if (minimum > cislo) minimum = cislo;
                        if (cislo >= 5 && cislo < 30) pocet_vintervalu++;
                        if (cislo == 3 && prvni == 0) prvni = i + 1;
                        if (cislo == 3) posledni = i + 1;
                        pocet = i + 1;
                    }
                    
                }

                foreach (string j in textBox1.Lines) if(j != "") soucet += double.Parse(j);

                label1.Text = pocet != 0 ? "Průměr čísel: " + Math.Round(prumer / pocet, 3) : "------";
                label2.Text = minimum != double.MaxValue ? "Minimum: " + minimum : "------";
                label3.Text = "Počet čísel v intervalu <5;30) je: " + pocet_vintervalu;
                label4.Text = prvni == 0 ? "------": "První pozice č.3 je: " + prvni;
                label5.Text = posledni == 0 ? "------" : "Posledni pozice č.3 je: " + posledni;
                label6.Text = "Součet všech čísel: " + soucet;

            }
            catch(Exception)
            {
                MessageBox.Show("Chyba v zadávání", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V komponentě TextBox – víceřádkové je několik čísel. Pomocí cyklu for - spočítejte průměr čísel, vypište minimální číslo, počet čísel v intervalu < 5, 30), pozice první a poslední 3.Pomocí cyklu foreach spočítejte součet všech čísel v textBoxu.\nMezery se nenačítají", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

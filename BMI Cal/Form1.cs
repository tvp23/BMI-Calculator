using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMI_Sum;
using Adviesfinale;
using Empty_check;

namespace BMI_Cal
{
    public partial class Form1 : Form
    {
        private double kgv, lenv, output, outputad, lenv2, sum, lenvm, Leeftijd;
        private bool Vrouw, Empty;
        private string Result, txtstate1, txtstate2, txtstate3, txtnullloc, txtnull;
        
        public Form1()
        {
            InitializeComponent();
            //Clears text
            txtBMI.Text = null;
            rtxtAdvies.Text = null;
            lbllenVerplicht.Text = "";
            lblkgVerplicht.Text = "";
            lbllefVerplicht.Text = "";
        }


        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            //Resets form
            txtbLengte.BackColor = Color.White;
            txtbGewicht.BackColor = Color.White;
            txtbLeeftijd.BackColor = Color.White;
            lbllenVerplicht.Text = "";
            lblkgVerplicht.Text = "";
            lbllefVerplicht.Text = "";

            //Checks legen textboxen
            txtstate1 = txtbLengte.Text;
            txtstate2 = txtbGewicht.Text;
            txtstate3 = txtbLeeftijd.Text;
            
            //Color text box if empty
            if (txtbLengte.Text == "")
            {
                txtbLengte.BackColor = Color.Red;
                lbllenVerplicht.Text = "Verplicht";
            }
            if (txtbGewicht.Text == "")
            {
                txtbGewicht.BackColor = Color.Red;
                lblkgVerplicht.Text = "Verplicht";
            }
            if (txtbLeeftijd.Text == "")
            {
                txtbLeeftijd.BackColor = Color.Red;
                lbllefVerplicht.Text = "Verplicht";
            }

            //Checks legen textboxen 2
            Empty_check.Class1 class1 = new Empty_check.Class1();
            if (txtnullloc == class1.Emptycheck(txtstate1, txtstate2, txtstate3, txtnull))
            {
                //minimalen leeftijd
                Leeftijd = Convert.ToDouble(txtbLeeftijd.Text);
                if (Leeftijd >= 18)
                {
                    //BMI calculator
                    kgv = Convert.ToDouble(txtbGewicht.Text);
                    lenv = Convert.ToDouble(txtbLengte.Text);

                    //Advies
                    if (radbtnVrouw.Checked == true)
                    {
                        Vrouw = true;
                        BMI_Sum.Class1 class2 = new BMI_Sum.Class1();
                        outputad = (class2.Sum(kgv, lenvm, lenv, lenv2, output, sum));
                        BMI_Sum.Class1 class3 = new BMI_Sum.Class1();
                        txtBMI.Text = (class3.Sum(kgv, lenvm, lenv, lenv2, output, sum).ToString());
                        Adviesfinale.Class1 class4 = new Adviesfinale.Class1();
                        rtxtAdvies.Text = class4.Advies(outputad, Result, Vrouw);
                    }

                    else
                    {
                        BMI_Sum.Class1 class2 = new BMI_Sum.Class1();
                        outputad = (class2.Sum(kgv, lenvm, lenv, lenv2, output, sum));
                        BMI_Sum.Class1 class3 = new BMI_Sum.Class1();
                        txtBMI.Text = (class3.Sum(kgv, lenvm, lenv, lenv2, output, sum).ToString());
                        Adviesfinale.Class1 class4 = new Adviesfinale.Class1();
                        rtxtAdvies.Text = class4.Advies(outputad, Result, Vrouw);
                    }
                }

                //Minimalen leeftijd
                else
                {
                    rtxtAdvies.Text = "U moet minimaal 18 jaar zijn om de BMI calculator te gebruiken.";
                }
            }
        }
    }
}

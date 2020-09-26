using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adviesfinale
{
    public class Class1
    {
        public string Advies(double outputad, string Result = "", bool Vrouw = false)
        {
            //Het Advies
            string Ondergewicht = "U heeft ondergewicht. Voor iemand met ondergewicht is het verstandig niet verder af te vallen en proberen om aan te komen.";
            string NormaalGewicht = "Uw gewicht is Perfect.";
            string Overgewicht = "U heeft overgewicht. Bij overgewicht is het belangrijk om op een gezonde manier af te vallen: gezond eten en genoeg bewegen. U hebt de meeste kans op succes als u een dieet kiest dat lijkt op de gewone gezonde voeding.";
            string Obesitas = "U heeft obesitas. Kom in aanraking met een expert en overleg hoe u kan afvallen.";

            //Advies op BMI checken
            
            if (Vrouw == true)
            {
                if (outputad < 18.6)
                {
                    string Advies = Ondergewicht;
                    Result = Advies;
                }

                else if (outputad < 23.8)
                {
                    string Advies = NormaalGewicht;
                    Result = Advies;
                }

                else if (outputad < 28.5)
                {
                    string Advies = Overgewicht;
                    Result = Advies;
                }

                else if (outputad > 28.5)
                {
                    string Advies = Obesitas;
                    Result = Advies;
                }
            }

            else
            {
                if (outputad < 20)
                {
                    string Advies = Ondergewicht;
                    Result = Advies;
                }

                else if (outputad < 25)
                {
                    string Advies = NormaalGewicht;
                    Result = Advies;
                }

                else if (outputad < 30)
                {
                    string Advies = Overgewicht;
                    Result = Advies;
                }

                else if (outputad > 30)
                {
                    string Advies = Obesitas;
                    Result = Advies;
                }
            }
            return Result;
        }
    }
}
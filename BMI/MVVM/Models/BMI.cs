using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        private double result;

        public double Height { get; set; }
        public double Weight { get; set; }

        public double Result
        {
            get
            {
                result = Math.Round(((Weight / Height) / Height) * 10000, 2);
                return result;
            }
        }

        public string Message
        {
            get
            {
                string template = "Your BMI is #. ";
                if (Result < 18.5)
                {
                    return template.Replace("#", Result.ToString()) + "Underweight";
                }
                else if (Result >= 18.5 && Result < 25)
                {
                    return template.Replace("#", Result.ToString()) + "Normal";
                }
                else if (Result >= 25 && Result < 30)
                {
                    return template.Replace("#", Result.ToString()) + "Overweight";
                }
                else if (Result >= 30 && Result < 35)
                {
                    return template.Replace("#", Result.ToString()) + "Obese";
                }
                else if (Result >= 35 && Result < 39.9)
                {
                    return template.Replace("#", Result.ToString()) + "Obese Class II";
                }
                else
                {
                    return template.Replace("#", Result.ToString()) + "Obese Class III";
                }
            }
        }
    }
}
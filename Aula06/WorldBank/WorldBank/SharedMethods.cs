using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    class SharedMethods
    {
        public int Age(DateTime birth)
        {
            DateTime thisDay = DateTime.Today;
            return Convert.ToInt32(thisDay.Subtract(birth));
        }
        public string AgeRange (int age)
        {
            if (age <= 11) { return "criança"; }
            else    {   if (age <= 21) { return "jovem"; }
                    else    {   if (age <= 59)  { return "adulto"; }
                                else            { return "idoso"; }
                            }
                    }
        }
    }
}

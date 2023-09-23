
using System.Globalization;


namespace TaxPayment.Entities {
    internal class Company : Tax {

        public int NumberOfEmployer { get; set; } 

        public Company(string name, double income, int numb):base (name, income) {
        
            NumberOfEmployer = numb;
        }


        public override double TaxPayment() { 
        
            if (NumberOfEmployer > 10) {

                return AnualIncome * 0.14;


            
            }
            else {
                return AnualIncome * 0.16;
            }
        
        }
        public override string ToString() {
            return Name + " __ " + TaxPayment().ToString("F2" ,CultureInfo.InvariantCulture);
        }

    }
}

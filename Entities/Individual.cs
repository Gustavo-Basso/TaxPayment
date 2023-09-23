
using System.Globalization;

namespace TaxPayment.Entities {
    internal class Individual : Tax {

        public double HealthExpenditures { get; set; }

        public Individual(string name, double income, double health) : base(name, income) {

            HealthExpenditures = health;

        }

        public override double TaxPayment() {
            if (HealthExpenditures > 0) {
                if (AnualIncome > 20000) {
                    double x = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
                    return x;

                }
                else if (AnualIncome < 20000) {
                    double x = (AnualIncome * 0.2) - HealthExpenditures / 2;
                    return x;
                }
                else { return AnualIncome; }

           
            }
            else {
                if (AnualIncome < 20000) {
                    double x = AnualIncome - (AnualIncome * 0.2);
                    return x;
                }
                else {
                    double x = AnualIncome - (AnualIncome * 0.25);
                    return x;

                }
            }
            
            

        }
        public override string ToString() {
            return Name + " __ " + TaxPayment().ToString("F2", CultureInfo.InvariantCulture );
        
        }
        
    }

}

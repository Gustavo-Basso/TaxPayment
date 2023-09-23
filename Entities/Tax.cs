

namespace TaxPayment.Entities {
    
     abstract class Tax {

        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public Tax(string name, double income) { 
            
            Name = name;
            AnualIncome = income;
        }

        public abstract double TaxPayment();
    }
}

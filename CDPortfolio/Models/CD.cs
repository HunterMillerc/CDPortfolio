using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDPortfolio.Models
{
    public class CD 
    {
        public string Bank { get; set; }
        public int Term { get; set; }
        public double Rate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal DepositAmt { get; set; }
        public static int nextId;
        public int Id { get; set; }

        

    }

}

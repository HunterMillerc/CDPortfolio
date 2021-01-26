using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CDPortfolio.Models
{
    public class CD 
    {
        [Required(ErrorMessage = "Please select a bank")]
        public string Bank { get; set; }

        [Required(ErrorMessage = "Please select a term")]
        public int? Term { get; set; }

        [Required(ErrorMessage = "Please input a rate")]
        public double? Rate { get; set; }

        [Required(ErrorMessage = "Please input a deposit amount")]
        public decimal? DepositAmt { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Please select a valid purchase date")]
        [Required(ErrorMessage = "Please select a valid purchase date")]
        public DateTime? PurchaseDate { get; set; }

        public static int nextId;
        public int Id { get; set; }

        public DateTime GetPurchaseDate()
        {
            return (DateTime)PurchaseDate;
        }

        public DateTime GetMatureDate()
        {
            DateTime pDate = (DateTime)PurchaseDate;
            return pDate.AddMonths(Term ?? 0);
        }

        public decimal GetMatureValue()
        {
            return (decimal)(((double)DepositAmt) * Math.Pow((1 + (((Rate ?? 0) / 100) / 365)), (((Term ?? 0) / 12) * 365)));
        }
    }

}

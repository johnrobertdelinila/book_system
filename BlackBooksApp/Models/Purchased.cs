using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Purchased
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Display(Name = "Buyer")]
        public int PurchaseId { get; set; }

        [Display(Name = "ISBN Books")]
        public int BookId { get; set; }

        [Display(Name = "Order price")]
        public int OrderPrice { get; set; }

        [Display(Name = "Quantity")]
        public int Number { get; set; }

        [Display(Name = "Total")]
        public int Total
        {
            get
            {
                return OrderPrice * Number;
            }
        }

        public virtual Purchase Purchase { get; set; }
        public virtual Book Book { get; set; }
    }
}
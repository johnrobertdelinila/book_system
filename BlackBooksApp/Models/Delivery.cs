using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Delivery
    {
        /// <summary>Возвращает идентификатор Delivery Services.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает Name Delivery Services.</summary>
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>Возвращает Telephone Delivery Services.</summary>
        [Display(Name = "Telephone")]
        public string Phone { get; set; }

        /// <summary>Возвращает Price Delivery.</summary>
        [Display(Name = "Price Delivery")]
        public int Cost { get; set; }

        [Display(Name = "Orders для данной Delivery Services")]
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Purchase
    {
        /// <summary>Возвращает идентификатор Order.</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        /// <summary>Возвращает идентификатор Employee.</summary>
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }

        /// <summary>Возвращает идентификатор Client.</summary>
        [Display(Name = "Client")]
        public int ClientId { get; set; }

        /// <summary>Возвращает идентификатор Delivery Services.</summary>
        [Display(Name = "Delivery Service")]
        public int DeliveryId { get; set; }

        /// <summary>Возвращает дату Order.</summary>
        [Display(Name = "Order Date")]
        public string Ordate { get; set; }

        /// <summary>Возвращает Address Delivery.</summary>
        [Display(Name = "Address Delivery")]
        public string Address { get; set; }

        /// <summary>Возвращает Price Delivery.</summary>
        [Display(Name = "Price Delivery")]
        public int Delcost { get; set; }

        /// <summary>Возвращает дату продажи.</summary>
        [Display(Name = "Date of Sale")]
        public string Saledate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Client Client { get; set; }
        public virtual Delivery Delivery { get; set; }

        [Display(Name = "Ordered Books")]
        public virtual ICollection<Purchased> PurchasedBooks { get; set; }
    }
}
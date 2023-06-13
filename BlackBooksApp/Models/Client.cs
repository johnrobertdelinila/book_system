using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Client
    {
        /// <summary>Возвращает или задет идентификатор Client.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает или задает Full name или Name организации.</summary>
        [Display(Name = "Full name")]
        public string Name { get; set; }

        /// <summary>Возвращает или задает дату рождения Client.</summary>
        [Display(Name = "Date of Birth")]
        public string Birthday { get; set; }

        /// <summary>Возвращает или задает Address Client.</summary>
        [Display(Name = "Address")]
        public string Address { get; set; }

        /// <summary>Возвращает или задает Telephone Client.</summary>
        [Display(Name = "Telephone")]
        public string Phone { get; set; }

        [Display(Name = "Orders от by this Client")]
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
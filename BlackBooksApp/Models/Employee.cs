using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Employee
    {
        /// <summary>Возвращает или задает идентификатор Employeeа.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает или задает Full name Employeeа.</summary>
        [Display(Name = "Full name")]
        public string Name { get; set; }

        /// <summary>Возвращает или задает дату рождения Employeeа.</summary>
        [Display(Name = "Date of Birth")]
        public string Birthday { get; set; }

        /// <summary>Возвращает или задает Address.</summary>
        [Display(Name = "Address")]
        public string Address { get; set; }

        /// <summary>Возвращает или задает Telephone.</summary>
        [Display(Name = "Telephone")]
        public string Phone { get; set; }

        /// <summary>Возвращает или задает Job title.</summary>
        [Display(Name = "Job title")]
        public string Position { get; set; }

        [Display(Name = "Orders данного Employeeа")]
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
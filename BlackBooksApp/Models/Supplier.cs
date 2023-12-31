﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Supplier
    {
        /// <summary>Возвращает идентификатор Provider.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает имя Provider.</summary>
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>Возвращает Contact Face компании.</summary>
        [Display(Name = "Contact Face")]
        public string ContactPerson { get; set; }

        /// <summary>Возвращает Job title контактного лица компании.</summary>
        [Display(Name = "Job title")]
        public string Position { get; set; }

        /// <summary>Возвращает Legal Address Provider.</summary>
        [Display(Name = "Legal Address")]
        public string Address { get; set; }

        /// <summary>Возвращает Telephone Provider.</summary>
        [Display(Name = "Telephone")]
        public string Phone { get; set; }

        /// <summary>Возвращает дополнительные сведения о Providerе.</summary>
        [Display(Name = "About company")]
        public string AboutCompany { get; set; }

        [Display(Name = "Books от by this Provider")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
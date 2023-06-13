using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class PublishingHouse
    {
        /// <summary>Возвращает идентификатор Publishers.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает Name Publishers.</summary>
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>Возвращает Address Publishers.</summary>
        [Display(Name = "Address")]
        public string Address { get; set; }

        /// <summary>Возвращает Telephone Publishers.</summary>
        [Display(Name = "Telephone")]
        public string Phone { get; set; }

        [Display(Name = "Books by this Publishers")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
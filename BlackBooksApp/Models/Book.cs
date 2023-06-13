using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBooksApp.Models
{
    public class Book
    {
        /// <summary>Возвращает идентификатор Books.</summary>
        public int Id { get; set; }

        /// <summary>Возвращает идентификатор Publishers.</summary>
        [Display(Name = "Publishing house")]
        public int PublishingHouseId { get; set; }

        /// <summary>Возвращает идентификатор Provider.</summary>
        [Display(Name = "Provider")]
        public int SupplierId { get; set; }

        /// <summary>Возвращает ISBN Books.</summary>
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        /// <summary>Возвращает Name Books.</summary>
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>Возвращает Authorа Books.</summary>
        [Display(Name = "Author")]
        public string Author { get; set; }

        /// <summary>Возвращает тип Books.</summary>
        [Display(Name = "Genre Category")]
        public int TypeId { get; set; }

        /// <summary>Возвращает Genre Books.</summary>
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        /// <summary>Возвращает The year of publishing Books.</summary>
        [Display(Name = "The year of publishing")]
        public int PublishingYear { get; set; }

        /// <summary>Возвращает Quantity of pages.</summary>
        [Display(Name = "Quantity of pages")]
        public int Pages { get; set; }

        /// <summary>Возвращает Cover type Books.</summary>
        [Display(Name = "Cover type")]
        public string CoverType { get; set; }

        /// <summary>Возвращает цену Books.</summary>
        [Display(Name = "Price Books")]
        public int BookPrice { get; set; }

        /// <summary>Возвращает дату поставки.</summary>
        [Display(Name = "Date of delivery")]
        public string SupplyDate { get; set; }

        /// <summary>Возвращает Remainder.</summary>
        [Display(Name = "Remainder")]
        public int Rest { get; set; }

        public virtual PublishingHouse PublishingHouse { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<Purchased> PurchasedBooks { get; set; }
    }
}
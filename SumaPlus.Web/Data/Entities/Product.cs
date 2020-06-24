using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SumaPlus.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        //[Display(Name = "Supplier Type")]
        //[MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //[Required(ErrorMessage = "The field {0} is mandatory.")]
        //public string SupplierType { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Race { get; set; }

      
        [Display(Name = "Born")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        public string Remarks { get; set; }

       
        //TODO: replace the correct URL for the image
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://www.lenovo.com/medias/lenovo-laptop-thinkpad-x1-extreme-2nd-gen-hero.png?context=bWFzdGVyfHJvb3R8MjYzNTIyfGltYWdlL3BuZ3xoNGIvaGU2LzEwMDQyNDYzNTE4NzUwLnBuZ3xmMDE3MmMzNGFmMWQ2NzU4ZWNjZWM1ZDY4MGRjMmQzZTkwYTE1ZjdjYmM3N2U4NmZlNzg1ZjRlNjZhYzMxN2Vi{ImageUrl.Substring(1)}";

        [Display(Name = "Born*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}" )]
        public DateTime BornLocal => Born.ToLocalTime();

        public ProductType ProductType { get; set; }

        public Supplier Supplier { get; set; }

        public ICollection<History> Histories { get; set; }

        public ICollection<Agenda> Agendas { get; set; }



    }
}

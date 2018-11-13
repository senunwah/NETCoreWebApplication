using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreWebApplication.Models
{
    public class InsertPersonModel
    {
        [Required(ErrorMessage = "You must insert the Name of the Person you are adding")]
        [Display(Name = "Person Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must insert the Age of the Person you are adding")]
        [Display(Name = "Person Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "You must insert the Gender of the Person you are adding")]
        [Display(Name = "Person Gender")]
        public string Gender { get; set; }

    }

    public class InsertShoeModel
    {
        [Required(ErrorMessage = "You must insert the Name of the Shoe you are adding")]
        [Display(Name = "Shoe Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must insert the Size of the Shoe you are adding")]
        [Display(Name = "Shoe Size")]
        public int ShoeSize { get; set; }

        [Required(ErrorMessage = "You must insert the Type of the Shoe you are adding")]
        [Display(Name = "Shoe Type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "You must insert the Make of the Shoe you are adding")]
        [Display(Name = "Shoe Make")]
        public string Make { get; set; }

        [Required(ErrorMessage = "You must insert the Color of the Shoe you are adding")]
        [Display(Name = "Shoe Color")]
        public string Color { get; set; }
    }

    public class BuyShoeModel
    {
        [Required(ErrorMessage = "You must input a Person")]
        [Display(Name = "Person Name")]
        public string PersonName { get; set; }

        [Required(ErrorMessage = "You must input a Shoe")]
        [Display(Name = "Shoe Name")]
        public string ShoeName { get; set; }
    }
}

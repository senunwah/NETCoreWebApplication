using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreWebApplication.Models
{
    public class InsertPersonShoeModel
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

        [Required(ErrorMessage = "You must insert the Name of the Shoe you are adding")]
        [Display(Name = "Shoe Name")]
        public string ShoeName { get; set; }

        [Required(ErrorMessage = "You must insert the Type of the Shoe you are adding")]
        [Display(Name = "Shoe Type")]
        public string ShoeBrand { get; set; }

    }

    public class InsertShoeModel
    {
        
       
    }

    
}

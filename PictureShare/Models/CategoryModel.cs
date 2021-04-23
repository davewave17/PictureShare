using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PictureShare.Models
{
    public class CategoryModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        public string ImagePath { get; set; }
    }
}

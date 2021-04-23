using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PictureShare.Models
{
    public class PictureViewModel
    {
        public PictureModel Picture { get; set; }

        public IEnumerable<SelectListItem> CatList { get; set; }

    }
}

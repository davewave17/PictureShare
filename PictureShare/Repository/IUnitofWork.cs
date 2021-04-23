using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PictureShare.Repository
{
    public interface IUnitofWork
    {
        ICategoryRepository Category { get; }


    }
}

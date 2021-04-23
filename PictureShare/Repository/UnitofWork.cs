using PictureShare.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PictureShare.Repository
{


    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext _db;

        public ICategoryRepository Category { get; set; }

        public UnitofWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(db);
        }

        public void Save()
        {
            _db.SaveChanges();      //change to async version!
        }
    }
}

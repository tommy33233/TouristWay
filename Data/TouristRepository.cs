using ModelInterfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class TouristRepository:IRepository<Tourist>
    {
        private TouristAppContext db;
        public TouristRepository()
        {
            db = new TouristAppContext();
        }

        public IEnumerable<Tourist> GetAll()
        {
            return db.Tourists;
        }

        public Tourist Get(int id)
        {
            return db.Tourists.Find(id);
        }

        public void Create(Tourist tourist)
        {
            db.Tourists.Add(tourist);
        }

        public void Update(Tourist tourist)
        {
            db.Entry(tourist).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Tourist tourist = db.Tourists.Find(id);
            if (tourist != null)
            {
                db.Tourists.Remove(tourist);
            }
        }

     
    }
}

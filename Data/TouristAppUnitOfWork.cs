using CoreInterfaces;
using ModelInterfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class TouristAppUnitOfWork:IUnitOfWork
    {
        private TouristAppContext db;

        private TouristRepository touristRepository;

        public TouristAppUnitOfWork()
        {
            db = new TouristAppContext();
        }

        public IRepository<Tourist> Tourists
        {
            get
            {
                if (touristRepository == null)
                {
                    touristRepository = new TouristRepository();
                }
                return touristRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

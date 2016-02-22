using ModelInterfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreInterfaces
{
   public interface IUnitOfWork
    {
        IRepository<Tourist> Tourists { get; }
        void Save();
    }
}

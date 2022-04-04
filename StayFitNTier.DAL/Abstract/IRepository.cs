using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.Abstract
{
    interface IRepository<T>
    {
        bool Insert(T p);              
        List<T> List();
        T GetById(int id);
    }
}

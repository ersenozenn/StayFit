using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.Abstract
{
    interface IDeleteforAdmin<T>
    {
        bool DeleteforAdmin(T p);
    }
}

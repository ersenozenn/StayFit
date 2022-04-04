using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class GenderService
    {
        GenderRepository genderRepository;
        public GenderService()
        {
            genderRepository = new GenderRepository();                
        }
        /// <summary>
        /// Checks Gender Id
        /// </summary>
        /// <param name="genderId"></param>
        void CheckGenderId(int genderId)
        {
            if (genderId <= 0) throw new Exception("Parameter value is not suitable!");
        }
        /// <summary>
        /// Gets specific gender with Id.
        /// </summary>
        /// <param name="genderId"></param>
        /// <returns></returns>
        public Gender GetbyGenderId(int genderId)
        {
            CheckGenderId(genderId);
            return genderRepository.GetById(genderId);
        }
    }
}

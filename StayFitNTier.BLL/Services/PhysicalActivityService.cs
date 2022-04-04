using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class PhysicalActivityService
    {
        PhysicalActivityRepository physicalActivityRepository;
        public PhysicalActivityService()
        {
            physicalActivityRepository = new PhysicalActivityRepository();
        }
        /// <summary>
        /// Checks the correctness of the given number.
        /// </summary>
        /// <param name="Id"></param>
        void CheckId(int Id)
        {
            if (Id <= 0) throw new Exception("Parameter value is not suitable!");
        }
        /// <summary>
        /// Get physical activity by given Id.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public PhysicalActivity GetById(int mealId)
        {
            CheckId(mealId);
            return physicalActivityRepository.GetById(mealId);
        }
        /// <summary>
        /// Adds given physical activity.
        /// </summary>
        /// <param name="physicalActivity"></param>
        /// <returns></returns>
        public bool AddPhysicalActivity(PhysicalActivity physicalActivity)
        {
            return physicalActivityRepository.Insert(physicalActivity);
        }
        /// <summary>
        /// Returns all physical activity types.
        /// </summary>
        /// <returns></returns>
        public List<PhysicalActivity> List()
        {
            return physicalActivityRepository.List();
        }
    }
}

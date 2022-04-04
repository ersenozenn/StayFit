using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class RepastService
    {
        RepastRepository repastRepository;
        public RepastService()
        {
            repastRepository = new RepastRepository();
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
        /// Gets repast by given Id.
        /// </summary>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public Repast GetById(int repastId)
        {
            CheckId(repastId);
            return repastRepository.GetById(repastId);
        }
        /// <summary>
        /// Adds given repast to database.
        /// </summary>
        /// <param name="repast"></param>
        /// <returns></returns>
        public bool AddRepast(Repast repast)
        {
            return repastRepository.Insert(repast);
        }
        /// <summary>
        /// Gets all repasts.
        /// </summary>
        /// <returns></returns>
        public List<Repast> GetRepasts()
        {
            return repastRepository.List();
        }
    }
}

using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class UserPropertyService
    {
        UserPropertyRepository userPropertyRepository;
        public UserPropertyService()
        {
            userPropertyRepository = new UserPropertyRepository();
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
        /// Gets specififc userproperty with given Id.
        /// </summary>
        /// <param name="userPropertyId"></param>
        /// <returns></returns>
        public UserProperty GetById(int userPropertyId)
        {
            CheckId(userPropertyId);
            return userPropertyRepository.GetById(userPropertyId);
        }
        /// <summary>
        /// Adds given user property do database.
        /// </summary>
        /// <param name="userProperty"></param>
        /// <returns></returns>
        public bool AddUserProperty(UserProperty userProperty)
        {
            return userPropertyRepository.Insert(userProperty);
        }
        /// <summary>
        /// Gets all user properties.
        /// </summary>
        /// <returns></returns>
        public List<UserProperty> GetUserProperties()
        {
            return userPropertyRepository.List();
        }
        /// <summary>
        /// Deletes given user property.
        /// </summary>
        /// <param name="userPropertyId"></param>
        /// <returns></returns>
        public bool DeleteforUser(int userPropertyId)
        {
            CheckId(userPropertyId);
            UserProperty userProperty = GetById(userPropertyId);
            return userPropertyRepository.DeleteforUser(userProperty);
        }
        /// <summary>
        /// Gets all active user properties.
        /// </summary>
        /// <returns></returns>

        public List<UserProperty> GetActiveUserProperties()
        {
            return userPropertyRepository.GetActiveUserProperties();
        }
        /// <summary>
        /// Gets user property by physical acitivity Id.
        /// </summary>
        /// <param name="physicalActivityId"></param>
        /// <returns></returns>
        public List<UserProperty> GetByPhysicalActivity(int physicalActivityId)
        {
            CheckId(physicalActivityId);
            return userPropertyRepository.GetByPhysicalActivity(physicalActivityId);
        }
        /// <summary>
        /// Get all user properties by given gender Id.'Male=2','Female=1'
        /// </summary>
        /// <param name="genderId"></param>
        /// <returns></returns>
        public List<UserProperty> GetByGender(int genderId)
        {
            CheckId(genderId);
            return userPropertyRepository.GetByGender(genderId);
        }
        /// <summary>
        /// Updates given user property.
        /// </summary>
        /// <param name="userProperty"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(UserProperty userProperty)
        {
            return userPropertyRepository.UpdateforAdmin(userProperty);
        }
        /// <summary>
        /// Deletes given user property Id.
        /// </summary>
        /// <param name="userPropertyId"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(int userPropertyId)
        {
            CheckId(userPropertyId);
            UserProperty userProperty = GetById(userPropertyId);
            return userPropertyRepository.DeleteforAdmin(userProperty);
        }
        /// <summary>
        /// Gets user properties by given user Id.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<UserProperty> GetUserPropertiesbyuserId(int userId)
        {
            CheckId(userId);
            if (userPropertyRepository.GetUserPropertiesbyuserId(userId).Count==0)
            {
                return null;
            }
            return userPropertyRepository.GetUserPropertiesbyuserId(userId);
        }
        /// <summary>
        /// Get active user properties by given userId.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserProperty GetActiveUserPropertyByuserId(int userId)
        {
            CheckId(userId);
            return userPropertyRepository.GetActiveUserPropertyByuserId(userId);
        }
       

    }
}

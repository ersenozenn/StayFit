using StayFitNTier.DAL.Abstract;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StayFitNTier.DAL.Repositories
{
    public class UserPropertyRepository : BaseRepository<UserProperty>, IDeleteforUserRepository<UserProperty>, IDeleteforAdmin<UserProperty>
    {
        StayFitDbContext c;
        public UserPropertyRepository()
        {
            c = new StayFitDbContext();
        }
        /// <summary>
        /// Deletes row which has sent.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforUser(UserProperty p)
        {
            UserProperty deletedValue = c.UserProperties.Find(p.Id);
            deletedValue.IsActive = false;
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Gets all userproperties which isactive=true.
        /// </summary>
        /// <returns></returns>
        public List<UserProperty> GetActiveUserProperties()
        {
            return c.UserProperties.Where(a => a.IsActive).ToList();
        }
        /// <summary>
        /// Gets user properties by given user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<UserProperty> GetUserPropertiesbyuserId(int userId)
        {
            return c.UserProperties.Where(a => a.UserId==userId).ToList();
        }
        /// <summary>
        /// Gets isactive=true user properties by given user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserProperty GetActiveUserPropertyByuserId(int userId)
        {
            return c.UserProperties.Where(a => a.UserId == userId && a.IsActive==true).SingleOrDefault();
        }
        /// <summary>
        /// Get user properties by physical activity Id.
        /// </summary>
        /// <param name="physicalActivityId"></param>
        /// <returns></returns>
        public List<UserProperty> GetByPhysicalActivity(int physicalActivityId)
        {
            return c.UserProperties.Where(a => a.PhysicalActivityId == physicalActivityId && a.IsActive).ToList();
        }
        /// <summary>
        /// Get all user properties by gender.
        /// </summary>
        /// <param name="genderId"></param>
        /// <returns></returns>
        public List<UserProperty> GetByGender(int genderId)
        {
            return c.UserProperties.Where(a => a.GenderId == genderId && a.IsActive).ToList();
        }

        /// <summary>
        /// Updates given user property.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(UserProperty p)
        {
            UserProperty userProperty = c.UserProperties.Find(p.Id);
                        
            userProperty.UserId = p.Id;
            userProperty.GenderId = p.GenderId;
            userProperty.BirthDate = p.BirthDate;
            userProperty.MeasarumentDate = p.MeasarumentDate;            
            userProperty.Height = p.Height;
            userProperty.Weight = p.Weight;            
            userProperty.PhysicalActivityId = p.PhysicalActivityId;            
            userProperty.IsActive = p.IsActive;

            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Deletes given property.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(UserProperty p)
        {
            UserProperty deletedValue = c.UserProperties.SingleOrDefault(a => a.Id == p.Id);
            c.UserProperties.Remove(deletedValue);
            return c.SaveChanges() > 0;
        }
    }
}

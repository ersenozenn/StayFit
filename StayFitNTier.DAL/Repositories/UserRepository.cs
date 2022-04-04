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
    public class UserRepository : BaseRepository<User>, IDeleteforUserRepository<User>, IDeleteforAdmin<User>
    {
        StayFitDbContext c;
        public UserRepository()
        {
            c = new StayFitDbContext();
        }
        /// <summary>
        /// Deletes user by given information.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(User p)
        {
            User deletedValue = c.Users.Include(a => a.Meals ).Include(a=>a.UserProperties).SingleOrDefault(a => a.Id == p.Id);
            c.Users.Remove(deletedValue);
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Deletes user by given user.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforUser(User p)
        {            
            User deletedValue = c.Users.Find(p.Id);
            deletedValue.IsActive = false;
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Gets all active user.
        /// </summary>
        /// <returns></returns>
        public List<User> GetActiveUsers()
        {
            return c.Users.Where(a => a.IsActive).ToList();
        }
        /// <summary>
        /// Updates user by given information.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(User p)
        {
            User updatedValue = c.Users.Include(a => a.Meals).SingleOrDefault(a => a.Id == p.Id);
            updatedValue.IsActive = p.IsActive;
            updatedValue.FirstName = p.FirstName;
            updatedValue.Surname = p.Surname;
            updatedValue.PhoneNumber = p.PhoneNumber;
            updatedValue.Mail = p.Password;
            updatedValue.CreateDate = p.CreateDate;
            updatedValue.Password = p.Password;
            return c.SaveChanges() > 0;
        }       
        /// <summary>
        /// Gets specific user by specific mail.
        /// </summary>
        /// <param name="_mail"></param>
        /// <returns></returns>
        public User GetUserbyMail(string _mail)
        {
            return c.Users.Where(a => a.Mail == _mail && a.IsActive==true).SingleOrDefault();
        }
        public bool UpdateforUser(User p)
        {
            User updatedValue = c.Users.Include(a => a.Meals).SingleOrDefault(a => a.Id == p.Id);
            updatedValue.IsActive = p.IsActive;
            updatedValue.FirstName = p.FirstName;
            updatedValue.Surname = p.Surname;
            updatedValue.PhoneNumber = p.PhoneNumber;
            updatedValue.CreateDate = p.CreateDate;
            updatedValue.Password = p.Password;
            updatedValue.Mail = p.Mail;
            return c.SaveChanges() > 0;
        }

    }
}

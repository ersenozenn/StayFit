using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        /// <summary>
        /// Check for correctness of Id.
        /// </summary>
        /// <param name="Id"></param>
        void CheckId(int Id)
        {
            if (Id <= 0) throw new Exception("Parameter value is not suitable!");
        }
        /// <summary>
        /// Gets user by given Id.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public User GetById(int userId)
        {
            CheckId(userId);
            return userRepository.GetById(userId);
        }
        /// <summary>
        /// Adds user to database.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string AddUser(User user)
        {
            string firstName = user.FirstName;
            string surname = user.Surname;
            string phoneNumber = user.PhoneNumber;
            string mail = user.Mail;
            string password = user.Password;
            
            if (mail.Length > 10 && password.Any(Char.IsDigit) && password.Any(Char.IsLower) && password.Any(char.IsUpper) &&  !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(surname) && password.Length >= 6 && mail.Contains("@") && mail.EndsWith(".com") && !firstName.Any(char.IsDigit) && !surname.Any(char.IsDigit) && !firstName.Any(char.IsSymbol) && !surname.Any(char.IsSymbol))
            {
                if (GetUserbyMail(mail) != null)
                {
                   return "This e_mail already registered!";
                }
                else
                {
                    firstName = firstName[0].ToString().ToUpper() + firstName.Substring(1);
                    surname = surname[0].ToString().ToUpper() + surname.Substring(1);
                    if (userRepository.Insert(user))
                    {
                        return "Sign up succesfull";
                    }
                }

            }
            
            else if (mail.Length <= 10  || !mail.Contains("@") || !mail.EndsWith(".com"))
            {
                return "Please enter a valid email address!";
            }
            else if ( string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(surname) )
            {
                return "Please do not leave the name and surname fields blank!";
            }
            else if (mail.Length < 10 )
            {
                return "Email address must be longer than 10 characters!";
            }
            else if (!password.Any(Char.IsDigit) || !password.Any(Char.IsLower) || !password.Any(char.IsUpper)  || password.Length < 7 )
            {
                return "Your password must contain uppercase and lowercase letters and numbers and length should be more than 6 characters!";
            }            
            else if ( firstName.Any(char.IsDigit) || surname.Any(char.IsDigit) || firstName.Any(char.IsSymbol) || surname.Any(char.IsSymbol))
            {
                return "Firstname or lastname should not contain symbol or digit character";
            }
                       
                return "Something went wrong. Please check your entries.";
            
        }
        /// <summary>
        /// Deletes user by given userId.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(int userId)
        {
            CheckId(userId);
            User user = GetById(userId);
            return userRepository.DeleteforAdmin(user);
        }
        /// <summary>
        /// Deletes user by given userId.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool DeleteforUser(int userId)
        {
            CheckId(userId);
            User user = GetById(userId);
            return userRepository.DeleteforUser(user);
        }
        /// <summary>
        /// Gets all active users.
        /// </summary>
        /// <returns></returns>
        public List<User> GetActiveUsers()
        {
            return userRepository.GetActiveUsers();
        }
        /// <summary>
        /// Updates user row by given user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string UpdateforAdmin(User user)
        {
            string firstName = user.FirstName;
            string surname = user.Surname;
            string phoneNumber = user.PhoneNumber;
            string mail = user.Mail;
            string password = user.Password;

            if (mail.Length > 10 && password.Any(Char.IsDigit) && password.Any(Char.IsLower) && password.Any(char.IsUpper) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(surname) && password.Length >= 6 && mail.Contains("@") && mail.EndsWith(".com") && !firstName.Any(char.IsDigit) && !surname.Any(char.IsDigit) && !firstName.Any(char.IsSymbol) && !surname.Any(char.IsSymbol))
            {
                if (GetUserbyMail(mail) != null)
                {
                    return "This e_mail already registered!";
                }
                else
                {
                    firstName = firstName[0].ToString().ToUpper() + firstName.Substring(1);
                    surname = surname[0].ToString().ToUpper() + surname.Substring(1);
                    if (userRepository.UpdateforAdmin(user))
                    {
                        return "Update succesfull";
                    }
                }

            }

            else if (mail.Length <= 10 || !mail.Contains("@") || !mail.EndsWith(".com"))
            {
                return "Please enter a valid email address!";
            }
            else if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(surname))
            {
                return "Please do not leave the name and surname fields blank!";
            }
            else if (mail.Length < 10)
            {
                return "Email address must be longer than 10 characters!";
            }
            else if (!password.Any(Char.IsDigit) || !password.Any(Char.IsLower) || !password.Any(char.IsUpper) || password.Length < 7)
            {
                return "Your password must contain uppercase and lowercase letters and numbers and length should be more than 6 characters!";
            }
            else if (firstName.Any(char.IsDigit) || surname.Any(char.IsDigit) || firstName.Any(char.IsSymbol) || surname.Any(char.IsSymbol))
            {
                return "Firstname or lastname should not contain symbol or digit character";
            }

            return "Something went wrong. Please check your entries.";
        }
        /// <summary>
        /// Gets specific user by given mail.
        /// </summary>
        /// <param name="_mail"></param>
        /// <returns></returns>
        public User GetUserbyMail(string _mail)
        {
            return userRepository.GetUserbyMail(_mail);
        }
        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            return userRepository.List();
        }
        public string UpdateforUser(User user)
        {
            string firstName = user.FirstName;
            string surname = user.Surname;
            string phoneNumber = user.PhoneNumber;
            string mail = user.Mail;
            string password = user.Password;         


            if (password.Any(Char.IsDigit) && password.Any(Char.IsLower) && password.Any(char.IsUpper)  && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(surname) && password.Length >= 6  && !firstName.Any(char.IsDigit) && !surname.Any(char.IsDigit))
            {
                firstName = firstName[0].ToString().ToUpper() + firstName.Substring(1);
                surname = surname[0].ToString().ToUpper() + surname.Substring(1);
                if (userRepository.UpdateforUser(user))
                {
                    return "Update succesfull";
                }
            }
            else if (mail.Length <= 10 || !mail.Contains("@") || !mail.EndsWith(".com"))
            {
                return "Please enter a valid email address!";
            }
            else if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(surname))
            {
                return "Please do not leave the name and surname fields blank!";
            }
            else if (mail.Length < 10)
            {
                return "Email address must be longer than 10 characters!";
            }
            else if (!password.Any(Char.IsDigit) || !password.Any(Char.IsLower) || !password.Any(char.IsUpper) || password.Length < 7)
            {
                return "Your password must contain uppercase and lowercase letters and numbers and length should be more than 6 characters!";
            }
            else if (firstName.Any(char.IsDigit) || surname.Any(char.IsDigit) || firstName.Any(char.IsSymbol) || surname.Any(char.IsSymbol))
            {
                return "Firstname or lastname should not contain symbol or digit character";
            }


            return "Something went wrong. Please check your entries.";
            
        }

    }
}

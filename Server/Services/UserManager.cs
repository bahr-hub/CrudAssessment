using CrudAssessment.Server.Data;
using CrudAssessment.Server.Interfaces;
using CrudAssessment.Shared.Models;
using Microsoft.EntityFrameworkCore;


namespace CrudAssessment.Server.Services
{
    public class UserManager : IUser
    {
        readonly ApplicationDbContext _dbContext = new();
        public UserManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //To Get all user details
        public List<UserInfo> GetUserDetails()
        {
            try
            {
                return _dbContext.UserInform.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new user record
        public void AddUser(UserInfo user)
        {
            try
            {
                _dbContext.UserInform.Add(user);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar user
        public void UpdateUserDetails(UserInfo user)
        {
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular user
        public UserInfo GetUserData(int id)
        {
            try
            {
                UserInfo? user = _dbContext.UserInform.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular user
        public void DeleteUser(int id)
        {
            try
            {
                UserInfo? user = _dbContext.UserInform.Find(id);
                if (user != null)
                {
                    _dbContext.UserInform.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

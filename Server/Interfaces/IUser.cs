using CrudAssessment.Shared.Models;

namespace CrudAssessment.Server.Interfaces
{
    public interface IUser
    {
        public List<UserInfo> GetUserDetails();
        public void AddUser(UserInfo user);
        public void UpdateUserDetails(UserInfo user);
        public UserInfo GetUserData(int id);
        public void DeleteUser(int id);
    }
}

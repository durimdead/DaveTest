namespace DaveTest.Data
{
    public interface IUser
    {
        public bool CreateUser(string userName, string address, string phoneNumber, int age);
        public bool DeleteUser(int userID);
        public bool EditUser(string userName, string address, string phoneNumber, int age, int userID);
    }
}

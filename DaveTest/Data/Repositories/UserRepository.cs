namespace DaveTest.Data.Repositories
{
    using DaveTest.Data.Interfaces;
    public class UserRepository : IUser
    {
        /// <summary>
        /// Used to create a new user in the database.
        /// </summary>
        /// <param name="FirstName">user's first name</param>
        /// <param name="LastName">user's last name</param>
        /// <param name="address">address of the user</param>
        /// <param name="phoneNumber">phone number for the user</param>
        /// <param name="age">user's age</param>
        /// <returns>true if successful creation</returns>
        public bool CreateUser(string FirstName, string LastName, string address, string phoneNumber, int age)
        {
            bool returnValue = true;
            try
            {

            }
            catch(Exception e)
            {
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// delete the user specified based on the ID sent through.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>true if successful delete</returns>
        public bool DeleteUser(int userID)
        {
            bool returnValue = true;
            try
            {

            }
            catch (Exception e)
            {
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// Update the user based on the information sent in
        /// </summary>
        /// <param name="FirstName">user's first name</param>
        /// <param name="LastName">user's last name</param>
        /// <param name="address">address of the user</param>
        /// <param name="phoneNumber">phone number for the user</param>
        /// <param name="age">user's age</param>
        /// <param name="userID">ID of the user record</param>
        /// <returns>true if edit is successful</returns>
        public bool EditUser(string FirstName, string LastName, string address, string phoneNumber, int age, int userID)
        {
            bool returnValue = true;
            try
            {

            }
            catch (Exception e)
            {
                returnValue = false;
            }
            return returnValue;
        }
    }
}

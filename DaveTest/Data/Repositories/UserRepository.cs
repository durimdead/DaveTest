namespace DaveTest.Data.Repositories
{
    using DaveTest.Data.Interfaces;
    using DaveTest.Data.Models;
    using DaveTest.Data.Services;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration.UserSecrets;
    using System.Diagnostics.Metrics;
    using System.Net;

    public class UserRepository : IUserRepository
    {
        private readonly DaveTestContext _context;

        /// <summary>
        /// initilaizes appropriate db context for connections
        /// </summary>
        /// <param name="context">database context</param>
        public UserRepository(DaveTestContext context)
        {
            _context = context;
        }


        /// <summary>
        /// delete the user specified based on the ID sent through.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>true if successful delete</returns>
        public string DeleteUser(int userID)
        {
            string returnValue = string.Empty;
            try
            {

            }
            catch (Exception e)
            {
                returnValue = e.Message;
            }
            return returnValue;
        }

        /// <summary>
        /// Update the user based on the information sent in
        /// </summary>
        /// <param name="firstName">user's first name</param>
        /// <param name="lastName">user's last name</param>
        /// <param name="address">address of the user</param>
        /// <param name="phoneNumber">phone number for the user</param>
        /// <param name="age">user's age</param>
        /// <param name="userID">ID of the user record - if none is passed in, we use "0" to indicate new user</param>
        /// <returns>true if edit is successful</returns>
        public string UpsertUser(string firstName, string lastName, string address, string phoneNumber, int age, int userID = 0)
        {
            string returnValue = string.Empty;
            try
            {
                // parameterize the data for executing the stored procedure
                var parameter = new List<SqlParameter>();
                parameter.Add(new SqlParameter("@userFirstName", firstName));
                parameter.Add(new SqlParameter("@userLastName", lastName));
                parameter.Add(new SqlParameter("@userAddress", address));
                parameter.Add(new SqlParameter("@userPhoneNumber", phoneNumber));
                parameter.Add(new SqlParameter("@userAge", age));
                parameter.Add(new SqlParameter("@userID", userID));

                // execute sproc
                _context.Database.ExecuteSqlRaw("exec usp_UserUpsert @userID, @userFirstName, @userLastName, @userAddress, @userAge, @userPhoneNumber");
            }
            catch (Exception e)
            {
                returnValue = e.Message;
            }
            return returnValue;
        }

        /// <summary>
        /// gets all users and their information
        /// </summary>
        /// <returns>A list of all users.</returns>
        public List<User> GetAllUsers()
        {
            List<User> returnValue = new List<User>();
            try
            {
                returnValue = _context.VUser.Select(x => new User(x.userID, x.firstName, x.lastName, x.address, x.phoneNumber, x.age)).ToList();
            }
            catch (Exception e)
            {
                //TODO: add logging to db table
                Console.WriteLine(e.Message);
            }
            return returnValue;
        }
    }
}

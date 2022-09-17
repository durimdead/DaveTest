namespace DaveTest.Data.Models
{
    public class User
    {
        public User(string userID, string firstName, string lastName, string address, string phoneNumber, int age)
        {
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.age = age;
        }

        private string userID { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string address { get; set; }
        private  string phoneNumber { get; set; }
        private int age { get; set; }
    }
}

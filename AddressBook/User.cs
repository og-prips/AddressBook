using Microsoft.VisualBasic.ApplicationServices;

namespace AddressBook
{
    public class User
    {
        FileHandler fileHandler = new FileHandler();

        public User()
        {

        }

        public User(Guid userID, string name, string streetAddress, string postalCode, string county, string phoneNumber, string email)
        {
            UserID = userID;
            Name = name;
            StreetAddress = streetAddress;
            PostalCode = postalCode;
            County = county;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Guid UserID { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string County { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        public void Create()
        {
            UserID = Guid.NewGuid();

            string[] userInfo = new string[]
            {
                UserID.ToString(),
                Name,
                StreetAddress,
                PostalCode,
                County,
                PhoneNumber,
                Email
            };

            fileHandler.SaveToFile(userInfo, ',');
        }

        public void Update()
        {
            string updatedText = $"{UserID.ToString()},{Name},{StreetAddress},{PostalCode},{County},{PhoneNumber},{Email}";
            fileHandler.UpdateRow(UserID, updatedText);
        }

        public void Delete()
        {
            fileHandler.UpdateRow(UserID, null);
        }
    }
}

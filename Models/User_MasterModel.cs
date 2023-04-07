using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AddressBook.Models
{
    public class User_MasterModel
    {
        public int UserID { get; set; }

        [Required]
        [DisplayName("User Name")]
        public string? UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhotoPath { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}

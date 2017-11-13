using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinancialReports.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int userID { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The username can only be 30 characters.")]
        public string UserName { get; set; }

        //Confirm Password, does not effect database
        [NotMapped]
        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password doesn't match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "The password can only be 30 characters.")]
        public string Password { get; set; }

        [Required]
        [DisplayName("First Name")]
        [StringLength(50, ErrorMessage = "Firstname can only be 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(50, ErrorMessage = "Lastname can only be 30 characters.")]
        public string LastName { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace TeamManagemnet.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="This field is mandatory")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [NotMapped]
        public string ConFirmPassword { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage = "This field is mandatory")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This field is mandatory")]
        public string LastName { get; set; }

        [Display(Name = "Mobile no.")]
        [Required(ErrorMessage = "This field is mandatory")]
        public int ContactNo { get; set; }

        [Display(Name = "Email Id")]
        [Required(ErrorMessage = "This field is mandatory")]
        public string Email { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "This field is mandatory")]
        public string Dob { get; set; }

        [ForeignKey("Role")]
        public int RoleID { get; set; }

        public IEnumerable<Role> Role { get; set; }
        //[Display(Name = "Team Coach")]
        //public bool TeamCoach { get; set; }

        //[Display(Name = "Team Caption")]
        //public bool TeamCaptain { get; set; }

        //[Display(Name ="Player")]
        //public bool Player { get; set; }
    }
}
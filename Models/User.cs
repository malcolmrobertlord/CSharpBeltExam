using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CSharpBeltExam.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [MinLength(2)]
        public string Name {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", ErrorMessage = "You must have one letter, one number, and one special character.")]
        [MinLength(8)]
        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        //connect to one to many
        public List<Meeting> MeetingsCreated {get;set;}

        //connect to many to many
        public List<Invite> MyInvites {get;set;}

        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]

        public string Confirm {get;set;}
    }

    public class AlphaNumAttribute : ValidationAttribute
    {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if ((DateTime)value < DateTime.Now)
        {
            return new ValidationResult("Event must be in the future");
        }
        return ValidationResult.Success;
    }
    }
}

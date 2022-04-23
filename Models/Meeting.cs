using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CSharpBeltExam.Models
{
    public class Meeting
    {
        [Key]
        public int MeetingId {get;set;}

        [Required]
        public string Title {get;set;}

        [Required]
        [FutureEvent]
        public DateTime Date{get;set;}

        [Required]
        [Range(0, int.MaxValue)]
        public int Duration {get;set;}

        [Required]
        public string TimeType {get;set;}

        [Required]
        public string Description {get;set;}

        //one to many connection
        public int UserId {get;set;}
        public User Coordinator {get;set;}

        //many to many
        public List<Invite> InvitesMade {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

    public class FutureEventAttribute : ValidationAttribute
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
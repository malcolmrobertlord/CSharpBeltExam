using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpBeltExam.Models
{
    public class Invite
    {
        [Key]
        public int InviteId {get;set;}
        public int UserId {get;set;}
        public User Participant {get;set;}
        public int MeetingId {get;set;}
        public Meeting Meeting {get;set;}

    }
}
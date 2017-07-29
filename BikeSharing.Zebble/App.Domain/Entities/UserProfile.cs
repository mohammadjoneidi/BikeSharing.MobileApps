﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int? Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string BirthDateString { get{ return BirthDate.ToString("dddd, MMMM dd"); }  }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        public Payment Payment { get; set; }

        public int PaymentId { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string FaceProfileId { get; set; }

        public string VoiceProfileId { get; set; }

        public string PhotoUrl { get; set; }
    }
}
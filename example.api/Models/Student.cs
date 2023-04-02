﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace example.api.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string ProfileImageUrl { get; set; }
       
        public Guid GenderId { get; set; }

        public Gender Gender { get; set; }

        public Address Address { get; set; }
    }
}

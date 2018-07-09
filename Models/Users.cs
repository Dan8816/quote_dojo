using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models 
{
    public class Users {

        [Required]
        [MinLength(3),MaxLength(15)]
        public string Name {get;set;}

        [Required]
        [MinLength(10),MaxLength(140)]
        public string Quote {get;set;}

    }
}
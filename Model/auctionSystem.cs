﻿using System.ComponentModel.DataAnnotations;

namespace aunction.Model
{
    public class auctionSystem
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string? UserID {get;set;}
        public string? flag { get; set; }
        public string? flag2 { get; set; }
        public IFormFile? ImageURL { get; set; }
        public byte[]? ImageField { get; set; }


    }

}

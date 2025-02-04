﻿using System.ComponentModel.DataAnnotations; // Importing data annotations for validation
using System.ComponentModel.DataAnnotations.Schema; // Importing for database schema configurations

namespace BrokerAPI.Models.Domain
{
    // Model class representing a Broker entity
    public class Broker
    {
        // Primary key for the Broker entity, auto-generated by the database
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrokerId { get; set; }

        // Required property for the broker's name
        [Required]
        public string Name { get; set; }

        // Required property for the broker's username
        [Required]
        public string UserName { get; set; }

        // Required property for the broker's password with a minimum length of 6 characters
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        // Required property for the broker's contact number
        [Required]
        public long ContactNumber { get; set; }

        // Required property for the broker's address
        [Required]
        public string Address { get; set; }

        // Required property for the broker's pincode
        [Required]
        public long Pincode { get; set; }

        // Required property for the broker's Aadhaar card number
        [Required]
        public long AdhaarCard { get; set; }
    }
}

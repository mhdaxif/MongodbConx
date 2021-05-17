﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CrudApp.Common;

namespace CrudApp.Models
{
    public class Users : Base
    {
        public Users()
        {
            this.RegisterDate = DateTime.Now;
        }

        [BsonElement("fullName")]
        public string FullName { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("avatar")]
        public string Avatar { get; set; }

        [BsonElement("bio")]
        public string Bio { get; set; }

        [BsonElement("registerDate")]
        public DateTime RegisterDate { get; set; }
    }
}

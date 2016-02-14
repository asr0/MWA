﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Entities
{
  public  class User
    {
        protected User() { }

        public User(string email, string password, bool isAdmin)
        {
            this.Email = email;
            // this.Password = StringHelper.Encrypt(password)
            this.Password = password;
            this.IsAdmin = isAdmin;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; }
    }
}

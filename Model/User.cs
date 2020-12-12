using Br.Sa.Scania.KD.ControlAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Br.Sa.Scania.KD.ControlAccess.Model
{
    public class User
    {
        private UserContext context;
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string TypeOfAccess { get; set; }

        public string EncryptedKey { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAuthorize20201024.Models
{
    public class UserModel
    {
        public List<UserEntity> lst { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
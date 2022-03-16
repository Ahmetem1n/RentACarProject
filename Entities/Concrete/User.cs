using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public string UserFirstname { get; set; }
        public string UserLastname { get; set; }
        public string UserNationalityId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserPhoto { get; set; }
    }
}

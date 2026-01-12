using Caz.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caz.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; } = string.Empty;
        public string FullName { get; private set; } = string.Empty;
        public UserStatus Status { get; private set; }

        public User(string email, string fullName)
        {
            Id = Guid.NewGuid();
            Email = email;
            FullName = fullName;
            Status = UserStatus.Active;
        }

        public void Activate() => Status = UserStatus.Active;
        public void Deactivate() => Status = UserStatus.Inactive;
        public void Block() => Status = UserStatus.Blocked;

    }
}

using System;
using System.Collections.Generic;

namespace BookStore_WebAPI.Models;

public partial class Role
{
    public short RoleId { get; set; }

    public string RoleDesc { get; set; } = null!;

    public virtual ICollection<User> Users { get; } = new List<User>();
}

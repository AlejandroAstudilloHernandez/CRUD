using System;
using System.Collections.Generic;

namespace CRUD.Models
{
    public partial class Usuario
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public decimal Phone { get; set; }
        public string Email { get; set; } = null!;
    }
}

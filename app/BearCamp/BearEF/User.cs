//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace BearEF
{
    public partial class User
    {
        public User()
        {
            this.Permissions = new HashSet<Permission>();
        }
    
        public string UserLogin { get; set; }
        public string Pswd { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    
        public virtual ICollection<Permission> Permissions { get; set; }
    }
    
}
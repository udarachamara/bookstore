//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public string Status { get; set; }
        public byte[] CreateAt { get; set; }
        public string RemoteAction { get; set; }
    }
}

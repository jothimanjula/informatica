using System;
using System.Collections.Generic;

namespace InfomaticsDataLayer.Models
{
    public partial class Useraccounts
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MySqlEf.Data.Entity
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Location UserLocation { get; set; }
    }

    public class Location
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

    }
}

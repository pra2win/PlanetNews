﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanetNews.Domain
{
    public class User
    {
            public int UserId { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailId { get; set; }
            public string MobileNo { get; set; }
            public string Gender { get; set; }
            public string Thumbnail { get; set; }
            public int userType { get; set; }
    }
}
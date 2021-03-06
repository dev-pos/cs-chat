﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClientMobile.Models.Chat
{
    class RestUserModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interfaces
{
    public interface IEmailSender
    {
        void SendEmail(string Email, string Guid);
    }
}

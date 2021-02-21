﻿using EuromillionsCore.Models;
using System.Collections.Generic;

namespace EuromillionsCore.Interfaces
{
    interface IMailService
    {
        void Send(List<Draw> draws);
    }
}
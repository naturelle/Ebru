﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterandLoginApp.Utility
{
    interface Ilogger
    {
        void Debug(string message);
        void Info(string message);
        void Warning(string message);
        void Error(string message);

    }
}

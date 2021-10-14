﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NexCrypto.Data;

namespace NexCrypto
{
    public static class Nex
    {
        public static NexCryptoContext NexCryptoContext { get; set; }
        public static Models.Users LoggedInUser { get; set; }
        public static bool LoggedIn { get; set; }

        public static void Initialize()
        {
            NexCryptoContext = new NexCryptoContext();
            LoggedIn = false;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apprefine.MattermostBots.Common.Models
{
    public class MattermostOptions
    {
        public string ApiUrl { get; set; }

        /// <summary>
        /// Personal Access Token generated by an admin
        /// </summary>
        public string Token { get; set; }
    }
}

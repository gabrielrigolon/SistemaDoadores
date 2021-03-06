﻿using SistemaDoacoes.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Entities
{
    public class User : Entity
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class User
    {

        public int UserId { get; set; }
        public int IdQuizz { get; set; }
        public bool IsAdmin { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    class TeamModel
    {
        public List<PersonModel> teamMembers { get; set; } = new List<PersonModel>();
        public string teamName { get; set; }
    }
}

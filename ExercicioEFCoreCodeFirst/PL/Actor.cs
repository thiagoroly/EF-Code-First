﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }

        public virtual IEnumerable<ActorMovie> Characters { get; set; }
    }
}

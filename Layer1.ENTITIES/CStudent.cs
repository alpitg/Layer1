﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.ENTITIES
{
    public class CStudent: IEntityBase
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public bool? IsDeleted{ get; set; }
    }
}

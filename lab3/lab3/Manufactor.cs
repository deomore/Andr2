﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{

    [Table("Manufactor")]
    public class Manufactor
    {
        
        
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        private long id { get; set; }
    }
}

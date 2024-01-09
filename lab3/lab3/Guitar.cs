using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    [Table("Guitar")]
    public class Guitar
    {


        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        private string body { get; set; }
        private int year { get; set; }
        private long manufactorId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Esperanza.Model
{
    public class Texto
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Frase { get; set; }
        public DateTime Date { get; set; }
    }
}
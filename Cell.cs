﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelApplication
{
    public class Cell
    {
        public string Expression { get; set; }
        public double Value { get; set; }
        public string Error { get; set; } = null;
        public int RowNumber;
        public char ColumnLetter;
        public List<Cell> References { get; set; } = new List<Cell>();

        public Transform Transform
        {
            get => default(Transform);
            set 
            { 
            }
        }
    }
}

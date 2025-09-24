﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.model
{
    internal class Note 
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ReminderDate { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CS8NullsDemo
{
    public class Message
    {

        public string? From { get; set; } = "";
        public string Text { get; set; } = "";
        public string? ToUpperFrom() => (From?.ToUpperInvariant());
    }
}

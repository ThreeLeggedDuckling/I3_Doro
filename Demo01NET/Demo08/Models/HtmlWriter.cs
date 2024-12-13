using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08.Models
{
    internal class HtmlWriter : ImessageWriter
    {
        public void Write(string message) 
        {
            Console.Write($@"<!DOCTYPE html>
<html>
<head>
<title> Document HTML </title>
</head>
<body></body>
</html>");
        }
    }
}

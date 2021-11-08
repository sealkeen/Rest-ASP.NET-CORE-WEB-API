﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.CSCourse2021Q3.M10_Exceptions
{
    public class LectorNotFoundException : DatabaseException
    {
        public LectorNotFoundException(string message) : base(message)
        {
            
        }
    }
}

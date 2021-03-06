﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoldEm
{
    public class GamblorException
        : Exception
    {
        public GamblorException() { }
        
        public GamblorException(string message)
            : base(message)
        {  }
    }

    public class EmptyDeckException
        : GamblorException
    {
        public EmptyDeckException() { }

        public EmptyDeckException(string message)
            : base(message)
        { }
    }
}

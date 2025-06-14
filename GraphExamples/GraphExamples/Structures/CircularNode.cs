﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExamples.Structures
{
    public class CircularNode<T>
    {
        public T Data { get; set; }
        public CircularNode<T> Next { get; set; }

        public CircularNode(T data)
        {
            Data = data;
        }
    }

}

﻿using System;

namespace NnCase
{
    public unsafe struct RuntimeShape
    {
        private fixed int _dims[4];

        public ref int this[int index]
        {
            get { return ref _dims[index]; }
        }

        public RuntimeShape(int d0, int d1, int d2, int d3)
        {
            _dims[0] = d0;
            _dims[1] = d1;
            _dims[2] = d2;
            _dims[3] = d3;
        }
    }
}

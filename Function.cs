﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remote_wiring_experience
{
    public enum FunctionType
    {
        NONE,
        ADD,
        SUBTRACT,
        MULTIPLY,
        DIVIDE,
        LEFTSHIFT,
        RIGHTSHIFT,
        AND,
        OR,
        STORE
    }

    class Function
    {
        private FunctionType function;

        public Function( FunctionType function )
        {
            this.function = function;
        }

        public double Process( double a, double b )
        {
            switch( function )
            {
                case FunctionType.ADD:
                    return a + b;

                case FunctionType.SUBTRACT:
                    return a - b;

                case FunctionType.MULTIPLY:
                    return a * b;

                case FunctionType.DIVIDE:
                    return a / b;

                case FunctionType.LEFTSHIFT:
                    return ( ( (int)a ) << ( (int)b ) );

                case FunctionType.RIGHTSHIFT:
                    return ( ( (int)a ) >> ( (int)b ) );

                case FunctionType.AND:
                    return ( ( (int)a ) & ( (int)b ) );

                case FunctionType.OR:
                    return ( ( (int)a ) | ( (int)b ) );

                default:
                case FunctionType.NONE:
                case FunctionType.STORE:
                    return a;
            }
        }

        public override string ToString()
        {
            switch( function )
            {
                case FunctionType.ADD:
                    return "+";

                case FunctionType.SUBTRACT:
                    return "-";

                case FunctionType.MULTIPLY:
                    return "*";

                case FunctionType.DIVIDE:
                    return "/";

                case FunctionType.LEFTSHIFT:
                    return "<<";

                case FunctionType.RIGHTSHIFT:
                    return ">>";

                case FunctionType.AND:
                    return "&";

                case FunctionType.OR:
                    return "|";

                case FunctionType.STORE:
                    return "Store as:";

                default:
                case FunctionType.NONE:
                    return "None";
            }
        }
    }
}

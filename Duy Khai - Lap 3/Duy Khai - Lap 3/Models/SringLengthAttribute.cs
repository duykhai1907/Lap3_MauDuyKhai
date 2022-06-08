using System;

namespace Duy_Khai___Lap_3.Models
{
    internal class SringLengthAttribute : Attribute
    {
        private int v;

        public SringLengthAttribute(int v)
        {
            this.v = v;
        }
    }
}
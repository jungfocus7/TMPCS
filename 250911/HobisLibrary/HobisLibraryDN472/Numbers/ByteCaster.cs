namespace Hobis.Numbers
{
    public static class ByteCaster
    {
        public const byte Max = byte.MaxValue;
        public const byte Min = byte.MinValue;

        #region [01) Signed]
        public static byte From(int vn)
        {
            if (vn > Max)
            {
                return Max;
            }
            else if (vn < Min)
            {
                return Min;
            }
            else
            {
                return (byte)vn;
            }
        }

        public static byte From(long vl)
        {
            if (vl > Max)
            {
                return Max;
            }
            else if (vl < Min)
            {
                return Min;
            }
            else
            {
                return (byte)vl;
            }
        }

        public static byte From(short vs)
        {
            if (vs > Max)
            {
                return Max;
            }
            else if (vs < Min)
            {
                return Min;
            }
            else
            {
                return (byte)vs;
            }
        }

        public static byte From(sbyte sb)
        {
            if (sb < Min)
            {
                return Min;
            }
            else
            {
                return (byte)sb;
            }
        }
        #endregion

        #region [02) Floating]
        public static byte From(double vd)
        {
            if (vd > Max)
            {
                return Max;
            }
            else if (vd < Min)
            {
                return Min;
            }
            else if (double.IsNaN(vd))
            {
                return 0;
            }
            else
            {
                return (byte)vd;
            }
        }

        public static byte From(float vf)
        {
            if (vf > Max)
            {
                return Max;
            }
            else if (vf < Min)
            {
                return Min;
            }
            else if (float.IsNaN(vf))
            {
                return 0;
            }
            else
            {
                return (byte)vf;
            }
        }

        public static byte From(decimal vm)
        {
            if (vm > Max)
            {
                return Max;
            }
            else if (vm < Min)
            {
                return Min;
            }
            else
            {
                return (byte)vm;
            }
        }
        #endregion

        #region [03) Unsigned]
        public static byte From(uint un)
        {
            if (un > Max)
            {
                return Max;
            }
            else
            {
                return (byte)un;
            }
        }

        public static byte From(ulong ul)
        {
            if (ul > Max)
            {
                return Max;
            }
            else
            {
                return (byte)ul;
            }
        }

        public static byte From(ushort us)
        {
            if (us > Max)
            {
                return Max;
            }
            else
            {
                return (byte)us;
            }
        }
        #endregion
    }
}

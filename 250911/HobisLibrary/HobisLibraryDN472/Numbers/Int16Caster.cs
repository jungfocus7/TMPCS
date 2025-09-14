namespace Hobis.Numbers
{
    public static class Int16Caster
    {
        public const short Max = short.MaxValue;
        public const short Min = short.MinValue;

        #region [01) Signed]
        public static short From(int vn)
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
                return (short)vn;
            }
        }

        public static short From(long vl)
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
                return (short)vl;
            }
        }

        public static short From(sbyte sb)
        {
            return sb;
        }
        #endregion

        #region [02) Floating]
        public static short From(double vd)
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
                return (short)vd;
            }
        }

        public static short From(float vf)
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
                return (short)vf;
            }
        }

        public static short From(decimal vm)
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
                return (short)vm;
            }
        }
        #endregion

        #region [03) Unsigned]
        public static short From(uint un)
        {
            if (un > Max)
            {
                return Max;
            }
            else
            {
                return (short)un;
            }
        }

        public static short From(ulong ul)
        {
            if (ul > (ulong)Max)
            {
                return Max;
            }
            else
            {
                return (short)ul;
            }
        }

        public static short From(ushort us)
        {
            if (us > Max)
            {
                return Max;
            }
            else
            {
                return (short)us;
            }
        }

        public static short From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

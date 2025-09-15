namespace Hobis.Numbers
{
    public static class SByteCaster
    {
        public const sbyte Max = sbyte.MaxValue;
        public const sbyte Min = sbyte.MinValue;

        #region [01) Signed]
        public static sbyte From(int vn)
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
                return (sbyte)vn;
            }
        }

        public static sbyte From(long vl)
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
                return (sbyte)vl;
            }
        }

        public static sbyte From(short vs)
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
                return (sbyte)vs;
            }
        }
        #endregion

        #region [02) Floating]
        public static sbyte From(double vd)
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
                return (sbyte)vd;
            }
        }

        public static sbyte From(float vf)
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
                return (sbyte)vf;
            }
        }

        public static sbyte From(decimal vm)
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
                return (sbyte)vm;
            }
        }
        #endregion

        #region [03) Unsigned]
        public static sbyte From(uint un)
        {
            if (un > (uint)Max)
            {
                return Max;
            }
            else
            {
                return (sbyte)un;
            }
        }

        public static sbyte From(ulong ul)
        {
            if (ul > (ulong)Max)
            {
                return Max;
            }
            else
            {
                return (sbyte)ul;
            }
        }

        public static sbyte From(ushort us)
        {
            if (us > Max)
            {
                return Max;
            }
            else
            {
                return (sbyte)us;
            }
        }

        public static sbyte From(byte bt)
        {
            if (bt > Max)
            {
                return Max;
            }
            else
            {
                return (sbyte)bt;
            }
        }
        #endregion
    }
}

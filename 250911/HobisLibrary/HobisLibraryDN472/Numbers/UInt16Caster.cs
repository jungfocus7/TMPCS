namespace Hobis.Numbers
{
    public static class UInt16Caster
    {
        public const ushort Max = ushort.MaxValue;
        public const ushort Min = ushort.MinValue;

        #region [01) Signed]
        public static ushort From(int vn)
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
                return (ushort)vn;
            }
        }

        public static ushort From(long vl)
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
                return (ushort)vl;
            }
        }

        public static ushort From(short vs)
        {
            if (vs < Min)
            {
                return Min;
            }
            else
            {
                return (ushort)vs;
            }
        }

        public static ushort From(sbyte sb)
        {
            if (sb < Min)
            {
                return Min;
            }
            else
            {
                return (ushort)sb;
            }
        }
        #endregion

        #region [02) Floating]
        public static ushort From(double vd)
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
                return (ushort)vd;
            }
        }

        public static ushort From(float vf)
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
                return (ushort)vf;
            }
        }

        public static ushort From(decimal vm)
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
                return (ushort)vm;
            }
        }
        #endregion

        #region [03) Unsigned]
        public static ushort From(uint un)
        {
            if (un > Max)
            {
                return Max;
            }
            else
            {
                return (ushort)un;
            }
        }

        public static ushort From(ulong ul)
        {
            if (ul > Max)
            {
                return Max;
            }
            else
            {
                return (ushort)ul;
            }
        }

        public static ushort From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

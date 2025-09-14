namespace Hobis.Numbers
{
    public static class UInt32Caster
    {
        public const uint Max = uint.MaxValue;
        public const uint Min = uint.MinValue;

        #region [01) Signed]
        public static uint From(int vn)
        {
            if (vn < (int)Min)
            {
                return Min;
            }
            else
            {
                return (uint)vn;
            }
        }

        public static uint From(long vf)
        {
            if (vf > Max)
            {
                return Max;
            }
            else if (vf < Min)
            {
                return Min;
            }
            else
            {
                return (uint)vf;
            }
        }

        public static uint From(short vs)
        {
            if (vs < Min)
            {
                return Min;
            }
            else
            {
                return (uint)vs;
            }
        }

        public static uint From(sbyte sb)
        {
            if (sb < Min)
            {
                return Min;
            }
            else
            {
                return (uint)sb;
            }
        }
        #endregion

        #region [02) Floating]
        public static uint From(double vd)
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
                return (uint)vd;
            }
        }

        public static uint From(float vf)
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
                return (uint)vf;
            }
        }

        public static uint From(decimal vm)
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
                return (uint)vm;
            }
        }
        #endregion

        #region [03) Unsigned]
        public static uint From(ulong ul)
        {
            if (ul > Max)
            {
                return Max;
            }
            else
            {
                return (uint)ul;
            }
        }

        public static uint From(ushort us)
        {
            return us;
        }

        public static uint From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

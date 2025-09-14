namespace Hobis.Numbers
{
    public static class UInt64Caster
    {
        public const ulong Max = ulong.MaxValue;
        public const ulong Min = ulong.MinValue;

        #region [01) Signed]
        public static ulong From(int vn)
        {
            if (vn < (int)Min)
            {
                return Min;
            }
            else
            {
                return (ulong)vn;
            }
        }

        public static ulong From(long vf)
        {
            if (vf < (long)Min)
            {
                return Min;
            }
            else
            {
                return (ulong)vf;
            }
        }

        public static ulong From(short vs)
        {
            if (vs < (int)Min)
            {
                return Min;
            }
            else
            {
                return (ulong)vs;
            }
        }

        public static ulong From(sbyte sb)
        {
            if (sb < (int)Min)
            {
                return Min;
            }
            else
            {
                return (ulong)sb;
            }
        }
        #endregion

        #region [02) Floating]
        public static ulong From(double vd)
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
                return (ulong)vd;
            }
        }

        public static ulong From(float vf)
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
                return (ulong)vf;
            }
        }

        public static ulong From(decimal vm)
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
                return (ulong)vm;
            }
        }
        #endregion

        #region [03) Unsigned]
        public static ulong From(uint un)
        {
            return un;
        }

        public static ulong From(ushort us)
        {
            return us;
        }

        public static ulong From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

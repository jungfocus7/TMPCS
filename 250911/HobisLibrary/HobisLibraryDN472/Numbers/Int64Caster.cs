namespace Hobis.Numbers
{
    public static class Int64Caster
    {
        public const long Max = long.MaxValue;
        public const long Min = long.MinValue;

        #region [01) Signed]
        public static long From(int vn)
        {
            return vn;
        }

        public static long From(short vs)
        {
            return vs;
        }

        public static long From(sbyte sb)
        {
            return sb;
        }
        #endregion

        #region [02) Floating]
        public static long From(double vd)
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
                return (long)vd;
            }
        }

        public static long From(float vf)
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
                return (long)vf;
            }
        }

        public static long From(decimal vm)
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
                return (long)vm;
            }
        }
        #endregion

        #region [03) Unsigned]
        public static long From(uint un)
        {
            return un;
        }

        public static long From(ulong ul)
        {
            if (ul > Max)
            {
                return Max;
            }
            else
            {
                return (long)ul;
            }
        }

        public static long From(ushort us)
        {
            return us;
        }

        public static long From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

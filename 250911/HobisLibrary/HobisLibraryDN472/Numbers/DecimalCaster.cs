namespace Hobis.Numbers
{
    public static class DecimalCaster
    {
        public const decimal Max = decimal.MaxValue;
        public const decimal Min = decimal.MinValue;

        #region [01) Signed]
        public static decimal From(int vn)
        {
            return vn;
        }

        public static decimal From(long vl)
        {
            return vl;
        }

        public static decimal From(short vs)
        {
            return vs;
        }

        public static decimal From(sbyte sb)
        {
            return sb;
        }
        #endregion

        #region [02) Floating]
        public static decimal From(double vd)
        {
            if (vd > (double)Max)
            {
                return Max;
            }
            else if (vd < (double)Min)
            {
                return Min;
            }
            else if (double.IsNaN(vd))
            {
                return 0;
            }
            else
            {
                return (decimal)vd;
            }
        }

        public static decimal From(float vf)
        {
            if (vf > (float)Max)
            {
                return Max;
            }
            else if (vf < (float)Min)
            {
                return Min;
            }
            else if (float.IsNaN(vf))
            {
                return 0;
            }
            else
            {
                return (decimal)vf;
            }
        }
        #endregion

        #region [03) Unsigned]
        public static decimal From(uint un)
        {
            return un;
        }

        public static decimal From(ulong ul)
        {
            return ul;
        }

        public static decimal From(ushort us)
        {
            return us;
        }

        public static decimal From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

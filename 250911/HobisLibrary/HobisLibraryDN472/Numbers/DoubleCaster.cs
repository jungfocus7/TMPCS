namespace Hobis.Numbers
{
    public static class DoubleCaster
    {
        public const double Max = double.MaxValue;
        public const double Min = double.MinValue;

        #region [01) Signed]
        public static double From(int vn)
        {
            return vn;
        }

        public static double From(long vl)
        {
            return vl;
        }

        public static double From(short vs)
        {
            return vs;
        }

        public static double From(sbyte sb)
        {
            return sb;
        }
        #endregion

        #region [02) Floating]
        public static double From(float vf)
        {
            if (float.IsNaN(vf))
            {
                return double.NaN;
            }
            else
            {
                return vf;
            }
        }

        public static double From(decimal vm)
        {
            return (double)vm;
        }
        #endregion

        #region [03) Unsigned]
        public static double From(uint un)
        {
            return un;
        }

        public static double From(ulong ul)
        {
            return ul;
        }

        public static double From(ushort us)
        {
            return us;
        }

        public static double From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

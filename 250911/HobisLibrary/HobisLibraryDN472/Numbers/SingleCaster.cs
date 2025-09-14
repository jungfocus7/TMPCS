namespace Hobis.Numbers
{
    public static class SingleCaster
    {
        public const float Max = float.MaxValue;
        public const float Min = float.MinValue;

        #region [01) Signed]
        public static float From(int vn)
        {
            return vn;
        }

        public static float From(long vl)
        {
            return vl;
        }

        public static float From(short vs)
        {
            return vs;
        }

        public static float From(sbyte sb)
        {
            return sb;
        }
        #endregion

        #region [02) Floating]
        public static float From(double vd)
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
                return float.NaN;
            }
            else
            {
                return (float)vd;
            }
        }

        public static float From(decimal vm)
        {
            return (float)vm;
        }
        #endregion

        #region [03) Unsigned]
        public static float From(uint un)
        {
            return un;
        }

        public static float From(ulong ul)
        {
            return ul;
        }

        public static float From(ushort us)
        {
            return us;
        }

        public static float From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

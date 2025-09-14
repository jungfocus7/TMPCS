namespace Hobis.Numbers
{
    public static class DoubleCaster
    {
        public const double Max = double.MaxValue;
        public const double Min = double.MinValue;

        #region [01) Signed]
        public static double From(int vn)
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
                return (double)vn;
            }
        }

        public static double From(long vl)
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
                return vl;
            }
        }

        public static double From(short vs)
        {
            if (vs < Min)
            {
                return Min;
            }
            else
            {
                return (double)vs;
            }
        }

        public static double From(sbyte sb)
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
        public static double From(float vf)
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
                return vf;
            }
        }

        public static double From(decimal vm)
        {
            if ((double)vm > Max)
            {
                return Max;
            }
            else if ((double)vm < Min)
            {
                return Min;
            }
            else
            {
                return (double)vm;
            }
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

        public static ushort From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

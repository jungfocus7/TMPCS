namespace Hobis.Numbers
{
    public static class Int32Caster
    {
        public const int Max = int.MaxValue;
        public const int Min = int.MinValue;

        #region [01) Signed]
        public static int From(long vf)
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
                return (int)vf;
            }
        }

        public static int From(short vs)
        {
            return vs;
        }

        public static int From(sbyte sb)
        {
            return sb;
        }
        #endregion

        #region [02) Floating]
        public static int From(double vd)
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
                return (int)vd;
            }
        }

        public static int From(float vf)
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
                return (int)vf;
            }
        }

        public static int From(decimal vm)
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
                return (int)vm;
            }
        }
        #endregion

        #region [03) Unsigned]
        public static int From(uint un)
        {
            if (un > (uint)Max)
            {
                return Max;
            }
            else
            {
                return (int)un;
            }
        }

        public static int From(ulong ul)
        {
            if (ul > (ulong)Max)
            {
                return Max;
            }
            else
            {
                return (int)ul;
            }
        }

        public static int From(ushort us)
        {
            return us;
        }

        public static int From(byte bt)
        {
            return bt;
        }
        #endregion
    }
}

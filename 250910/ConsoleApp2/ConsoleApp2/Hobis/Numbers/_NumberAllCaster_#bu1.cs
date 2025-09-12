namespace Hobis.Numbers
{
    public static class IntCaster
    {
        //public static int ToInt(int vn)
        //{
        //    return vn;
        //}

        public static long ToLong(int vn)
        {
            return vn;
        }

        public static short ToShort(int vn)
        {
            if (vn > short.MaxValue)
                return short.MaxValue;
            else if (vn < short.MinValue)
                return short.MinValue;
            else
                return (short)vn;
        }


        public static double ToDouble(int vn)
        {
            return vn;
        }

        public static float ToFloat(int vn)
        {
            return vn;
        }

        public static decimal ToDecimal(int vn)
        {
            return vn;
        }

        public static uint ToUint(int vn)
        {
            if (vn < uint.MinValue)
                return uint.MinValue;
            else
                return (uint)vn;
        }

        public static ulong ToUlong(int vn)
        {
            if (vn < (int)ulong.MinValue)
                return ulong.MinValue;
            else
                return (ulong)vn;
        }

        public static ushort ToUshort(int vn)
        {
            if (vn > ushort.MaxValue)
                return ushort.MaxValue;
            else if (vn < ushort.MinValue)
                return ushort.MinValue;
            else
                return (ushort)vn;
        }

        public static sbyte ToSbyte(int vn)
        {
            if (vn > sbyte.MaxValue)
                return sbyte.MaxValue;
            else if (vn < sbyte.MinValue)
                return sbyte.MinValue;
            else
                return (sbyte)vn;
        }

        public static byte ToByte(int vn)
        {
            if (vn > byte.MaxValue)
                return byte.MaxValue;
            else if (vn < byte.MinValue)
                return byte.MinValue;
            else
                return (byte)vn;
        }
    }


    public static class LongCaster
    {
        public static int ToInt(long vl)
        {
            if (vl > int.MaxValue)
                return int.MaxValue;
            else if (vl < int.MinValue)
                return int.MinValue;
            else
                return (int)vl;
        }

        public static short ToShort(long vl)
        {
            if (vl > short.MaxValue)
                return short.MaxValue;
            else if (vl < short.MinValue)
                return short.MinValue;
            else
                return (short)vl;
        }

        public static double ToDouble(long vl)
        {
            return vl;
        }

        public static float ToFloat(long vl)
        {
            return vl;
        }

        public static decimal ToDecimal(long vl)
        {
            return vl;
        }

        public static uint ToUint(long vl)
        {
            if (vl > uint.MaxValue)
                return uint.MaxValue;
            else if (vl < 0)
                return 0;
            else
                return (uint)vl;
        }

        public static ulong ToUlong(long vl)
        {
            if (vl < 0)
                return 0;
            else
                return (ulong)vl;
        }

        public static ushort ToUshort(long vl)
        {
            return default;
        }

        public static sbyte ToSbyte(long vl)
        {
            return default;
        }

        public static byte ToByte(long vl)
        {
            return default;
        }
    }


    public static class ShortCaster
    {
        public static int ToInt(long vl)
        {
            return default;
        }

        public static short ToShort(long vl)
        {
            return default;
        }

        public static double ToDouble(int vn)
        {
            return default;
        }

        public static float ToFloat(int vn)
        {
            return default;
        }

        public static decimal ToDecimal(int vn)
        {
            return default;
        }

        public static uint ToUint(int vn)
        {
            return default;
        }

        public static ulong ToUlong(int vn)
        {
            return default;
        }

        public static ushort ToUshort(int vn)
        {
            return default;
        }

        public static sbyte ToSbyte(int vn)
        {
            return default;
        }

        public static byte ToByte(int vn)
        {
            return default;
        }
    }
}

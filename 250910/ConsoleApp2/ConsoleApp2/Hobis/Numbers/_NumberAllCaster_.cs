namespace Hobis.Numbers
{
    public static class IntCaster
    {
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
            if (vn < (int)uint.MinValue)
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
            else if (vl < uint.MinValue)
                return uint.MinValue;
            else
                return (uint)vl;
        }

        public static ulong ToUlong(long vl)
        {
            if (vl < (long)ulong.MinValue)
                return ulong.MinValue;
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
        public static int ToInt(short vs)
        {
            return vs;
        }

        public static long ToLong(short vs)
        {
            return vs;
        }

        public static double ToDouble(short vs)
        {
            return vs;
        }

        public static float ToFloat(short vs)
        {
            return vs;
        }

        public static decimal ToDecimal(short vs)
        {
            return vs;
        }

        public static uint ToUint(short vs)
        {
            if (vs < (int)uint.MinValue)
                return uint.MinValue;
            else
                return (uint)vs;
        }

        public static ulong ToUlong(short vs)
        {
            if (vs < (int)ulong.MinValue)
                return ulong.MinValue;
            else
                return (ulong)vs;
        }

        public static ushort ToUshort(short vs)
        {
            if (vs < ushort.MinValue)
                return ushort.MinValue;
            else
                return (ushort)vs;
        }

        public static sbyte ToSbyte(short vs)
        {
            if (vs > sbyte.MaxValue)
                return sbyte.MaxValue;
            else if (vs < sbyte.MinValue)
                return sbyte.MinValue;
            else
                return (sbyte)vs;
        }

        public static byte ToByte(short vs)
        {
            if (vs > byte.MaxValue)
                return byte.MaxValue;
            else if (vs < byte.MinValue)
                return byte.MinValue;
            else
                return (byte)vs;
        }
    }


    public static class DoubleCaster
    {
        public static int ToInt(double vd)
        {
            if (vd > int.MaxValue)
                return int.MaxValue;
            else if (vd < int.MinValue)
                return int.MinValue;
            else
                return (int)vd;
        }

        public static long ToLong(double vd)
        {
            if (vd > long.MaxValue)
                return long.MaxValue;
            else if (vd < long.MinValue)
                return long.MinValue;
            else
                return (long)vd;
        }

        public static short ToShort(double vd)
        {
            if (vd > short.MaxValue)
                return short.MaxValue;
            else if (vd < short.MinValue)
                return short.MinValue;
            else
                return (short)vd;
        }

        public static float ToFloat(double vd)
        {
            if (vd > float.MaxValue)
                return float.MaxValue;
            else if (vd < float.MinValue)
                return float.MinValue;
            else
                return (float)vd;
        }

        public static decimal ToDecimal(double vd)
        {
            if (vd > (double)decimal.MaxValue)
                return decimal.MaxValue;
            else if (vd < (double)decimal.MinValue)
                return decimal.MinValue;
            else
                return (decimal)vd;
        }

        public static uint ToUint(double vd)
        {
            if (vd > uint.MaxValue)
                return uint.MaxValue;
            else if (vd < uint.MinValue)
                return uint.MinValue;
            else
                return (uint)vd;
        }

        public static ulong ToUlong(double vd)
        {
            if (vd > ulong.MaxValue)
                return ulong.MaxValue;
            else if (vd < ulong.MinValue)
                return ulong.MinValue;
            else
                return (ulong)vd;
        }

        public static ushort ToUshort(double vd)
        {
            if (vd > ushort.MaxValue)
                return ushort.MaxValue;
            else if (vd < ushort.MinValue)
                return ushort.MinValue;
            else
                return (ushort)vd;
        }

        public static sbyte ToSbyte(double vd)
        {
            if (vd > sbyte.MaxValue)
                return sbyte.MaxValue;
            else if (vd < sbyte.MinValue)
                return sbyte.MinValue;
            else
                return (sbyte)vd;
        }

        public static byte ToByte(double vd)
        {
            if (vd > byte.MaxValue)
                return byte.MaxValue;
            else if (vd < byte.MinValue)
                return byte.MinValue;
            else
                return (byte)vd;
        }
    }


    public static class FloatCaster
    {
        public static int ToInt(float vf)
        {
            return default;
        }

        public static long ToLong(float vf)
        {
            return default;
        }

        public static short ToShort(float vf)
        {
            return default;
        }

        public static double ToDouble(float vf)
        {
            return default;
        }

        public static float ToFloat(float vf)
        {
            return default;
        }

        public static decimal ToDecimal(float vf)
        {
            return default;
        }

        public static uint ToUint(float vf)
        {
            return default;
        }

        public static ulong ToUlong(float vf)
        {
            return default;
        }

        public static ushort ToUshort(float vf)
        {
            return default;
        }

        public static sbyte ToSbyte(float vf)
        {
            return default;
        }

        public static byte ToByte(float vf)
        {
            return default;
        }
    }


    public static class DecimalCaster
    {
        public static int ToInt(decimal vm)
        {
            return default;
        }

        public static long ToLong(decimal vm)
        {
            return default;
        }

        public static short ToShort(decimal vm)
        {
            return default;
        }

        public static double ToDouble(decimal vm)
        {
            return default;
        }

        public static float ToFloat(decimal vm)
        {
            return default;
        }

        public static decimal ToDecimal(decimal vm)
        {
            return default;
        }

        public static uint ToUint(decimal vm)
        {
            return default;
        }

        public static ulong ToUlong(decimal vm)
        {
            return default;
        }

        public static ushort ToUshort(decimal vm)
        {
            return default;
        }

        public static sbyte ToSbyte(decimal vm)
        {
            return default;
        }

        public static byte ToByte(decimal vm)
        {
            return default;
        }
    }


    public static class UintCaster
    {
        public static int ToInt(uint un)
        {
            return default;
        }

        public static long ToLong(uint un)
        {
            return default;
        }

        public static short ToShort(uint un)
        {
            return default;
        }

        public static double ToDouble(uint un)
        {
            return default;
        }

        public static float ToFloat(uint un)
        {
            return default;
        }

        public static decimal ToDecimal(uint un)
        {
            return default;
        }

        public static uint ToUint(uint un)
        {
            return default;
        }

        public static ulong ToUlong(uint un)
        {
            return default;
        }

        public static ushort ToUshort(uint un)
        {
            return default;
        }

        public static sbyte ToSbyte(uint un)
        {
            return default;
        }

        public static byte ToByte(uint un)
        {
            return default;
        }
    }


    public static class UlongCaster
    {
        public static int ToInt(ulong ul)
        {
            return default;
        }

        public static long ToLong(ulong ul)
        {
            return default;
        }

        public static short ToShort(ulong ul)
        {
            return default;
        }

        public static double ToDouble(ulong ul)
        {
            return default;
        }

        public static float ToFloat(ulong ul)
        {
            return default;
        }

        public static decimal ToDecimal(ulong ul)
        {
            return default;
        }

        public static uint ToUint(ulong ul)
        {
            return default;
        }

        public static ulong ToUlong(ulong ul)
        {
            return default;
        }

        public static ushort ToUshort(ulong ul)
        {
            return default;
        }

        public static sbyte ToSbyte(ulong ul)
        {
            return default;
        }

        public static byte ToByte(ulong ul)
        {
            return default;
        }
    }


    public static class UshortCaster
    {
        public static int ToInt(ushort us)
        {
            return default;
        }

        public static long ToLong(ushort us)
        {
            return default;
        }

        public static short ToShort(ushort us)
        {
            return default;
        }

        public static double ToDouble(ushort us)
        {
            return default;
        }

        public static float ToFloat(ushort us)
        {
            return default;
        }

        public static decimal ToDecimal(ushort us)
        {
            return default;
        }

        public static uint ToUint(ushort us)
        {
            return default;
        }

        public static ulong ToUlong(ushort us)
        {
            return default;
        }

        public static ushort ToUshort(ushort us)
        {
            return default;
        }

        public static sbyte ToSbyte(ushort us)
        {
            return default;
        }

        public static byte ToByte(ushort us)
        {
            return default;
        }
    }


    public static class SbyteCaster
    {
        public static int ToInt(sbyte sb)
        {
            return sb;
        }

        public static long ToLong(sbyte sb)
        {
            return sb;
        }

        public static short ToShort(sbyte sb)
        {
            return sb;
        }

        public static double ToDouble(sbyte sb)
        {
            return sb;
        }

        public static float ToFloat(sbyte sb)
        {
            return sb;
        }

        public static decimal ToDecimal(sbyte sb)
        {
            return sb;
        }

        public static uint ToUint(sbyte sb)
        {
            if (sb < (int)uint.MinValue)
                return uint.MinValue;
            else
                return (uint)sb;
        }

        public static ulong ToUlong(sbyte sb)
        {
            if (sb < (int)ulong.MinValue)
                return ulong.MinValue;
            else
                return (ulong)sb;
        }

        public static ushort ToUshort(sbyte sb)
        {
            if (sb < ushort.MinValue)
                return ushort.MinValue;
            else
                return (ushort)sb;
        }

        public static byte ToByte(sbyte sb)
        {
            if (sb < byte.MinValue)
                return byte.MinValue;
            return (byte)sb;
        }
    }


    public static class ByteCaster
    {
        public static int ToInt(byte bt)
        {
            return bt;
        }

        public static long ToLong(byte bt)
        {
            return bt;
        }

        public static short ToShort(byte bt)
        {
            return bt;
        }

        public static double ToDouble(byte bt)
        {
            return bt;
        }

        public static float ToFloat(byte bt)
        {
            return bt;
        }

        public static decimal ToDecimal(byte bt)
        {
            return bt;
        }

        public static uint ToUint(byte bt)
        {
            return bt;
        }

        public static ulong ToUlong(byte bt)
        {
            return bt;
        }

        public static ushort ToUshort(byte bt)
        {
            return bt;
        }

        public static sbyte ToSbyte(byte bt)
        {
            if (bt > sbyte.MaxValue)
                return sbyte.MaxValue;
            else
                return (sbyte)bt;
        }
    }
}

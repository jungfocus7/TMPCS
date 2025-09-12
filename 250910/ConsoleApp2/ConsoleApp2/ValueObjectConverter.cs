using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public static class ValueObjectConverter
    {
        //~~~~
        //TypeCode.Int32, TypeCode.Int64, TypeCode.Int16,
        //TypeCode.Double, TypeCode.Single, TypeCode.Decimal,
        //TypeCode.UInt32, TypeCode.UInt64, TypeCode.UInt16,
        //TypeCode.SByte, TypeCode.Byte,

        //~~~~
        //int, long, short,
        //double, float, decimal,
        //uint, ulong, ushort,
        //sbyte, byte,


        public static int Get_int(object vo, int dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                return vn;
            }
            else if (vo is long vl)
            {
                if (vl > int.MaxValue)
                    return int.MaxValue;
                else if (vl < int.MinValue)
                    return int.MinValue;
                else
                    return (int)vl;
            }
            else if (vo is short vs)
            {
                return vs;
            }

            else if (vo is double vd)
            {
                if (vd > int.MaxValue)
                    return int.MaxValue;
                else if (vd < int.MinValue)
                    return int.MinValue;
                else
                    return (int)vd;
            }
            else if (vo is float vf)
            {
                if (vf > int.MaxValue)
                    return int.MaxValue;
                else if (vf < int.MinValue)
                    return int.MinValue;
                else
                    return (int)vf;
            }
            else if (vo is decimal vm)
            {
                if (vm > int.MaxValue)
                    return int.MaxValue;
                else if (vm < int.MinValue)
                    return int.MinValue;
                else
                    return (int)vm;
            }

            else if (vo is uint un)
            {
                if (un > int.MaxValue)
                    return int.MaxValue;
                else
                    return (int)un;
            }
            else if (vo is ulong ul)
            {
                if (ul > int.MaxValue)
                    return int.MaxValue;
                else
                    return (int)ul;
            }
            else if (vo is ushort us)
            {
                return us;
            }

            else if (vo is sbyte sb)
            {
                return sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return dv;
        }

        public static long Get_long(object vo, long dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                return vn;
            }
            else if (vo is long vl)
            {
                return vl;
            }
            else if (vo is short vs)
            {
                return vs;
            }

            else if (vo is double vd)
            {
                if (vd > long.MaxValue)
                    return long.MaxValue;
                else if (vd < long.MinValue)
                    return long.MinValue;
                else
                    return (long)vd;
            }
            else if (vo is float vf)
            {
                if (vf > long.MaxValue)
                    return long.MaxValue;
                else if (vf < long.MinValue)
                    return long.MinValue;
                else
                    return (long)vf;
            }
            else if (vo is decimal vm)
            {
                if (vm > long.MaxValue)
                    return long.MaxValue;
                else if (vm < long.MinValue)
                    return long.MinValue;
                else
                    return (long)vm;
            }

            else if (vo is uint un)
            {
                return un;
            }
            else if (vo is ulong ul)
            {
                if (ul > long.MaxValue)
                    return long.MaxValue;
                else
                    return (long)ul;
            }
            else if (vo is ushort us)
            {
                return us;
            }

            else if (vo is sbyte sb)
            {
                return sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return dv;
        }

        public static short Get_short(object vo, short dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                if (vn > short.MaxValue)
                    return short.MaxValue;
                else if (vn < short.MinValue)
                    return short.MinValue;
                else
                    return (short)vn;
            }
            else if (vo is long vl)
            {
                if (vl > short.MaxValue)
                    return short.MaxValue;
                else if (vl < short.MinValue)
                    return short.MinValue;
                else
                    return (short)vl;
            }
            else if (vo is short vs)
            {
                return vs;
            }

            else if (vo is double vd)
            {
                if (vd > short.MaxValue)
                    return short.MaxValue;
                else if (vd < short.MinValue)
                    return short.MinValue;
                else
                    return (short)vd;
            }
            else if (vo is float vf)
            {
                if (vf > short.MaxValue)
                    return short.MaxValue;
                else if (vf < short.MinValue)
                    return short.MinValue;
                else
                    return (short)vf;
            }
            else if (vo is decimal vm)
            {
                if (vm > short.MaxValue)
                    return short.MaxValue;
                else if (vm < short.MinValue)
                    return short.MinValue;
                else
                    return (short)vm;
            }

            else if (vo is uint un)
            {
                if (un > short.MaxValue)
                    return short.MaxValue;
                else
                    return (short)un;
            }
            else if (vo is ulong ul)
            {
                return (short)ul;
            }
            else if (vo is ushort us)
            {
                if (us > short.MaxValue)
                    return short.MaxValue;
                else
                    return (short)us;
            }

            else if (vo is sbyte sb)
            {
                return sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return dv;
        }


        public static double Get_double(object vo, double dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                return vn;
            }
            else if (vo is long vl)
            {
                return vl;
            }
            else if (vo is short vs)
            {
                return vs;
            }

            else if (vo is double vd)
            {
                return vd;
            }
            else if (vo is float vf)
            {
                return vf;
            }
            else if (vo is decimal vm)
            {
                if ((double)vm > double.MaxValue)
                    return double.MaxValue;
                else if ((double)vm < double.MinValue)
                    return double.MinValue;
                else
                    return (double)vm;
            }

            else if (vo is uint un)
            {
                return un;
            }
            else if (vo is ulong ul)
            {
                return ul;
            }
            else if (vo is ushort us)
            {
                return us;
            }

            else if (vo is sbyte sb)
            {
                return sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return dv;
        }

        public static float Get_float(object vo, float dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                return vn;
            }
            else if (vo is long vl)
            {
                return vl;
            }
            else if (vo is short vs)
            {
                return vs;
            }

            else if (vo is double vd)
            {
                if (vd > float.MaxValue)
                    return float.MaxValue;
                else if (vd < float.MinValue)
                    return float.MinValue;
                else
                    return (float)vd;
            }
            else if (vo is float vf)
            {
                return vf;
            }
            else if (vo is decimal vm)
            {
                if ((float)vm > float.MaxValue)
                    return float.MaxValue;
                else if ((float)vm < float.MinValue)
                    return float.MinValue;
                else
                    return (float)vm;
            }

            else if (vo is uint un)
            {
                return un;
            }
            else if (vo is ulong ul)
            {
                return ul;
            }
            else if (vo is ushort us)
            {
                return us;
            }

            else if (vo is sbyte sb)
            {
                return sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return dv;
        }

        public static decimal Get_decimal(object vo, decimal dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                return vn;
            }
            else if (vo is long vl)
            {
                return vl;
            }
            else if (vo is short vs)
            {
                return vs;
            }

            else if (vo is double vd)
            {
                if (vd > (double)decimal.MaxValue)
                    return decimal.MaxValue;
                else if (vd < (double)decimal.MinValue)
                    return decimal.MinValue;
                else
                    return (decimal)vd;
            }
            else if (vo is float vf)
            {
                if (vf > (float)decimal.MaxValue)
                    return decimal.MaxValue;
                else if (vf < (float)decimal.MinValue)
                    return decimal.MinValue;
                else
                    return (decimal)vf;
            }
            else if (vo is decimal vm)
            {
                return vm;
            }

            else if (vo is uint un)
            {
                return un;
            }
            else if (vo is ulong ul)
            {
                return ul;
            }
            else if (vo is ushort us)
            {
                return us;
            }

            else if (vo is sbyte sb)
            {
                return sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return dv;
        }


        public static uint Get_uint(object vo, uint dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                if (vn < uint.MinValue)
                    return uint.MinValue;
                else
                    return (uint)vn;
            }
            else if (vo is long vl)
            {
                if (vl > uint.MaxValue)
                    return uint.MaxValue;
                else if (vl < uint.MinValue)
                    return uint.MinValue;
                else
                    return (uint)vl;
            }
            else if (vo is short vs)
            {
                if (vs < uint.MinValue)
                    return uint.MinValue;
                else
                    return (uint)vs;
            }

            else if (vo is double vd)
            {
                if (vd > uint.MaxValue)
                    return uint.MaxValue;
                else if (vd < uint.MinValue)
                    return uint.MinValue;
                else
                    return (uint)vd;
            }
            else if (vo is float vf)
            {
                if (vf > uint.MaxValue)
                    return uint.MaxValue;
                else if (vf < uint.MinValue)
                    return uint.MinValue;
                else
                    return (uint)vf;
            }
            else if (vo is decimal vm)
            {
                if (vm > uint.MaxValue)
                    return uint.MaxValue;
                else if (vm < uint.MinValue)
                    return uint.MinValue;
                else
                    return (uint)vm;
            }

            else if (vo is uint un)
            {
                return un;
            }
            else if (vo is ulong ul)
            {
                if (ul > uint.MaxValue)
                    return uint.MaxValue;
                else
                    return (uint)ul;
            }
            else if (vo is ushort us)
            {
                return us;
            }

            else if (vo is sbyte sb)
            {
                if ((uint)sb < uint.MinValue)
                    return uint.MinValue;
                else
                    return (uint)sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return default;
        }

        public static ulong Get_ulong(object vo, ulong dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                if (vn < (int)ulong.MinValue)
                    return ulong.MinValue;
                else
                    return (ulong)vn;
            }
            else if (vo is long vl)
            {
                if (vl < (int)ulong.MinValue)
                    return ulong.MinValue;
                else
                    return (ulong)vl;
            }
            else if (vo is short vs)
            {
                if (vs < (int)ulong.MinValue)
                    return ulong.MinValue;
                else
                    return (ulong)vs;
            }

            else if (vo is double vd)
            {
                if (vd > ulong.MaxValue)
                    return ulong.MaxValue;
                else if (vd < ulong.MinValue)
                    return ulong.MinValue;
                else
                    return (ulong)vd;
            }
            else if (vo is float vf)
            {
                if (vf > ulong.MaxValue)
                    return ulong.MaxValue;
                else if (vf < ulong.MinValue)
                    return ulong.MinValue;
                else
                    return (ulong)vf;
            }
            else if (vo is decimal vm)
            {
                if (vm > ulong.MaxValue)
                    return ulong.MaxValue;
                else if (vm < ulong.MinValue)
                    return ulong.MinValue;
                else
                    return (ulong)vm;
            }

            else if (vo is uint un)
            {
                return un;
            }
            else if (vo is ulong ul)
            {
                return ul;
            }
            else if (vo is ushort us)
            {
                return us;
            }

            else if (vo is sbyte sb)
            {
                if (sb < (int)ulong.MinValue)
                    return ulong.MinValue;
                else
                    return (ulong)sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return default;
        }

        public static ushort Get_ushort(object vo, ushort dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                if (vn > ushort.MaxValue)
                    return ushort.MaxValue;
                else if (vn < ushort.MinValue)
                    return ushort.MinValue;
                else
                    return (ushort)vn;
            }
            else if (vo is long vl)
            {
                if (vl > ushort.MaxValue)
                    return ushort.MaxValue;
                else if (vl < ushort.MinValue)
                    return ushort.MinValue;
                else
                    return (ushort)vl;
            }
            else if (vo is short vs)
            {
                if (vs < ushort.MinValue)
                    return ushort.MinValue;
                else
                    return (ushort)vs;
            }

            else if (vo is double vd)
            {
                if (vd > ushort.MaxValue)
                    return ushort.MaxValue;
                else if (vd < ushort.MinValue)
                    return ushort.MinValue;
                else
                    return (ushort)vd;
            }
            else if (vo is float vf)
            {
                if (vf > ushort.MaxValue)
                    return ushort.MaxValue;
                else if (vf < ushort.MinValue)
                    return ushort.MinValue;
                else
                    return (ushort)vf;
            }
            else if (vo is decimal vm)
            {
                if (vm > ushort.MaxValue)
                    return ushort.MaxValue;
                else if (vm < ushort.MinValue)
                    return ushort.MinValue;
                else
                    return (ushort)vm;
            }

            else if (vo is uint un)
            {
                if (un > ushort.MaxValue)
                    return ushort.MaxValue;
                else
                    return (ushort)un;
            }
            else if (vo is ulong ul)
            {
                if (ul > ushort.MaxValue)
                    return ushort.MaxValue;
                else
                    return (ushort)ul;
            }
            else if (vo is ushort us)
            {
                return us;
            }

            else if (vo is sbyte sb)
            {
                if (sb < ushort.MinValue)
                    return ushort.MinValue;
                else
                    return (ushort)sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return default;
        }

        public static sbyte Get_sbyte(object vo, sbyte dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                if (vn > sbyte.MaxValue)
                    return sbyte.MaxValue;
                else if (vn < sbyte.MinValue)
                    return sbyte.MinValue;
                else
                    return (sbyte)vn;
            }
            else if (vo is long vl)
            {
                if (vl > sbyte.MaxValue)
                    return sbyte.MaxValue;
                else if (vl < sbyte.MinValue)
                    return sbyte.MinValue;
                else
                    return (sbyte)vl;
            }
            else if (vo is short vs)
            {
                if (vs > sbyte.MaxValue)
                    return sbyte.MaxValue;
                else if (vs < sbyte.MinValue)
                    return sbyte.MinValue;
                else
                    return (sbyte)vs;
            }

            else if (vo is double vd)
            {
                if (vd > sbyte.MaxValue)
                    return sbyte.MaxValue;
                else if (vd < sbyte.MinValue)
                    return sbyte.MinValue;
                else
                    return (sbyte)vd;
            }
            else if (vo is float vf)
            {
                if (vf > sbyte.MaxValue)
                    return sbyte.MaxValue;
                else if (vf < sbyte.MinValue)
                    return sbyte.MinValue;
                else
                    return (sbyte)vf;
            }
            else if (vo is decimal vm)
            {
                if (vm > sbyte.MaxValue)
                    return sbyte.MaxValue;
                else if (vm < sbyte.MinValue)
                    return sbyte.MinValue;
                else
                    return (sbyte)vm;
            }

            else if (vo is uint un)
            {
                if (un > sbyte.MaxValue)
                    return sbyte.MaxValue;
                else
                    return (sbyte)un;
            }
            else if (vo is ulong ul)
            {
                if (ul > (int)sbyte.MaxValue)
                    return sbyte.MaxValue;
                else
                    return (sbyte)ul;
            }
            else if (vo is ushort us)
            {
                if (us > sbyte.MaxValue)
                    return sbyte.MaxValue;
                else
                    return (sbyte)us;
            }

            else if (vo is sbyte sb)
            {
                return sb;
            }
            else if (vo is byte bt)
            {
                if (bt > sbyte.MaxValue)
                    return sbyte.MaxValue;
                else
                    return (sbyte)bt;
            }

            return default;
        }

        public static byte Get_byte(object vo, byte dv = default)
        {
            if (vo == null)
            {
                return dv;
            }

            else if (vo is int vn)
            {
                if (vn > byte.MaxValue)
                    return byte.MaxValue;
                else if (vn < byte.MinValue)
                    return byte.MinValue;
                else
                    return (byte)vn;
            }
            else if (vo is long vl)
            {
                if (vl > byte.MaxValue)
                    return byte.MaxValue;
                else if (vl < byte.MinValue)
                    return byte.MinValue;
                else
                    return (byte)vl;
            }
            else if (vo is short vs)
            {
                if (vs > byte.MaxValue)
                    return byte.MaxValue;
                else if (vs < byte.MinValue)
                    return byte.MinValue;
                else
                    return (byte)vs;
            }

            else if (vo is double vd)
            {
                if (vd > byte.MaxValue)
                    return byte.MaxValue;
                else if (vd < byte.MinValue)
                    return byte.MinValue;
                else
                    return (byte)vd;
            }
            else if (vo is float vf)
            {
                if (vf > byte.MaxValue)
                    return byte.MaxValue;
                else if (vf < byte.MinValue)
                    return byte.MinValue;
                else
                    return (byte)vf;
            }
            else if (vo is decimal vm)
            {
                if (vm > byte.MaxValue)
                    return byte.MaxValue;
                else if (vm < byte.MinValue)
                    return byte.MinValue;
                else
                    return (byte)vm;
            }

            else if (vo is uint un)
            {
                if (un > byte.MaxValue)
                    return byte.MaxValue;
                else
                    return (byte)un;
            }
            else if (vo is ulong ul)
            {
                if (ul > byte.MaxValue)
                    return byte.MaxValue;
                else
                    return (byte)ul;
            }
            else if (vo is ushort us)
            {
                if (us > byte.MaxValue)
                    return byte.MaxValue;
                else
                    return (byte)us;
            }

            else if (vo is sbyte sb)
            {
                if (sb < byte.MinValue)
                    return byte.MinValue;
                return (byte)sb;
            }
            else if (vo is byte bt)
            {
                return bt;
            }

            return default;
        }


        public static T GetValue<T>(object vo, T dv = default) where T : struct
        {
            T rv = default;

            TypeCode tpc = Type.GetTypeCode(typeof(T));
            switch (tpc)
            {
                case TypeCode.Int32:
                {
                    break;
                }
            }

            return rv;
        }
    }
}

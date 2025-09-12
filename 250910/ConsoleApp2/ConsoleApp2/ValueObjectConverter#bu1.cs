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


        public static int GetInt32(object vo, int dv = default)
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

        public static long GetInt64(object vo, long dv = default)
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

        public static short GetInt16(object vo, short dv = default)
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

        public static double GetDouble(object vo, double dv = default)
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

        public static float GetSingle(object vo, float dv = default)
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

        public static decimal GetDecimal(object vo, decimal dv = default)
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
                if ((decimal)vd > decimal.MaxValue)
                    return decimal.MaxValue;
                else if ((decimal)vd < decimal.MinValue)
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

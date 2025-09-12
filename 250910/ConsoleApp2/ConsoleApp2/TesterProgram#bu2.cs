using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public static class TesterProgram
    {
        public static void Main(string[] args)
        {
            long vl = long.MaxValue;
            int vn = (int)vl;
            object vo = vn;
            byte vb = (byte)vn;

            //DataTable tdt = new DataTable("RESULT");
            //var x0 = Convert.GetTypeCode(tdt);
            //var x1 = Convert.GetTypeCode("xxx");

            /*
            var y31 = GetValue<DateTime>(null);
            var y32 = GetValue<int>(null);
            var y33 = GetValue<float>(null);
            var y34 = GetValue<char>(null);
            var y35 = GetValue<int>(double.MaxValue, 335);
            */
        }






        //private static readonly TypeCode[] _tpcNumArr = new TypeCode[]
        //{
        //    TypeCode.Int32, TypeCode.Int64, TypeCode.Int16,
        //    TypeCode.UInt32, TypeCode.UInt64, TypeCode.UInt16,
        //    TypeCode.Double, TypeCode.Single, TypeCode.Decimal,
        //    TypeCode.SByte, TypeCode.Byte,
        //};
        //private static bool IsNumeric(object vo)
        //{
        //    TypeCode tpc = Convert.GetTypeCode(vo);
        //    return Array.IndexOf(_tpcNumArr, tpc) > -1;
        //}

        //private static int GetInt32()
        //{

        //}

        //private static T GetValue<T>(object vo, T dv = default) where T : struct
        //{
        //    T rv = default;

        //    TypeCode tpc = Type.GetTypeCode(typeof(T));
        //    switch (tpc)
        //    {
        //        case TypeCode.Int32:
        //        {
        //            break;
        //        }
        //    }

        //    return rv;


        //    try
        //    {
        //        return (T)vo;
        //    }
        //    catch
        //    {
        //        return dv;
        //    }
        //}

        //private static T GetValue<T>(object vo, T dv = default) where T : struct
        //{
        //    if (IsNumeric(vo))
        //    {
        //        return (T)vo;
        //    }
        //    else
        //    {
        //        return dv;
        //    }
        //}

        //private static int GetInt32(object vo)
        //{
        //    int rv = default;

        //    if (vo == null)
        //    {
        //        return rv;
        //    }
        //    else if (vo is int vn)
        //    {
        //        rv = vn;
        //        return rv;
        //    }
        //    else if (vo is long vl)
        //    {
        //        if (vl > int.MaxValue)
        //            rv = int.MaxValue;
        //        else if (vl < int.MinValue)
        //            rv = int.MinValue;
        //        else
        //            rv = (int)vl;
        //        return rv;
        //    }
        //    else if (vo is short vs)
        //    {
        //        rv = vs;
        //        return rv;
        //    }
        //    else if (vo is float vf)
        //    {
        //        if (vf > int.MaxValue)
        //            rv = int.MaxValue;
        //        else if (vl < int.MinValue)
        //            rv = int.MinValue;
        //        else
        //            rv = (int)vl;

        //        rv = vf;
        //        return rv;
        //    }
        //    else
        //    {
        //        return rv;
        //    }

        //    //if (IsNumeric(Convert.GetTypeCode(vo)))
        //    //{

        //    //}

        //    //    TypeCode tpc = Convert.GetTypeCode(vo);
        //    //if (tpc == TypeCode.)

        //    //return default;
        //}

    }
}

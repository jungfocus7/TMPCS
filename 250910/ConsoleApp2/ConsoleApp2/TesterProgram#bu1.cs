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

            DataTable tdt = new DataTable("RESULT");
            var x0 = Convert.GetTypeCode(tdt);
            var x1 = Convert.GetTypeCode("xxx");
        }

        private static readonly TypeCode[] _tpcNumArr = new TypeCode[]
        {
            TypeCode.Int32, TypeCode.Int64, TypeCode.Int16,
            TypeCode.UInt32, TypeCode.UInt64, TypeCode.UInt16,
            TypeCode.Double, TypeCode.Single, TypeCode.Decimal,
        };
        private static bool IsNumeric(object vo)
        {
            if (vo == null) return false;
            TypeCode tpc = Convert.GetTypeCode(vo);
            return Array.IndexOf(_tpcNumArr, tpc) > -1;

            //return 
            //    (tpc == TypeCode.Int32) || (tpc == TypeCode.Int64) || (tpc == TypeCode.Int16) ||
            //    (tpc == TypeCode.UInt32) || (tpc == TypeCode.UInt64) || (tpc == TypeCode.UInt16) ||
            //    (tpc == TypeCode.Double) || (tpc == TypeCode.Single) || (tpc == TypeCode.Decimal)
            //    ;

            //if (tpc == TypeCode.Int32) return true;
            //if (tpc == TypeCode.Int64) return true;
            //if (tpc == TypeCode.Int16) return true;
            //if (tpc == TypeCode.UInt32) return true;
            //if (tpc == TypeCode.UInt64) return true;
            //if (tpc == TypeCode.UInt16) return true;
        }

        private static int GetInt32(object vo)
        {
            if (vo == null) return default;
            if (IsNumeric(vo))

            //    TypeCode tpc = Convert.GetTypeCode(vo);
            //if (tpc == TypeCode.)

            return default;
        }

    }
}

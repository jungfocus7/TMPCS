using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public static class TesterProgram
    {
        public static void Main(string[] args)
        {
            TesterPointer31();
        }

        private static void PrintOut(string msg)
        {
            Debug.WriteLine(msg);
        }

        private static void TesterPointer31()
        {
            bool b1 = double.MaxValue > (double)decimal.MaxValue;

            unchecked
            {
                ulong x0 = (ulong)float.PositiveInfinity;
                ulong x1 = (ulong)float.NegativeInfinity;
                ulong x2 = (ulong)float.MaxValue;
            }

            //Math.Clamp()

            //bool bx = float.MaxValue > ulong.MaxValue;
            //var x0 = (ulong)Math.Round(float.MaxValue, MidpointRounding.AwayFromZero);
            //var x1 = "";

            //int, long, short,
            //double, float, decimal,
            //uint, ulong, ushort,
            //sbyte, byte,

            /*
            TestCodeGenerate("int");
            TestCodeGenerate("long");
            TestCodeGenerate("short");

            TestCodeGenerate("double");
            TestCodeGenerate("float");
            TestCodeGenerate("decimal");

            TestCodeGenerate("uint");
            TestCodeGenerate("ulong");
            TestCodeGenerate("ushort");

            TestCodeGenerate("sbyte");
            TestCodeGenerate("byte");
            */


            Test_int();
            Test_long();
            Test_short();

            Test_double();
            Test_float();
            Test_decimal();

            Test_uint();
            Test_ulong();
            Test_ushort();

            Test_sbyte();
            Test_byte();
        }


        private static void TestCodeGenerate(string dtnm)
        {
            StringBuilder rsb = new StringBuilder();

            rsb.AppendLine($"bool b00 = int.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"bool b01 = long.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"bool b02 = short.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"PrintOut($\"int.MaxValue > {dtnm}.MaxValue = {{b00}}\");");
            rsb.AppendLine($"PrintOut($\"long.MaxValue > {dtnm}.MaxValue = {{b01}}\");");
            rsb.AppendLine($"PrintOut($\"short.MaxValue > {dtnm}.MaxValue = {{b02}}\");");
            rsb.AppendLine("PrintOut(string.Empty);");
            rsb.AppendLine();

            rsb.AppendLine($"bool b03 = double.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"bool b04 = float.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"bool b05 = decimal.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"PrintOut($\"double.MaxValue > {dtnm}.MaxValue = {{b03}}\");");
            rsb.AppendLine($"PrintOut($\"float.MaxValue > {dtnm}.MaxValue = {{b04}}\");");
            rsb.AppendLine($"PrintOut($\"decimal.MaxValue > {dtnm}.MaxValue = {{b05}}\");");
            rsb.AppendLine("PrintOut(string.Empty);");
            rsb.AppendLine();

            rsb.AppendLine($"bool b06 = uint.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"bool b07 = ulong.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"bool b08 = ushort.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"PrintOut($\"uint.MaxValue > {dtnm}.MaxValue = {{b06}}\");");
            rsb.AppendLine($"PrintOut($\"ulong.MaxValue > {dtnm}.MaxValue = {{b07}}\");");
            rsb.AppendLine($"PrintOut($\"ushort.MaxValue > {dtnm}.MaxValue = {{b08}}\");");
            rsb.AppendLine("PrintOut(string.Empty);");
            rsb.AppendLine();

            rsb.AppendLine($"bool b09 = sbyte.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"bool b10 = byte.MaxValue > {dtnm}.MaxValue;");
            rsb.AppendLine($"PrintOut($\"sbyte.MaxValue > {dtnm}.MaxValue = {{b09}}\");");
            rsb.AppendLine($"PrintOut($\"byte.MaxValue > {dtnm}.MaxValue = {{b10}}\");");
            rsb.AppendLine("PrintOut(string.Empty);");
            rsb.AppendLine();

            string rs = rsb.ToString();
            PrintOut(rs);
        }


        private static void Test_int()
        {
            //bool b00 = int.MaxValue > int.MaxValue;
            bool b01 = long.MaxValue > int.MaxValue;
            bool b02 = short.MaxValue > int.MaxValue;
            //PrintOut($"int.MaxValue > int.MaxValue = {b00}");
            PrintOut($"long.MaxValue > int.MaxValue = {b01}");
            PrintOut($"short.MaxValue > int.MaxValue = {b02}");
            PrintOut(string.Empty);

            bool b03 = double.MaxValue > int.MaxValue;
            bool b04 = float.MaxValue > int.MaxValue;
            bool b05 = decimal.MaxValue > int.MaxValue;
            PrintOut($"double.MaxValue > int.MaxValue = {b03}");
            PrintOut($"float.MaxValue > int.MaxValue = {b04}");
            PrintOut($"decimal.MaxValue > int.MaxValue = {b05}");
            PrintOut(string.Empty);

            bool b06 = uint.MaxValue > int.MaxValue;
            bool b07 = ulong.MaxValue > int.MaxValue;
            bool b08 = ushort.MaxValue > int.MaxValue;
            PrintOut($"uint.MaxValue > int.MaxValue = {b06}");
            PrintOut($"ulong.MaxValue > int.MaxValue = {b07}");
            PrintOut($"ushort.MaxValue > int.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = sbyte.MaxValue > int.MaxValue;
            bool b10 = byte.MaxValue > int.MaxValue;
            PrintOut($"sbyte.MaxValue > int.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > int.MaxValue = {b10}");
            PrintOut(string.Empty);
        }
        private static void Test_long()
        {
            bool b00 = int.MaxValue > long.MaxValue;
            //bool b01 = long.MaxValue > long.MaxValue;
            bool b02 = short.MaxValue > long.MaxValue;
            PrintOut($"int.MaxValue > long.MaxValue = {b00}");
            //PrintOut($"long.MaxValue > long.MaxValue = {b01}");
            PrintOut($"short.MaxValue > long.MaxValue = {b02}");
            PrintOut(string.Empty);

            bool b03 = double.MaxValue > long.MaxValue;
            bool b04 = float.MaxValue > long.MaxValue;
            bool b05 = decimal.MaxValue > long.MaxValue;
            PrintOut($"double.MaxValue > long.MaxValue = {b03}");
            PrintOut($"float.MaxValue > long.MaxValue = {b04}");
            PrintOut($"decimal.MaxValue > long.MaxValue = {b05}");
            PrintOut(string.Empty);

            bool b06 = uint.MaxValue > long.MaxValue;
            bool b07 = ulong.MaxValue > long.MaxValue;
            bool b08 = ushort.MaxValue > long.MaxValue;
            PrintOut($"uint.MaxValue > long.MaxValue = {b06}");
            PrintOut($"ulong.MaxValue > long.MaxValue = {b07}");
            PrintOut($"ushort.MaxValue > long.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = sbyte.MaxValue > long.MaxValue;
            bool b10 = byte.MaxValue > long.MaxValue;
            PrintOut($"sbyte.MaxValue > long.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > long.MaxValue = {b10}");
            PrintOut(string.Empty);
        }
        private static void Test_short()
        {
            bool b00 = int.MaxValue > short.MaxValue;
            bool b01 = long.MaxValue > short.MaxValue;
            //bool b02 = short.MaxValue > short.MaxValue;
            PrintOut($"int.MaxValue > short.MaxValue = {b00}");
            PrintOut($"long.MaxValue > short.MaxValue = {b01}");
            //PrintOut($"short.MaxValue > short.MaxValue = {b02}");
            PrintOut(string.Empty);

            bool b03 = double.MaxValue > short.MaxValue;
            bool b04 = float.MaxValue > short.MaxValue;
            bool b05 = decimal.MaxValue > short.MaxValue;
            PrintOut($"double.MaxValue > short.MaxValue = {b03}");
            PrintOut($"float.MaxValue > short.MaxValue = {b04}");
            PrintOut($"decimal.MaxValue > short.MaxValue = {b05}");
            PrintOut(string.Empty);

            bool b06 = uint.MaxValue > short.MaxValue;
            bool b07 = ulong.MaxValue > (ulong)short.MaxValue;
            bool b07__ = (double)ulong.MaxValue > (long)short.MinValue;
            bool b08 = ushort.MaxValue > short.MaxValue;
            PrintOut($"uint.MaxValue > short.MaxValue = {b06}");
            PrintOut($"ulong.MaxValue > (ulong)short.MaxValue = {b07}");
            PrintOut($"ushort.MaxValue > short.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = sbyte.MaxValue > short.MaxValue;
            bool b10 = byte.MaxValue > short.MaxValue;
            PrintOut($"sbyte.MaxValue > short.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > short.MaxValue = {b10}");
            PrintOut(string.Empty);
        }

        private static void Test_double()
        {
            bool b00 = int.MaxValue > double.MaxValue;
            bool b01 = long.MaxValue > double.MaxValue;
            bool b02 = short.MaxValue > double.MaxValue;
            PrintOut($"int.MaxValue > double.MaxValue = {b00}");
            PrintOut($"long.MaxValue > double.MaxValue = {b01}");
            PrintOut($"short.MaxValue > double.MaxValue = {b02}");
            PrintOut(string.Empty);

            //bool b03 = double.MaxValue > double.MaxValue;
            bool b04 = float.MaxValue > double.MaxValue;
            bool b05 = (double)decimal.MaxValue > double.MaxValue;
            //PrintOut($"double.MaxValue > double.MaxValue = {b03}");
            PrintOut($"float.MaxValue > double.MaxValue = {b04}");
            PrintOut($"decimal.MaxValue > double.MaxValue = {b05}");
            PrintOut(string.Empty);

            bool b06 = uint.MaxValue > double.MaxValue;
            bool b07 = ulong.MaxValue > double.MaxValue;
            bool b08 = ushort.MaxValue > double.MaxValue;
            PrintOut($"uint.MaxValue > double.MaxValue = {b06}");
            PrintOut($"ulong.MaxValue > double.MaxValue = {b07}");
            PrintOut($"ushort.MaxValue > double.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = sbyte.MaxValue > double.MaxValue;
            bool b10 = byte.MaxValue > double.MaxValue;
            PrintOut($"sbyte.MaxValue > double.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > double.MaxValue = {b10}");
            PrintOut(string.Empty);
        }
        private static void Test_float()
        {
            bool b00 = int.MaxValue > float.MaxValue;
            bool b01 = long.MaxValue > float.MaxValue;
            bool b02 = short.MaxValue > float.MaxValue;
            PrintOut($"int.MaxValue > float.MaxValue = {b00}");
            PrintOut($"long.MaxValue > float.MaxValue = {b01}");
            PrintOut($"short.MaxValue > float.MaxValue = {b02}");
            PrintOut(string.Empty);

            bool b03 = double.MaxValue > float.MaxValue;
            //bool b04 = float.MaxValue > float.MaxValue;
            bool b05 = (float)decimal.MaxValue > float.MaxValue;
            PrintOut($"double.MaxValue > float.MaxValue = {b03}");
            //PrintOut($"float.MaxValue > float.MaxValue = {b04}");
            PrintOut($"(float)decimal.MaxValue > float.MaxValue = {b05}");
            PrintOut(string.Empty);

            bool b06 = uint.MaxValue > float.MaxValue;
            bool b07 = ulong.MaxValue > float.MaxValue;
            bool b08 = ushort.MaxValue > float.MaxValue;
            PrintOut($"uint.MaxValue > float.MaxValue = {b06}");
            PrintOut($"ulong.MaxValue > float.MaxValue = {b07}");
            PrintOut($"ushort.MaxValue > float.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = sbyte.MaxValue > float.MaxValue;
            bool b10 = byte.MaxValue > float.MaxValue;
            PrintOut($"sbyte.MaxValue > float.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > float.MaxValue = {b10}");
            PrintOut(string.Empty);
        }
        private static void Test_decimal()
        {
            bool b00 = int.MaxValue > decimal.MaxValue;
            bool b01 = long.MaxValue > decimal.MaxValue;
            bool b02 = short.MaxValue > decimal.MaxValue;
            PrintOut($"int.MaxValue > decimal.MaxValue = {b00}");
            PrintOut($"long.MaxValue > decimal.MaxValue = {b01}");
            PrintOut($"short.MaxValue > decimal.MaxValue = {b02}");
            PrintOut(string.Empty);

            bool b03 = double.MaxValue > (double)decimal.MaxValue;
            bool b04 = float.MaxValue > (float)decimal.MaxValue;
            //bool b05 = decimal.MaxValue > decimal.MaxValue;
            PrintOut($"double.MaxValue > decimal.MaxValue = {b03}");
            PrintOut($"float.MaxValue > decimal.MaxValue = {b04}");
            //PrintOut($"decimal.MaxValue > decimal.MaxValue = {b05}");
            PrintOut(string.Empty);

            bool b06 = uint.MaxValue > decimal.MaxValue;
            bool b07 = ulong.MaxValue > decimal.MaxValue;
            bool b08 = ushort.MaxValue > decimal.MaxValue;
            PrintOut($"uint.MaxValue > decimal.MaxValue = {b06}");
            PrintOut($"ulong.MaxValue > decimal.MaxValue = {b07}");
            PrintOut($"ushort.MaxValue > decimal.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = sbyte.MaxValue > decimal.MaxValue;
            bool b10 = byte.MaxValue > decimal.MaxValue;
            PrintOut($"sbyte.MaxValue > decimal.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > decimal.MaxValue = {b10}");
            PrintOut(string.Empty);
        }

        private static void Test_uint()
        {
            bool b00 = int.MaxValue > uint.MaxValue;
            bool b01 = long.MaxValue > uint.MaxValue;
            bool b02 = short.MaxValue > uint.MaxValue;
            PrintOut($"int.MaxValue > uint.MaxValue = {b00}");
            PrintOut($"long.MaxValue > uint.MaxValue = {b01}");
            PrintOut($"short.MaxValue > uint.MaxValue = {b02}");
            PrintOut(string.Empty);

            bool b03 = double.MaxValue > uint.MaxValue;
            bool b04 = float.MaxValue > uint.MaxValue;
            bool b05 = decimal.MaxValue > uint.MaxValue;
            PrintOut($"double.MaxValue > uint.MaxValue = {b03}");
            PrintOut($"float.MaxValue > uint.MaxValue = {b04}");
            PrintOut($"decimal.MaxValue > uint.MaxValue = {b05}");
            PrintOut(string.Empty);

            //bool b06 = uint.MaxValue > uint.MaxValue;
            bool b07 = ulong.MaxValue > uint.MaxValue;
            bool b08 = ushort.MaxValue > uint.MaxValue;
            //PrintOut($"uint.MaxValue > uint.MaxValue = {b06}");
            PrintOut($"ulong.MaxValue > uint.MaxValue = {b07}");
            PrintOut($"ushort.MaxValue > uint.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = sbyte.MaxValue > uint.MaxValue;
            bool b10 = byte.MaxValue > uint.MaxValue;
            PrintOut($"sbyte.MaxValue > uint.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > uint.MaxValue = {b10}");
            PrintOut(string.Empty);
        }
        private static void Test_ulong()
        {
            bool b00 = int.MaxValue > ulong.MaxValue;
            bool b01 = long.MaxValue > ulong.MaxValue;
            bool b02 = (ulong)short.MaxValue > ulong.MaxValue;
            PrintOut($"int.MaxValue > ulong.MaxValue = {b00}");
            PrintOut($"long.MaxValue > ulong.MaxValue = {b01}");
            PrintOut($"short.MaxValue > ulong.MaxValue = {b02}");
            PrintOut(string.Empty);

            bool b03 = double.MaxValue > ulong.MaxValue;
            bool b04 = float.MaxValue > ulong.MaxValue;
            bool b05 = decimal.MaxValue > ulong.MaxValue;
            PrintOut($"double.MaxValue > ulong.MaxValue = {b03}");
            PrintOut($"float.MaxValue > ulong.MaxValue = {b04}");
            PrintOut($"decimal.MaxValue > ulong.MaxValue = {b05}");
            PrintOut(string.Empty);

            bool b06 = uint.MaxValue > ulong.MaxValue;
            //bool b07 = ulong.MaxValue > ulong.MaxValue;
            bool b08 = ushort.MaxValue > ulong.MaxValue;
            PrintOut($"uint.MaxValue > ulong.MaxValue = {b06}");
            //PrintOut($"ulong.MaxValue > ulong.MaxValue = {b07}");
            PrintOut($"ushort.MaxValue > ulong.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = (int)sbyte.MaxValue > ulong.MaxValue;
            bool b10 = byte.MaxValue > ulong.MaxValue;
            PrintOut($"sbyte.MaxValue > ulong.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > ulong.MaxValue = {b10}");
            PrintOut(string.Empty);
        }
        private static void Test_ushort()
        {
            bool b00 = int.MaxValue > ushort.MaxValue;
            bool b01 = long.MaxValue > ushort.MaxValue;
            bool b02 = short.MaxValue > ushort.MaxValue;
            PrintOut($"int.MaxValue > ushort.MaxValue = {b00}");
            PrintOut($"long.MaxValue > ushort.MaxValue = {b01}");
            PrintOut($"short.MaxValue > ushort.MaxValue = {b02}");
            PrintOut(string.Empty);

            bool b03 = double.MaxValue > ushort.MaxValue;
            bool b04 = float.MaxValue > ushort.MaxValue;
            bool b05 = decimal.MaxValue > ushort.MaxValue;
            PrintOut($"double.MaxValue > ushort.MaxValue = {b03}");
            PrintOut($"float.MaxValue > ushort.MaxValue = {b04}");
            PrintOut($"decimal.MaxValue > ushort.MaxValue = {b05}");
            PrintOut(string.Empty);

            bool b06 = uint.MaxValue > ushort.MaxValue;
            bool b07 = ulong.MaxValue > ushort.MaxValue;
            //bool b08 = ushort.MaxValue > ushort.MaxValue;
            PrintOut($"uint.MaxValue > ushort.MaxValue = {b06}");
            PrintOut($"ulong.MaxValue > ushort.MaxValue = {b07}");
            //PrintOut($"ushort.MaxValue > ushort.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = sbyte.MaxValue > ushort.MaxValue;
            bool b10 = byte.MaxValue > ushort.MaxValue;
            PrintOut($"sbyte.MaxValue > ushort.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > ushort.MaxValue = {b10}");
            PrintOut(string.Empty);
        }

        private static void Test_sbyte()
        {
            bool b00 = int.MaxValue > sbyte.MaxValue;
            bool b01 = long.MaxValue > sbyte.MaxValue;
            bool b02 = short.MaxValue > sbyte.MaxValue;
            PrintOut($"int.MaxValue > sbyte.MaxValue = {b00}");
            PrintOut($"long.MaxValue > sbyte.MaxValue = {b01}");
            PrintOut($"short.MaxValue > sbyte.MaxValue = {b02}");
            PrintOut(string.Empty);

            bool b03 = double.MaxValue > sbyte.MaxValue;
            bool b04 = float.MaxValue > sbyte.MaxValue;
            bool b05 = decimal.MaxValue > sbyte.MaxValue;
            PrintOut($"double.MaxValue > sbyte.MaxValue = {b03}");
            PrintOut($"float.MaxValue > sbyte.MaxValue = {b04}");
            PrintOut($"decimal.MaxValue > sbyte.MaxValue = {b05}");
            PrintOut(string.Empty);

            bool b06 = uint.MaxValue > sbyte.MaxValue;
            bool b07 = ulong.MaxValue > (ulong)sbyte.MaxValue;
            bool b08 = ushort.MaxValue > sbyte.MaxValue;
            PrintOut($"uint.MaxValue > sbyte.MaxValue = {b06}");
            PrintOut($"ulong.MaxValue > sbyte.MaxValue = {b07}");
            PrintOut($"ushort.MaxValue > sbyte.MaxValue = {b08}");
            PrintOut(string.Empty);

            bool b09 = sbyte.MaxValue > sbyte.MaxValue;
            bool b10 = byte.MaxValue > sbyte.MaxValue;
            PrintOut($"sbyte.MaxValue > sbyte.MaxValue = {b09}");
            PrintOut($"byte.MaxValue > sbyte.MaxValue = {b10}");
            PrintOut(string.Empty);
        }
        private static void Test_byte()
        {
        }

    }
}

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
            //int, long, short,
            //double, float, decimal,
            //uint, ulong, ushort,
            //sbyte, byte,

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

            rsb.AppendLine($"bool b00 = {dtnm}.MaxValue > int.MaxValue;");
            rsb.AppendLine($"bool b01 = {dtnm}.MaxValue > long.MaxValue;");
            rsb.AppendLine($"bool b02 = {dtnm}.MaxValue > short.MaxValue;");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > int.MaxValue = {{b00}}\");");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > long.MaxValue = {{b01}}\");");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > short.MaxValue = {{b02}}\");");
            rsb.AppendLine("PrintOut(string.Empty);");
            rsb.AppendLine();

            rsb.AppendLine($"bool b03 = {dtnm}.MaxValue > double.MaxValue;");
            rsb.AppendLine($"bool b04 = {dtnm}.MaxValue > float.MaxValue;");
            rsb.AppendLine($"bool b05 = {dtnm}.MaxValue > decimal.MaxValue;");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > double.MaxValue = {{b03}}\");");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > float.MaxValue = {{b04}}\");");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > decimal.MaxValue = {{b05}}\");");
            rsb.AppendLine("PrintOut(string.Empty);");
            rsb.AppendLine();

            rsb.AppendLine($"bool b06 = {dtnm}.MaxValue > uint.MaxValue;");
            rsb.AppendLine($"bool b07 = {dtnm}.MaxValue > ulong.MaxValue;");
            rsb.AppendLine($"bool b08 = {dtnm}.MaxValue > ushort.MaxValue;");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > uint.MaxValue = {{b06}}\");");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > ulong.MaxValue = {{b07}}\");");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > ushort.MaxValue = {{b08}}\");");
            rsb.AppendLine("PrintOut(string.Empty);");
            rsb.AppendLine();

            rsb.AppendLine($"bool b09 = {dtnm}.MaxValue > sbyte.MaxValue;");
            rsb.AppendLine($"bool b10 = {dtnm}.MaxValue > byte.MaxValue;");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > sbyte.MaxValue = {{b09}}\");");
            rsb.AppendLine($"PrintOut($\"{dtnm}.MaxValue > byte.MaxValue = {{b10}}\");");
            rsb.AppendLine("PrintOut(string.Empty);");
            rsb.AppendLine();

            string rs = rsb.ToString();
            PrintOut(rs);
        }


        private static void Test_int()
        {
        }
        private static void Test_long()
        {
        }
        private static void Test_short()
        {
        }

        private static void Test_double()
        {
        }
        private static void Test_float()
        {
        }
        private static void Test_decimal()
        {
        }

        private static void Test_uint()
        {
        }
        private static void Test_ulong()
        {
        }
        private static void Test_ushort()
        {
        }

        private static void Test_sbyte()
        {
        }
        private static void Test_byte()
        {
        }

    }
}

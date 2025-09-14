using Hobis.Numbers;
using System;


namespace HobisLibrary_ConsoleTester
{
    public static class TesterProgram
    {
        private static void PrintOut(string msg)
        {
            Console.WriteLine(msg);
            //Debug.WriteLine(msg);
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// [!! 순서]
// int, long, short, sbyte
// double, float, decimal
// uint, ulong, ushort, byte
        */


        private static void TestInt32()
        {
            PrintOut("==========================================================================================");
            PrintOut($"Int32Caster.Max >> {Int32Caster.Max}");
            PrintOut($"Int32Caster.Min >> {Int32Caster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"Int32Caster.From(long.MaxValue) >> {Int32Caster.From(long.MaxValue)}");
            PrintOut($"Int32Caster.From(long.MinValue) >> {Int32Caster.From(long.MinValue)}");
            PrintOut($"Int32Caster.From(short.MaxValue) >> {Int32Caster.From(short.MaxValue)}");
            PrintOut($"Int32Caster.From(short.MinValue) >> {Int32Caster.From(short.MinValue)}");
            PrintOut($"Int32Caster.From(sbyte.MaxValue) >> {Int32Caster.From(sbyte.MaxValue)}");
            PrintOut($"Int32Caster.From(sbyte.MinValue) >> {Int32Caster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"Int32Caster.From(double.MaxValue) >> {Int32Caster.From(double.MaxValue)}");
            PrintOut($"Int32Caster.From(double.MinValue) >> {Int32Caster.From(double.MinValue)}");
            PrintOut($"Int32Caster.From(float.MaxValue) >> {Int32Caster.From(float.MaxValue)}");
            PrintOut($"Int32Caster.From(float.MinValue) >> {Int32Caster.From(float.MinValue)}");
            PrintOut($"Int32Caster.From(decimal.MaxValue) >> {Int32Caster.From(decimal.MaxValue)}");
            PrintOut($"Int32Caster.From(decimal.MinValue) >> {Int32Caster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"Int32Caster.From(uint.MaxValue) >> {Int32Caster.From(uint.MaxValue)}");
            PrintOut($"Int32Caster.From(uint.MinValue) >> {Int32Caster.From(uint.MinValue)}");
            PrintOut($"Int32Caster.From(ulong.MaxValue) >> {Int32Caster.From(ulong.MaxValue)}");
            PrintOut($"Int32Caster.From(ulong.MinValue) >> {Int32Caster.From(ulong.MinValue)}");
            PrintOut($"Int32Caster.From(ushort.MaxValue) >> {Int32Caster.From(ushort.MaxValue)}");
            PrintOut($"Int32Caster.From(ushort.MinValue) >> {Int32Caster.From(ushort.MinValue)}");
            PrintOut($"Int32Caster.From(byte.MaxValue) >> {Int32Caster.From(byte.MaxValue)}");
            PrintOut($"Int32Caster.From(byte.MinValue) >> {Int32Caster.From(byte.MinValue)}");
            PrintOut(string.Empty);
  
            PrintOut($"Int32Caster.From(double.Epsilon >> {Int32Caster.From(double.Epsilon)}");
            PrintOut($"Int32Caster.From(double.PositiveInfinity) >> {Int32Caster.From(double.PositiveInfinity)}");
            PrintOut($"Int32Caster.From(double.NegativeInfinity >> {Int32Caster.From(double.NegativeInfinity)}");
            PrintOut($"Int32Caster.From(double.NaN) >> {Int32Caster.From(double.NaN)}");
            PrintOut(string.Empty);

            PrintOut($"Int32Caster.From(float.Epsilon >> {Int32Caster.From(float.Epsilon)}");
            PrintOut($"Int32Caster.From(float.PositiveInfinity) >> {Int32Caster.From(float.PositiveInfinity)}");
            PrintOut($"Int32Caster.From(float.NegativeInfinity >> {Int32Caster.From(float.NegativeInfinity)}");
            PrintOut($"Int32Caster.From(float.NaN) >> {Int32Caster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }

        private static void TestInt64()
        {
            PrintOut("==========================================================================================");
            PrintOut($"Int64Caster.Max >> {Int64Caster.Max}");
            PrintOut($"Int64Caster.Min >> {Int64Caster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"Int64Caster.From(int.MaxValue) >> {Int64Caster.From(int.MaxValue)}");
            PrintOut($"Int64Caster.From(int.MinValue) >> {Int64Caster.From(int.MinValue)}");
            PrintOut($"Int64Caster.From(short.MaxValue) >> {Int64Caster.From(short.MaxValue)}");
            PrintOut($"Int64Caster.From(short.MinValue) >> {Int64Caster.From(short.MinValue)}");
            PrintOut($"Int64Caster.From(sbyte.MaxValue) >> {Int64Caster.From(sbyte.MaxValue)}");
            PrintOut($"Int64Caster.From(sbyte.MinValue) >> {Int64Caster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"Int64Caster.From(double.MaxValue) >> {Int64Caster.From(double.MaxValue)}");
            PrintOut($"Int64Caster.From(double.MinValue) >> {Int64Caster.From(double.MinValue)}");
            PrintOut($"Int64Caster.From(float.MaxValue) >> {Int64Caster.From(float.MaxValue)}");
            PrintOut($"Int64Caster.From(float.MinValue) >> {Int64Caster.From(float.MinValue)}");
            PrintOut($"Int64Caster.From(decimal.MaxValue) >> {Int64Caster.From(decimal.MaxValue)}");
            PrintOut($"Int64Caster.From(decimal.MinValue) >> {Int64Caster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"Int64Caster.From(uint.MaxValue) >> {Int64Caster.From(uint.MaxValue)}");
            PrintOut($"Int64Caster.From(uint.MinValue) >> {Int64Caster.From(uint.MinValue)}");
            PrintOut($"Int64Caster.From(ulong.MaxValue) >> {Int64Caster.From(ulong.MaxValue)}");
            PrintOut($"Int64Caster.From(ulong.MinValue) >> {Int64Caster.From(ulong.MinValue)}");
            PrintOut($"Int64Caster.From(ushort.MaxValue) >> {Int64Caster.From(ushort.MaxValue)}");
            PrintOut($"Int64Caster.From(ushort.MinValue) >> {Int64Caster.From(ushort.MinValue)}");
            PrintOut($"Int64Caster.From(byte.MaxValue) >> {Int64Caster.From(byte.MaxValue)}");
            PrintOut($"Int64Caster.From(byte.MinValue) >> {Int64Caster.From(byte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"Int64Caster.From(double.Epsilon >> {Int64Caster.From(double.Epsilon)}");
            PrintOut($"Int64Caster.From(double.PositiveInfinity) >> {Int64Caster.From(double.PositiveInfinity)}");
            PrintOut($"Int64Caster.From(double.NegativeInfinity >> {Int64Caster.From(double.NegativeInfinity)}");
            PrintOut($"Int64Caster.From(double.NaN) >> {Int64Caster.From(double.NaN)}");
            PrintOut(string.Empty);

            PrintOut($"Int64Caster.From(float.Epsilon >> {Int64Caster.From(float.Epsilon)}");
            PrintOut($"Int64Caster.From(float.PositiveInfinity) >> {Int64Caster.From(float.PositiveInfinity)}");
            PrintOut($"Int64Caster.From(float.NegativeInfinity >> {Int64Caster.From(float.NegativeInfinity)}");
            PrintOut($"Int64Caster.From(float.NaN) >> {Int64Caster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }

        private static void TestInt16()
        {
            PrintOut("==========================================================================================");
            PrintOut($"Int16Caster.Max >> {Int16Caster.Max}");
            PrintOut($"Int16Caster.Min >> {Int16Caster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"Int16Caster.From(int.MaxValue) >> {Int16Caster.From(int.MaxValue)}");
            PrintOut($"Int16Caster.From(int.MinValue) >> {Int16Caster.From(int.MinValue)}");
            PrintOut($"Int16Caster.From(long.MaxValue) >> {Int16Caster.From(long.MaxValue)}");
            PrintOut($"Int16Caster.From(long.MinValue) >> {Int16Caster.From(long.MinValue)}");
            PrintOut($"Int16Caster.From(sbyte.MaxValue) >> {Int16Caster.From(sbyte.MaxValue)}");
            PrintOut($"Int16Caster.From(sbyte.MinValue) >> {Int16Caster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"Int16Caster.From(double.MaxValue) >> {Int16Caster.From(double.MaxValue)}");
            PrintOut($"Int16Caster.From(double.MinValue) >> {Int16Caster.From(double.MinValue)}");
            PrintOut($"Int16Caster.From(float.MaxValue) >> {Int16Caster.From(float.MaxValue)}");
            PrintOut($"Int16Caster.From(float.MinValue) >> {Int16Caster.From(float.MinValue)}");
            PrintOut($"Int16Caster.From(decimal.MaxValue) >> {Int16Caster.From(decimal.MaxValue)}");
            PrintOut($"Int16Caster.From(decimal.MinValue) >> {Int16Caster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"Int16Caster.From(uint.MaxValue) >> {Int16Caster.From(uint.MaxValue)}");
            PrintOut($"Int16Caster.From(uint.MinValue) >> {Int16Caster.From(uint.MinValue)}");
            PrintOut($"Int16Caster.From(ulong.MaxValue) >> {Int16Caster.From(ulong.MaxValue)}");
            PrintOut($"Int16Caster.From(ulong.MinValue) >> {Int16Caster.From(ulong.MinValue)}");
            PrintOut($"Int16Caster.From(ushort.MaxValue) >> {Int16Caster.From(ushort.MaxValue)}");
            PrintOut($"Int16Caster.From(ushort.MinValue) >> {Int16Caster.From(ushort.MinValue)}");
            PrintOut($"Int16Caster.From(byte.MaxValue) >> {Int16Caster.From(byte.MaxValue)}");
            PrintOut($"Int16Caster.From(byte.MinValue) >> {Int16Caster.From(byte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"Int16Caster.From(double.Epsilon >> {Int16Caster.From(double.Epsilon)}");
            PrintOut($"Int16Caster.From(double.PositiveInfinity) >> {Int16Caster.From(double.PositiveInfinity)}");
            PrintOut($"Int16Caster.From(double.NegativeInfinity >> {Int16Caster.From(double.NegativeInfinity)}");
            PrintOut($"Int16Caster.From(double.NaN) >> {Int16Caster.From(double.NaN)}");
            PrintOut(string.Empty);

            PrintOut($"Int16Caster.From(float.Epsilon >> {Int16Caster.From(float.Epsilon)}");
            PrintOut($"Int16Caster.From(float.PositiveInfinity) >> {Int16Caster.From(float.PositiveInfinity)}");
            PrintOut($"Int16Caster.From(float.NegativeInfinity >> {Int16Caster.From(float.NegativeInfinity)}");
            PrintOut($"Int16Caster.From(float.NaN) >> {Int16Caster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }

        private static void TestSByte()
        {
            PrintOut("==========================================================================================");
            PrintOut($"SByteCaster.Max >> {SByteCaster.Max}");
            PrintOut($"SByteCaster.Min >> {SByteCaster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"SByteCaster.From(int.MaxValue) >> {SByteCaster.From(int.MaxValue)}");
            PrintOut($"SByteCaster.From(int.MinValue) >> {SByteCaster.From(int.MinValue)}");
            PrintOut($"SByteCaster.From(long.MaxValue) >> {SByteCaster.From(long.MaxValue)}");
            PrintOut($"SByteCaster.From(long.MinValue) >> {SByteCaster.From(long.MinValue)}");
            PrintOut($"SByteCaster.From(short.MaxValue) >> {SByteCaster.From(short.MaxValue)}");
            PrintOut($"SByteCaster.From(short.MinValue) >> {SByteCaster.From(short.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"SByteCaster.From(double.MaxValue) >> {SByteCaster.From(double.MaxValue)}");
            PrintOut($"SByteCaster.From(double.MinValue) >> {SByteCaster.From(double.MinValue)}");
            PrintOut($"SByteCaster.From(float.MaxValue) >> {SByteCaster.From(float.MaxValue)}");
            PrintOut($"SByteCaster.From(float.MinValue) >> {SByteCaster.From(float.MinValue)}");
            PrintOut($"SByteCaster.From(decimal.MaxValue) >> {SByteCaster.From(decimal.MaxValue)}");
            PrintOut($"SByteCaster.From(decimal.MinValue) >> {SByteCaster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"SByteCaster.From(uint.MaxValue) >> {SByteCaster.From(uint.MaxValue)}");
            PrintOut($"SByteCaster.From(uint.MinValue) >> {SByteCaster.From(uint.MinValue)}");
            PrintOut($"SByteCaster.From(ulong.MaxValue) >> {SByteCaster.From(ulong.MaxValue)}");
            PrintOut($"SByteCaster.From(ulong.MinValue) >> {SByteCaster.From(ulong.MinValue)}");
            PrintOut($"SByteCaster.From(ushort.MaxValue) >> {SByteCaster.From(ushort.MaxValue)}");
            PrintOut($"SByteCaster.From(ushort.MinValue) >> {SByteCaster.From(ushort.MinValue)}");
            PrintOut($"SByteCaster.From(byte.MaxValue) >> {SByteCaster.From(byte.MaxValue)}");
            PrintOut($"SByteCaster.From(byte.MinValue) >> {SByteCaster.From(byte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"SByteCaster.From(double.Epsilon >> {SByteCaster.From(double.Epsilon)}");
            PrintOut($"SByteCaster.From(double.PositiveInfinity) >> {SByteCaster.From(double.PositiveInfinity)}");
            PrintOut($"SByteCaster.From(double.NegativeInfinity >> {SByteCaster.From(double.NegativeInfinity)}");
            PrintOut($"SByteCaster.From(double.NaN) >> {SByteCaster.From(double.NaN)}");
            PrintOut(string.Empty);

            PrintOut($"SByteCaster.From(float.Epsilon >> {SByteCaster.From(float.Epsilon)}");
            PrintOut($"SByteCaster.From(float.PositiveInfinity) >> {SByteCaster.From(float.PositiveInfinity)}");
            PrintOut($"SByteCaster.From(float.NegativeInfinity >> {SByteCaster.From(float.NegativeInfinity)}");
            PrintOut($"SByteCaster.From(float.NaN) >> {SByteCaster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }


        private static void TestDouble()
        {
            PrintOut("==========================================================================================");
            PrintOut($"DoubleCaster.Max >> {DoubleCaster.Max}");
            PrintOut($"DoubleCaster.Min >> {DoubleCaster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"DoubleCaster.From(int.MaxValue) >> {DoubleCaster.From(int.MaxValue)}");
            PrintOut($"DoubleCaster.From(int.MinValue) >> {DoubleCaster.From(int.MinValue)}");
            PrintOut($"DoubleCaster.From(long.MaxValue) >> {DoubleCaster.From(long.MaxValue)}");
            PrintOut($"DoubleCaster.From(long.MinValue) >> {DoubleCaster.From(long.MinValue)}");
            PrintOut($"DoubleCaster.From(short.MaxValue) >> {DoubleCaster.From(short.MaxValue)}");
            PrintOut($"DoubleCaster.From(short.MinValue) >> {DoubleCaster.From(short.MinValue)}");
            PrintOut($"DoubleCaster.From(sbyte.MaxValue) >> {DoubleCaster.From(sbyte.MaxValue)}");
            PrintOut($"DoubleCaster.From(sbyte.MinValue) >> {DoubleCaster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"DoubleCaster.From(float.MaxValue) >> {DoubleCaster.From(float.MaxValue)}");
            PrintOut($"DoubleCaster.From(float.MinValue) >> {DoubleCaster.From(float.MinValue)}");
            PrintOut($"DoubleCaster.From(decimal.MaxValue) >> {DoubleCaster.From(decimal.MaxValue)}");
            PrintOut($"DoubleCaster.From(decimal.MinValue) >> {DoubleCaster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"DoubleCaster.From(uint.MaxValue) >> {DoubleCaster.From(uint.MaxValue)}");
            PrintOut($"DoubleCaster.From(uint.MinValue) >> {DoubleCaster.From(uint.MinValue)}");
            PrintOut($"DoubleCaster.From(ulong.MaxValue) >> {DoubleCaster.From(ulong.MaxValue)}");
            PrintOut($"DoubleCaster.From(ulong.MinValue) >> {DoubleCaster.From(ulong.MinValue)}");
            PrintOut($"DoubleCaster.From(ushort.MaxValue) >> {DoubleCaster.From(ushort.MaxValue)}");
            PrintOut($"DoubleCaster.From(ushort.MinValue) >> {DoubleCaster.From(ushort.MinValue)}");
            PrintOut($"DoubleCaster.From(byte.MaxValue) >> {DoubleCaster.From(byte.MaxValue)}");
            PrintOut($"DoubleCaster.From(byte.MinValue) >> {DoubleCaster.From(byte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"DoubleCaster.From(float.Epsilon >> {DoubleCaster.From(float.Epsilon)}");
            PrintOut($"DoubleCaster.From(float.PositiveInfinity) >> {DoubleCaster.From(float.PositiveInfinity)}");
            PrintOut($"DoubleCaster.From(float.NegativeInfinity >> {DoubleCaster.From(float.NegativeInfinity)}");
            PrintOut($"DoubleCaster.From(float.NaN) >> {DoubleCaster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }

        private static void TestSingle()
        {
            PrintOut("==========================================================================================");
            PrintOut($"SingleCaster.Max >> {SingleCaster.Max}");
            PrintOut($"SingleCaster.Min >> {SingleCaster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"SingleCaster.From(int.MaxValue) >> {SingleCaster.From(int.MaxValue)}");
            PrintOut($"SingleCaster.From(int.MinValue) >> {SingleCaster.From(int.MinValue)}");
            PrintOut($"SingleCaster.From(long.MaxValue) >> {SingleCaster.From(long.MaxValue)}");
            PrintOut($"SingleCaster.From(long.MinValue) >> {SingleCaster.From(long.MinValue)}");
            PrintOut($"SingleCaster.From(short.MaxValue) >> {SingleCaster.From(short.MaxValue)}");
            PrintOut($"SingleCaster.From(short.MinValue) >> {SingleCaster.From(short.MinValue)}");
            PrintOut($"SingleCaster.From(sbyte.MaxValue) >> {SingleCaster.From(sbyte.MaxValue)}");
            PrintOut($"SingleCaster.From(sbyte.MinValue) >> {SingleCaster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"SingleCaster.From(double.MaxValue) >> {SingleCaster.From(double.MaxValue)}");
            PrintOut($"SingleCaster.From(double.MinValue) >> {SingleCaster.From(double.MinValue)}");
            PrintOut($"SingleCaster.From(decimal.MaxValue) >> {SingleCaster.From(decimal.MaxValue)}");
            PrintOut($"SingleCaster.From(decimal.MinValue) >> {SingleCaster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"SingleCaster.From(uint.MaxValue) >> {SingleCaster.From(uint.MaxValue)}");
            PrintOut($"SingleCaster.From(uint.MinValue) >> {SingleCaster.From(uint.MinValue)}");
            PrintOut($"SingleCaster.From(ulong.MaxValue) >> {SingleCaster.From(ulong.MaxValue)}");
            PrintOut($"SingleCaster.From(ulong.MinValue) >> {SingleCaster.From(ulong.MinValue)}");
            PrintOut($"SingleCaster.From(ushort.MaxValue) >> {SingleCaster.From(ushort.MaxValue)}");
            PrintOut($"SingleCaster.From(ushort.MinValue) >> {SingleCaster.From(ushort.MinValue)}");
            PrintOut($"SingleCaster.From(byte.MaxValue) >> {SingleCaster.From(byte.MaxValue)}");
            PrintOut($"SingleCaster.From(byte.MinValue) >> {SingleCaster.From(byte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"SingleCaster.From(double.Epsilon >> {SingleCaster.From(double.Epsilon)}");
            PrintOut($"SingleCaster.From(double.PositiveInfinity) >> {SingleCaster.From(double.PositiveInfinity)}");
            PrintOut($"SingleCaster.From(double.NegativeInfinity >> {SingleCaster.From(double.NegativeInfinity)}");
            PrintOut($"SingleCaster.From(double.NaN) >> {SingleCaster.From(double.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }

        private static void TestDecimal()
        {
            PrintOut("==========================================================================================");
            PrintOut($"DecimalCaster.Max >> {DecimalCaster.Max}");
            PrintOut($"DecimalCaster.Min >> {DecimalCaster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"DecimalCaster.From(int.MaxValue) >> {DecimalCaster.From(int.MaxValue)}");
            PrintOut($"DecimalCaster.From(int.MinValue) >> {DecimalCaster.From(int.MinValue)}");
            PrintOut($"DecimalCaster.From(long.MaxValue) >> {DecimalCaster.From(long.MaxValue)}");
            PrintOut($"DecimalCaster.From(long.MinValue) >> {DecimalCaster.From(long.MinValue)}");
            PrintOut($"DecimalCaster.From(short.MaxValue) >> {DecimalCaster.From(short.MaxValue)}");
            PrintOut($"DecimalCaster.From(short.MinValue) >> {DecimalCaster.From(short.MinValue)}");
            PrintOut($"DecimalCaster.From(sbyte.MaxValue) >> {DecimalCaster.From(sbyte.MaxValue)}");
            PrintOut($"DecimalCaster.From(sbyte.MinValue) >> {DecimalCaster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"DecimalCaster.From(double.MaxValue) >> {DecimalCaster.From(double.MaxValue)}");
            PrintOut($"DecimalCaster.From(double.MinValue) >> {DecimalCaster.From(double.MinValue)}");
            PrintOut($"DecimalCaster.From(float.MaxValue) >> {DecimalCaster.From(float.MaxValue)}");
            PrintOut($"DecimalCaster.From(float.MinValue) >> {DecimalCaster.From(float.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"DecimalCaster.From(uint.MaxValue) >> {DecimalCaster.From(uint.MaxValue)}");
            PrintOut($"DecimalCaster.From(uint.MinValue) >> {DecimalCaster.From(uint.MinValue)}");
            PrintOut($"DecimalCaster.From(ulong.MaxValue) >> {DecimalCaster.From(ulong.MaxValue)}");
            PrintOut($"DecimalCaster.From(ulong.MinValue) >> {DecimalCaster.From(ulong.MinValue)}");
            PrintOut($"DecimalCaster.From(ushort.MaxValue) >> {DecimalCaster.From(ushort.MaxValue)}");
            PrintOut($"DecimalCaster.From(ushort.MinValue) >> {DecimalCaster.From(ushort.MinValue)}");
            PrintOut($"DecimalCaster.From(byte.MaxValue) >> {DecimalCaster.From(byte.MaxValue)}");
            PrintOut($"DecimalCaster.From(byte.MinValue) >> {DecimalCaster.From(byte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"DecimalCaster.From(double.Epsilon >> {DecimalCaster.From(double.Epsilon)}");
            PrintOut($"DecimalCaster.From(double.PositiveInfinity) >> {DecimalCaster.From(double.PositiveInfinity)}");
            PrintOut($"DecimalCaster.From(double.NegativeInfinity >> {DecimalCaster.From(double.NegativeInfinity)}");
            PrintOut($"DecimalCaster.From(double.NaN) >> {DecimalCaster.From(double.NaN)}");
            PrintOut(string.Empty);

            PrintOut($"DecimalCaster.From(float.Epsilon >> {DecimalCaster.From(float.Epsilon)}");
            PrintOut($"DecimalCaster.From(float.PositiveInfinity) >> {DecimalCaster.From(float.PositiveInfinity)}");
            PrintOut($"DecimalCaster.From(float.NegativeInfinity >> {DecimalCaster.From(float.NegativeInfinity)}");
            PrintOut($"DecimalCaster.From(float.NaN) >> {DecimalCaster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }


        private static void TestUInt16()
        {
            PrintOut("==========================================================================================");
            PrintOut($"UInt16Caster.Max >> {UInt16Caster.Max}");
            PrintOut($"UInt16Caster.Min >> {UInt16Caster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"UInt16Caster.From(int.MaxValue) >> {UInt16Caster.From(int.MaxValue)}");
            PrintOut($"UInt16Caster.From(int.MinValue) >> {UInt16Caster.From(int.MinValue)}");
            PrintOut($"UInt16Caster.From(long.MaxValue) >> {UInt16Caster.From(long.MaxValue)}");
            PrintOut($"UInt16Caster.From(long.MinValue) >> {UInt16Caster.From(long.MinValue)}");
            PrintOut($"UInt16Caster.From(short.MaxValue) >> {UInt16Caster.From(short.MaxValue)}");
            PrintOut($"UInt16Caster.From(short.MinValue) >> {UInt16Caster.From(short.MinValue)}");
            PrintOut($"UInt16Caster.From(sbyte.MaxValue) >> {UInt16Caster.From(sbyte.MaxValue)}");
            PrintOut($"UInt16Caster.From(sbyte.MinValue) >> {UInt16Caster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"UInt16Caster.From(double.MaxValue) >> {UInt16Caster.From(double.MaxValue)}");
            PrintOut($"UInt16Caster.From(double.MinValue) >> {UInt16Caster.From(double.MinValue)}");
            PrintOut($"UInt16Caster.From(float.MaxValue) >> {UInt16Caster.From(float.MaxValue)}");
            PrintOut($"UInt16Caster.From(float.MinValue) >> {UInt16Caster.From(float.MinValue)}");
            PrintOut($"UInt16Caster.From(decimal.MaxValue) >> {UInt16Caster.From(decimal.MaxValue)}");
            PrintOut($"UInt16Caster.From(decimal.MinValue) >> {UInt16Caster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"UInt16Caster.From(uint.MaxValue) >> {UInt16Caster.From(uint.MaxValue)}");
            PrintOut($"UInt16Caster.From(uint.MinValue) >> {UInt16Caster.From(uint.MinValue)}");
            PrintOut($"UInt16Caster.From(ulong.MaxValue) >> {UInt16Caster.From(ulong.MaxValue)}");
            PrintOut($"UInt16Caster.From(ulong.MinValue) >> {UInt16Caster.From(ulong.MinValue)}");
            PrintOut($"UInt16Caster.From(byte.MaxValue) >> {UInt16Caster.From(byte.MaxValue)}");
            PrintOut($"UInt16Caster.From(byte.MinValue) >> {UInt16Caster.From(byte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"UInt16Caster.From(double.Epsilon >> {UInt16Caster.From(double.Epsilon)}");
            PrintOut($"UInt16Caster.From(double.PositiveInfinity) >> {UInt16Caster.From(double.PositiveInfinity)}");
            PrintOut($"UInt16Caster.From(double.NegativeInfinity >> {UInt16Caster.From(double.NegativeInfinity)}");
            PrintOut($"UInt16Caster.From(double.NaN) >> {UInt16Caster.From(double.NaN)}");
            PrintOut(string.Empty);

            PrintOut($"UInt16Caster.From(float.Epsilon >> {UInt16Caster.From(float.Epsilon)}");
            PrintOut($"UInt16Caster.From(float.PositiveInfinity) >> {UInt16Caster.From(float.PositiveInfinity)}");
            PrintOut($"UInt16Caster.From(float.NegativeInfinity >> {UInt16Caster.From(float.NegativeInfinity)}");
            PrintOut($"UInt16Caster.From(float.NaN) >> {UInt16Caster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }

        private static void TestUInt32()
        {
            PrintOut("==========================================================================================");
            PrintOut($"UInt32Caster.Max >> {UInt32Caster.Max}");
            PrintOut($"UInt32Caster.Min >> {UInt32Caster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"UInt32Caster.From(int.MaxValue) >> {UInt32Caster.From(int.MaxValue)}");
            PrintOut($"UInt32Caster.From(int.MinValue) >> {UInt32Caster.From(int.MinValue)}");
            PrintOut($"UInt32Caster.From(long.MaxValue) >> {UInt32Caster.From(long.MaxValue)}");
            PrintOut($"UInt32Caster.From(long.MinValue) >> {UInt32Caster.From(long.MinValue)}");
            PrintOut($"UInt32Caster.From(short.MaxValue) >> {UInt32Caster.From(short.MaxValue)}");
            PrintOut($"UInt32Caster.From(short.MinValue) >> {UInt32Caster.From(short.MinValue)}");
            PrintOut($"UInt32Caster.From(sbyte.MaxValue) >> {UInt32Caster.From(sbyte.MaxValue)}");
            PrintOut($"UInt32Caster.From(sbyte.MinValue) >> {UInt32Caster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"UInt32Caster.From(double.MaxValue) >> {UInt32Caster.From(double.MaxValue)}");
            PrintOut($"UInt32Caster.From(double.MinValue) >> {UInt32Caster.From(double.MinValue)}");
            PrintOut($"UInt32Caster.From(float.MaxValue) >> {UInt32Caster.From(float.MaxValue)}");
            PrintOut($"UInt32Caster.From(float.MinValue) >> {UInt32Caster.From(float.MinValue)}");
            PrintOut($"UInt32Caster.From(decimal.MaxValue) >> {UInt32Caster.From(decimal.MaxValue)}");
            PrintOut($"UInt32Caster.From(decimal.MinValue) >> {UInt32Caster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"UInt32Caster.From(uint.MaxValue) >> {UInt32Caster.From(uint.MaxValue)}");
            PrintOut($"UInt32Caster.From(uint.MinValue) >> {UInt32Caster.From(uint.MinValue)}");
            PrintOut($"UInt32Caster.From(ulong.MaxValue) >> {UInt32Caster.From(ulong.MaxValue)}");
            PrintOut($"UInt32Caster.From(ulong.MinValue) >> {UInt32Caster.From(ulong.MinValue)}");
            PrintOut($"UInt32Caster.From(byte.MaxValue) >> {UInt32Caster.From(byte.MaxValue)}");
            PrintOut($"UInt32Caster.From(byte.MinValue) >> {UInt32Caster.From(byte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"UInt32Caster.From(double.Epsilon >> {UInt32Caster.From(double.Epsilon)}");
            PrintOut($"UInt32Caster.From(double.PositiveInfinity) >> {UInt32Caster.From(double.PositiveInfinity)}");
            PrintOut($"UInt32Caster.From(double.NegativeInfinity >> {UInt32Caster.From(double.NegativeInfinity)}");
            PrintOut($"UInt32Caster.From(double.NaN) >> {UInt32Caster.From(double.NaN)}");
            PrintOut(string.Empty);

            PrintOut($"UInt32Caster.From(float.Epsilon >> {UInt32Caster.From(float.Epsilon)}");
            PrintOut($"UInt32Caster.From(float.PositiveInfinity) >> {UInt32Caster.From(float.PositiveInfinity)}");
            PrintOut($"UInt32Caster.From(float.NegativeInfinity >> {UInt32Caster.From(float.NegativeInfinity)}");
            PrintOut($"UInt32Caster.From(float.NaN) >> {UInt32Caster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }

        private static void TestUInt64()
        {
            PrintOut("==========================================================================================");
            PrintOut($"UInt64Caster.Max >> {UInt64Caster.Max}");
            PrintOut($"UInt64Caster.Min >> {UInt64Caster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"UInt64Caster.From(int.MaxValue) >> {UInt64Caster.From(int.MaxValue)}");
            PrintOut($"UInt64Caster.From(int.MinValue) >> {UInt64Caster.From(int.MinValue)}");
            PrintOut($"UInt64Caster.From(long.MaxValue) >> {UInt64Caster.From(long.MaxValue)}");
            PrintOut($"UInt64Caster.From(long.MinValue) >> {UInt64Caster.From(long.MinValue)}");
            PrintOut($"UInt64Caster.From(short.MaxValue) >> {UInt64Caster.From(short.MaxValue)}");
            PrintOut($"UInt64Caster.From(short.MinValue) >> {UInt64Caster.From(short.MinValue)}");
            PrintOut($"UInt64Caster.From(sbyte.MaxValue) >> {UInt64Caster.From(sbyte.MaxValue)}");
            PrintOut($"UInt64Caster.From(sbyte.MinValue) >> {UInt64Caster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"UInt64Caster.From(double.MaxValue) >> {UInt64Caster.From(double.MaxValue)}");
            PrintOut($"UInt64Caster.From(double.MinValue) >> {UInt64Caster.From(double.MinValue)}");
            PrintOut($"UInt64Caster.From(float.MaxValue) >> {UInt64Caster.From(float.MaxValue)}");
            PrintOut($"UInt64Caster.From(float.MinValue) >> {UInt64Caster.From(float.MinValue)}");
            PrintOut($"UInt64Caster.From(decimal.MaxValue) >> {UInt64Caster.From(decimal.MaxValue)}");
            PrintOut($"UInt64Caster.From(decimal.MinValue) >> {UInt64Caster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"UInt64Caster.From(uint.MaxValue) >> {UInt64Caster.From(uint.MaxValue)}");
            PrintOut($"UInt64Caster.From(uint.MinValue) >> {UInt64Caster.From(uint.MinValue)}");
            PrintOut($"UInt64Caster.From(ushort.MaxValue) >> {UInt64Caster.From(ushort.MaxValue)}");
            PrintOut($"UInt64Caster.From(ushort.MinValue) >> {UInt64Caster.From(ushort.MinValue)}");
            PrintOut($"UInt64Caster.From(byte.MaxValue) >> {UInt64Caster.From(byte.MaxValue)}");
            PrintOut($"UInt64Caster.From(byte.MinValue) >> {UInt64Caster.From(byte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"UInt64Caster.From(double.Epsilon >> {UInt64Caster.From(double.Epsilon)}");
            PrintOut($"UInt64Caster.From(double.PositiveInfinity) >> {UInt64Caster.From(double.PositiveInfinity)}");
            PrintOut($"UInt64Caster.From(double.NegativeInfinity >> {UInt64Caster.From(double.NegativeInfinity)}");
            PrintOut($"UInt64Caster.From(double.NaN) >> {UInt64Caster.From(double.NaN)}");
            PrintOut(string.Empty);

            PrintOut($"UInt64Caster.From(float.Epsilon >> {UInt64Caster.From(float.Epsilon)}");
            PrintOut($"UInt64Caster.From(float.PositiveInfinity) >> {UInt64Caster.From(float.PositiveInfinity)}");
            PrintOut($"UInt64Caster.From(float.NegativeInfinity >> {UInt64Caster.From(float.NegativeInfinity)}");
            PrintOut($"UInt64Caster.From(float.NaN) >> {UInt64Caster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }

        private static void TestByte()
        {
            PrintOut("==========================================================================================");
            PrintOut($"ByteCaster.Max >> {ByteCaster.Max}");
            PrintOut($"ByteCaster.Min >> {ByteCaster.Min}");
            PrintOut("==========================================================================================");
            PrintOut(string.Empty);

            PrintOut($"ByteCaster.From(int.MaxValue) >> {ByteCaster.From(int.MaxValue)}");
            PrintOut($"ByteCaster.From(int.MinValue) >> {ByteCaster.From(int.MinValue)}");
            PrintOut($"ByteCaster.From(long.MaxValue) >> {ByteCaster.From(long.MaxValue)}");
            PrintOut($"ByteCaster.From(long.MinValue) >> {ByteCaster.From(long.MinValue)}");
            PrintOut($"ByteCaster.From(short.MaxValue) >> {ByteCaster.From(short.MaxValue)}");
            PrintOut($"ByteCaster.From(short.MinValue) >> {ByteCaster.From(short.MinValue)}");
            PrintOut($"ByteCaster.From(sbyte.MaxValue) >> {ByteCaster.From(sbyte.MaxValue)}");
            PrintOut($"ByteCaster.From(sbyte.MinValue) >> {ByteCaster.From(sbyte.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"ByteCaster.From(double.MaxValue) >> {ByteCaster.From(double.MaxValue)}");
            PrintOut($"ByteCaster.From(double.MinValue) >> {ByteCaster.From(double.MinValue)}");
            PrintOut($"ByteCaster.From(float.MaxValue) >> {ByteCaster.From(float.MaxValue)}");
            PrintOut($"ByteCaster.From(float.MinValue) >> {ByteCaster.From(float.MinValue)}");
            PrintOut($"ByteCaster.From(decimal.MaxValue) >> {ByteCaster.From(decimal.MaxValue)}");
            PrintOut($"ByteCaster.From(decimal.MinValue) >> {ByteCaster.From(decimal.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"ByteCaster.From(uint.MaxValue) >> {ByteCaster.From(uint.MaxValue)}");
            PrintOut($"ByteCaster.From(uint.MinValue) >> {ByteCaster.From(uint.MinValue)}");
            PrintOut($"ByteCaster.From(ulong.MaxValue) >> {ByteCaster.From(ulong.MaxValue)}");
            PrintOut($"ByteCaster.From(ulong.MinValue) >> {ByteCaster.From(ulong.MinValue)}");
            PrintOut($"ByteCaster.From(ushort.MaxValue) >> {ByteCaster.From(ushort.MaxValue)}");
            PrintOut($"ByteCaster.From(ushort.MinValue) >> {ByteCaster.From(ushort.MinValue)}");
            PrintOut(string.Empty);

            PrintOut($"ByteCaster.From(double.Epsilon >> {ByteCaster.From(double.Epsilon)}");
            PrintOut($"ByteCaster.From(double.PositiveInfinity) >> {ByteCaster.From(double.PositiveInfinity)}");
            PrintOut($"ByteCaster.From(double.NegativeInfinity >> {ByteCaster.From(double.NegativeInfinity)}");
            PrintOut($"ByteCaster.From(double.NaN) >> {ByteCaster.From(double.NaN)}");
            PrintOut(string.Empty);

            PrintOut($"ByteCaster.From(float.Epsilon >> {ByteCaster.From(float.Epsilon)}");
            PrintOut($"ByteCaster.From(float.PositiveInfinity) >> {ByteCaster.From(float.PositiveInfinity)}");
            PrintOut($"ByteCaster.From(float.NegativeInfinity >> {ByteCaster.From(float.NegativeInfinity)}");
            PrintOut($"ByteCaster.From(float.NaN) >> {ByteCaster.From(float.NaN)}");
            PrintOut(string.Empty);
            PrintOut(string.Empty);
            PrintOut("==========================================================================================");
        }


        public static void Main(string[] args)
        {
            TestInt32();
            TestInt64();
            TestInt16();
            TestSByte();

            TestDouble();
            TestSingle();
            TestDecimal();

            TestUInt16();
            TestUInt32();
            TestUInt64();
            TestByte();
        }


    }
}

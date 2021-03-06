using System;

// ReSharper disable ExpressionIsAlwaysNull

namespace V5.C06Conversions.Implicit.C08Boxing
{
    public class C06NullableEnumToSystemEnum
    {
        public C06NullableEnumToSystemEnum()
        {
            SimpleEnum? a = SimpleEnum.First;
            Enum a2 = a;

            SimpleEnum? b = null;
            Enum b2 = b;
        }

        enum SimpleEnum
        {
            First
        }
    }
}
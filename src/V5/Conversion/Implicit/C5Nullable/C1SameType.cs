﻿// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable ConvertToConstant.Local

namespace V5.Conversion.Implicit.C5Nullable
{
    public class C1SameType
    {
        public C1SameType()
        {
            int a = 1;
            int? a2 = a;

            int? b = 1;
            // int b2 = b;
        }
    }
}
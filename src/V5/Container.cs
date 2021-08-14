﻿using V5.Conversion.Implicit.C03Enumeration;
using V5.Conversion.Implicit.C05Nullable;
using V5.Conversion.Implicit.C06NullLiteral;
using V5.Conversion.Implicit.C07Reference;
using V5.Conversion.Implicit.C08Boxing;
using V5.Conversion.Implicit.Enumeration;

// ReSharper disable ObjectCreationAsStatement

namespace V5
{
    public class Container
    {
        public Container()
        {
            new Case1();
            new Case2();
            new Case3();
            new Case4();
            new Case5();

            new Conversion.Implicit.C04InterpolatedString.Case1();

            new C1SameType();
            new C2DifferentTypeWithValue();
            new C3DifferentTypeWithNull();

            new ToAnyNullableType();

            new C01AnyReferenceToObject();
            new C02AnyReferenceToDynamic();
            new C03Derived();
            new C04FromInterface();
            new C05FromInterfaceToInterface();
            new C06ArrayToArray();
            new C07ArrayToSystemArray();
            new C08ArrayToIList();
            new C09Delegate();
            new C10NullLiteral();
            new C11Dynamic();
            new C12Covariance();
            new C13Contravariance();
            new C14TypeParameters();

            new C01AnyValueTypeToObject();
            new C02AnyValueTypeToSystemValueType();
            new C03NonNullableValueTypeToItsInterface();
            new C04NullableValueTypeToItsInterface();
            new C05AnyEnumTypeToSystemEnum();
            
        }
    }
}
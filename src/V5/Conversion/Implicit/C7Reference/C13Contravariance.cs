// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable UnusedTypeParameter

namespace V5.Conversion.Implicit.C7Reference
{
    public class C13Contravariance
    {
        public C13Contravariance()
        {
            Class<string> a = new Class<string>();
            IInterface<string> a2 = a;

            Class<string> b = new Class<string>();
            // IInterface<object> b2 = b;

            Class<object> c = new Class<object>();
            IInterface<string> c2 = c;
        }

        interface IInterface<in T>
        {
        }

        class Class<T> : IInterface<T>
        {
        }
    }
}
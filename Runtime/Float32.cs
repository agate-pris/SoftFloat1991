using System;
using System.Runtime.CompilerServices;

namespace SoftFloat1991 {
    struct Float32 {
        public uint Repr;

        public bool Sign {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (Repr >> 31) != 0;
        }
        public uint Exponent {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (Repr >> 23) & 0xFF;
        }
        public uint Fraction {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Repr & 0x7FFFFF;
        }
        public static explicit operator int(Float32 a) {
            throw new NotImplementedException();
        }
    }
}

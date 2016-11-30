﻿using System.Reflection.Emit;

public static partial class Extensions
{
    /// <summary>
    ///     Pops two integer values from the evaluation stack and pushes the result of comparing whether the first is less than
    ///     the second
    /// </summary>
    /// <param name="il">The <see cref="T:System.Reflection.Emit.ILGenerator" /> to emit instructions from</param>
    public static ILGenerator CompareLess(this ILGenerator il) => il.Clt();
}
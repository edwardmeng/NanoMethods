﻿using System;

public static partial class Extensions
{
    /// <summary>
    /// Converts the specified 32-bit signed integer to an enumeration member.
    /// </summary>
    /// <typeparam name="T">The enumeration type to return.</typeparam>
    /// <param name="value">The value to convert to an enumeration member.</param>
    /// <returns>An instance of the enumeration set to <paramref name="value"/>.</returns>
    public static T ToEnum<T>(this int value)
        where T : struct
    {
        return (T)Enum.ToObject(typeof(T), value);
    }
}
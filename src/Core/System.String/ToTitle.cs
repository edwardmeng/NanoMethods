﻿using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to a title case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    public static string ToTitle(this string @this)
    {
        return @this.IsNullOrEmpty() ? @this : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(@this);
    }

    /// <summary>
    ///     A string extension method that converts the @this to a title case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cultureInfo">Information describing the culture.</param>
    /// <returns>@this as a string.</returns>
    public static string ToTitle(this string @this, CultureInfo cultureInfo)
    {
        return @this.IsNullOrEmpty() ? @this : cultureInfo.TextInfo.ToTitleCase(@this);
    }

    /// <summary>
    ///     A string extension method that converts the @this to a title case.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    public static string ToTitleInvariant(this string @this)
    {
        return @this.IsNullOrEmpty() ? @this : CultureInfo.InvariantCulture.TextInfo.ToTitleCase(@this);
    }
}
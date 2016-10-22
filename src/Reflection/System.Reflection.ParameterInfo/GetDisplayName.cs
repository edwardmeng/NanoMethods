﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public static partial class Extensions
{
    public static string GetDisplayName(this ParameterInfo member, string defaultValue = null)
    {
        return member.GetDisplayName(() => defaultValue);
    }

    public static string GetDisplayName(this ParameterInfo member, Func<string> defaultValueFactory)
    {
        if (member == null)
        {
            throw new ArgumentNullException(nameof(member));
        }
        var displayNameAttribute = member.GetCustomAttribute<DisplayNameAttribute>();
        if (displayNameAttribute != null)
        {
            return displayNameAttribute.DisplayName;
        }
#if !Net35
        var displayAttribute = member.GetCustomAttribute<DisplayAttribute>();
        if (displayAttribute != null)
        {
            return displayAttribute.GetName();
        }
#endif
        var defaultValue = defaultValueFactory();
        return string.IsNullOrEmpty(defaultValue) ? member.Name : defaultValue;
    }
}
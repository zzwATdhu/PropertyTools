﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DirectoryPathAttribute.cs" company="PropertyTools">
//   http://propertytools.codeplex.com, license: Ms-PL
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PropertyTools.DataAnnotations
{
    using System;

    /// <summary>
    /// Specifies that the property is a directory path.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DirectoryPathAttribute : Attribute
    {
    }
}
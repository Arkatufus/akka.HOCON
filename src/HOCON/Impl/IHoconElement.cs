﻿//-----------------------------------------------------------------------
// <copyright file="IHoconElement.cs" company="Hocon Project">
//     Copyright (C) 2009-2015 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2015 Akka.NET project <https://github.com/akkadotnet/hocon>
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace Hocon
{
    /// <summary>
    /// This interface defines the contract needed to implement
    /// a HOCON (Human-Optimized Config Object Notation) element.
    /// </summary>
    public interface IHoconElement
    {
        IHoconElement Owner { get; }

        /// <summary>
        /// Determines whether this element is a string and all of its characters are whitespace characters.
        /// </summary>
        /// <returns><c>true</c> if every characters in value is whitespace characters; otherwise <c>false</c>.</returns>
        bool IsWhitespace();

        /// <summary>
        /// Determines whether this element is a HOCON object.
        /// </summary>
        /// <returns><c>true</c> if this element is a HOCON object; otherwise <c>false</c></returns>
        bool IsObject();

        /// <summary>
        /// Retrieves the HOCON object representation of this element.
        /// </summary>
        /// <returns>The HOCON object representation of this element.</returns>
        HoconObject GetObject();

        /// <summary>
        /// Determines whether this element is a string.
        /// </summary>
        /// <returns><c>true</c> if this element is a string; otherwise <c>false</c></returns>
        bool IsString();

        /// <summary>
        /// Retrieves the string representation of this element.
        /// </summary>
        /// <returns>The string representation of this element.</returns>
        string GetString();

        /// <summary>
        /// Determines whether this element is an array.
        /// </summary>
        /// <returns><c>true</c> if this element is aan array; otherwise <c>false</c></returns>
        bool IsArray();

        /// <summary>
        /// Retrieves a list of elements associated with this element.
        /// </summary>
        /// <returns>A list of elements associated with this element.</returns>
        IList<HoconValue> GetArray();
    }
}

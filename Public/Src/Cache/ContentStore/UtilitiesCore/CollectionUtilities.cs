// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace BuildXL.Cache.ContentStore.UtilitiesCore.Internal
{
    /// <summary>
    /// Custom implementation of Xunit collection runner.
    /// </summary>
    public static class CollectionUtilities
    {
        /// <summary>
        /// Returns an empty instance of <see cref="List{T}"/>.
        /// </summary>
        public static List<T> EmptyList<T>() => Empty<T>.EmptyList;

        /// <summary>
        /// Returns an empty instance of <typeparamref name="T"/>[].
        /// </summary>
        public static T[] EmptyArray<T>() => Empty<T>.EmptyArray;

        private static class Empty<T>
        {
            public static readonly List<T> EmptyList = new List<T>();

            public static readonly T[] EmptyArray = new T[] { };
        }

        /// <summary>
        /// Compare two operands and returns true if two instances are equivalent.
        /// </summary>
        public static bool IsCompareEquals<T>(T x1, T x2, out int compareResult, bool greatestFirst = false)
            where T : IComparable<T>
        {
            compareResult = x1.CompareTo(x2);
            if (greatestFirst)
            {
                compareResult = -compareResult;
            }

            return compareResult == 0;
        }
    }
}

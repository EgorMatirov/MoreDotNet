﻿namespace MoreDotNet.Core.Extentions.Collections
{
    using System.Collections.Generic;
    using System.Linq;

    using MoreDotNet.Core.Extentions.Common;

    /// <summary>
    /// <see cref="ICollection{T}"/> extensions.
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Adds a range of values to an ICollection.
        /// </summary>
        /// <typeparam name="T">The element type of the ICollection.</typeparam>
        /// <param name="items">The <see cref="ICollection{T}"/> instance on which the extension method is called.</param>
        /// <param name="values">The items we are adding to the ICollection.</param>
        public static void AddRange<T>(this ICollection<T> items, params T[] values)
        {
            values.ThrowIfArgumentIsNull("values");

            foreach (var value in values)
            {
                items.Add(value);
            }
        }

        /// <summary>
        /// Adds a range of values to an ICollection.
        /// </summary>
        /// <typeparam name="T">The element type of the ICollection.</typeparam>
        /// <param name="items">The <see cref="ICollection{T}"/> instance on which the extension method is called.</param>
        /// <param name="values">The items we are adding to the ICollection.</param>
        public static void AddRange<T>(this ICollection<T> items, IEnumerable<T> values)
        {
            values.ThrowIfArgumentIsNull("values");

            foreach (var value in values)
            {
                items.Add(value);
            }
        }

        /// <summary>
        /// Checks if a collections is null or empty.
        /// </summary>
        /// <typeparam name="T">The item type of the ICollection.</typeparam>
        /// <param name="items">The <see cref="ICollection{T}"/> instance on which the extension method is called.</param>
        /// <returns>True if the collection is null or empty</returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> items)
        {
            return items == null || !items.Any();
        }
    }
}

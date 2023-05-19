namespace CW.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CauseConfiguration : IEntityTypeConfiguration<Cause>
    {
        // Implements the Configure method required by IEntityTypeConfiguration
        public void Configure(EntityTypeBuilder<Cause> builder)
        {
            // Configures the Signatures property to use a custom conversion and value comparer
            builder.Property(c => c.Signatures)
                .HasConversion(
                    v => string.Join(',', v),  // Converts a list of strings to a comma-separated string
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() // Converts a comma-separated string to a list of strings
                )
                .Metadata.SetValueComparer(new ListComparer<string>()); // Uses a custom value comparer for lists of strings
        }
    }

    // Defines a custom value comparer for lists of objects of type T
    public class ListComparer<T> : ValueComparer<List<T>>
    {
        // Implements the constructor required by ValueComparer
        public ListComparer() : base(
            (c1, c2) => c1.SequenceEqual(c2), // Compares two lists for equality by checking if they have the same elements in the same order
            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())), // Computes a hash code for the list based on the hash codes of its elements
            c => c.ToList()) // Creates a new list that is a copy of the original list
        { }
    }
}

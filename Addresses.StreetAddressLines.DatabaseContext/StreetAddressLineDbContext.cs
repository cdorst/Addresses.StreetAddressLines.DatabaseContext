// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Addresses.ZipCodes.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Addresses.StreetAddressLines.DatabaseContext
{
    /// <summary>EntityFrameworkCore database context for StreetAddressLine entities</summary>
    public class StreetAddressLineDbContext : ZipCodeDbContext
    {
        /// <summary>Constructs StreetAddressLineDbContext EntityFrameworkCore database context using given options</summary>
        public StreetAddressLineDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>Contains set of StreetAddressLine entities</summary>
        public DbSet<StreetAddressLine> StreetAddressLines { get; set; }

        /// <summary>Configures EntityFramework database creation - adds unique index to model</summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StreetAddressLine>().HasIndex(new StreetAddressLine().GetUniqueIndex()).IsUnique();
        }
    }
}

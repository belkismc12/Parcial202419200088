using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parcial202419200088.Data;

public partial class Parcial202419200088DbContext : DbContext
{
    public Parcial202419200088DbContext()
    {
    }

    public Parcial202419200088DbContext(DbContextOptions<Parcial202419200088DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<JobOffer> JobOffer { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Parcial202419200088;Integrated Security=true;TrustServerCertificate=True");

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
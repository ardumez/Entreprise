using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Entreprise.Models;

namespace Entreprise.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180105230651_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entreprise.Models.Lead", b =>
                {
                    b.Property<long>("LeadID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long?>("ProviderID");

                    b.HasKey("LeadID");

                    b.HasIndex("ProviderID");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("Entreprise.Models.Provider", b =>
                {
                    b.Property<long>("ProviderID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ProviderID");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Entreprise.Models.Lead", b =>
                {
                    b.HasOne("Entreprise.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderID");
                });
        }
    }
}

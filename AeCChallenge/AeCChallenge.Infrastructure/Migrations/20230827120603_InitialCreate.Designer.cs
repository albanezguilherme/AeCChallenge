﻿// <auto-generated />
using AeCChallenge.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AeCChallenge.Infrastructure.Migrations
{
    [DbContext(typeof(AeCChallengeContext))]
    [Migration("20230827120603_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AeCChallenge.Core.Entities.AirportWeather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("atualizado_em")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigo_icao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicao_Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("direcao_vento")
                        .HasColumnType("int");

                    b.Property<int>("pressao_atmosferica")
                        .HasColumnType("int");

                    b.Property<int>("temp")
                        .HasColumnType("int");

                    b.Property<int>("umidade")
                        .HasColumnType("int");

                    b.Property<int>("vento")
                        .HasColumnType("int");

                    b.Property<string>("visibilidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AirportWeathers");
                });

            modelBuilder.Entity("AeCChallenge.Core.Entities.CityWeather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("atualizado_em")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clima_data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CityWeathers");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server;

namespace Mediwatch.Server.Migrations.DbContextMediwatchMigrations
{
    [DbContext(typeof(DbContextMediwatch))]
    [Migration("20200603224721_CreateMediwatchDb")]
    partial class CreateMediwatchDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");
#pragma warning restore 612, 618
        }
    }
}
﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using kinderkultur.Models;

namespace kinderkultur.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20170510211502_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("kinderkultur.Models.Person", b =>
                {
                    b.Property<long>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Vorname");

                    b.Property<string>("eMail");

                    b.HasKey("Key");

                    b.ToTable("Personen");
                });
        }
    }
}

﻿// <auto-generated />
using System;
using MVCTestApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCTestApplication.Migrations
{
    [DbContext(typeof(TodoDBContext))]
    partial class TodoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("MVCTestApplication.Models.TodoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DueAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TodoItemId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TodoItemId");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("MVCTestApplication.Models.TodoItem", b =>
                {
                    b.HasOne("MVCTestApplication.Models.TodoItem", null)
                        .WithMany("MyProperty")
                        .HasForeignKey("TodoItemId");
                });
#pragma warning restore 612, 618
        }
    }
}

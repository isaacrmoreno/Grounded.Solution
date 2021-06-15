﻿// <auto-generated />
using Grounded.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Grounded.Migrations
{
    [DbContext(typeof(GroundedContext))]
    partial class GroundedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Grounded.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ResourceColor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceExercise")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceImage")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceLink")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceMusic")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ResourceQuote")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ResourceId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ResourceId = 1,
                            ResourceColor = "Orange",
                            ResourceExercise = "Everyday is a half day if you just fucking leave.",
                            ResourceImage = "Lets see if this loads",
                            ResourceLink = "https://www.sadanduseless.com/legs-or-sausages-gallery/",
                            ResourceMusic = "cheerful",
                            ResourceName = "Anxiety",
                            ResourceQuote = "It's okay to talk about mental health issues. It's okay to admit that you have anxiety. It doesn't take away from your power. It's totally normal. - Torrey DeVitto"
                        },
                        new
                        {
                            ResourceId = 2,
                            ResourceColor = "",
                            ResourceExercise = "",
                            ResourceImage = "../",
                            ResourceLink = "",
                            ResourceMusic = "",
                            ResourceName = "Guilt",
                            ResourceQuote = "I think the saddest thing is how people take on guilt and blame that isn't theirs or doesn't belong to them, and how hard it is to forgive yourself. - Wunmi Mosaku"
                        },
                        new
                        {
                            ResourceId = 3,
                            ResourceColor = "",
                            ResourceExercise = "",
                            ResourceImage = "",
                            ResourceLink = "",
                            ResourceMusic = "",
                            ResourceName = "Depression",
                            ResourceQuote = "My mental health problems are real and they are valid. I will not judge myself for the bad days when I can barely get out of bed. I will not make myself feel worse because someone else appears to be handling their mental illness better than I am handling mine. Recovery is not a competition. - Matt Joseph Diaz"
                        },
                        new
                        {
                            ResourceId = 4,
                            ResourceColor = "blue-green",
                            ResourceExercise = "5, 4, 3, 2, 1 Mindfulness exercise",
                            ResourceImage = "",
                            ResourceLink = "https://drsarahallen.com/7-ways-to-calm/",
                            ResourceMusic = "https://open.spotify.com/track/6epIhVc3Zn6AUZ27EsOLZt?si=5d8e25c2b00d4d6e",
                            ResourceName = "Restless",
                            ResourceQuote = "Sometimes the most important thing in a whole day is the rest we take between two deep breaths. – Etty Hillesum."
                        },
                        new
                        {
                            ResourceId = 5,
                            ResourceColor = "Lavender",
                            ResourceExercise = "Box Breathing",
                            ResourceImage = "",
                            ResourceLink = "https://www.healthline.com/health/box-breathing",
                            ResourceMusic = "https://open.spotify.com/track/4z0X671zhnwxj9YklzDyhv?si=abf5c8e6129b498f",
                            ResourceName = "Fear",
                            ResourceQuote = "Fears are nothing more than a state of mind. - Napoleon Hill"
                        },
                        new
                        {
                            ResourceId = 6,
                            ResourceColor = "",
                            ResourceExercise = "",
                            ResourceImage = "",
                            ResourceLink = "",
                            ResourceMusic = "",
                            ResourceName = "Depression",
                            ResourceQuote = ""
                        },
                        new
                        {
                            ResourceId = 7,
                            ResourceColor = "",
                            ResourceExercise = "",
                            ResourceImage = "",
                            ResourceLink = "",
                            ResourceMusic = "",
                            ResourceName = "Depression",
                            ResourceQuote = ""
                        },
                        new
                        {
                            ResourceId = 8,
                            ResourceColor = "",
                            ResourceExercise = "",
                            ResourceImage = "",
                            ResourceLink = "",
                            ResourceMusic = "",
                            ResourceName = "Depression",
                            ResourceQuote = ""
                        },
                        new
                        {
                            ResourceId = 9,
                            ResourceColor = "",
                            ResourceExercise = "",
                            ResourceImage = "",
                            ResourceLink = "",
                            ResourceMusic = "",
                            ResourceName = "Depression",
                            ResourceQuote = ""
                        },
                        new
                        {
                            ResourceId = 10,
                            ResourceColor = "",
                            ResourceExercise = "",
                            ResourceImage = "",
                            ResourceLink = "",
                            ResourceMusic = "",
                            ResourceName = "Depression",
                            ResourceQuote = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

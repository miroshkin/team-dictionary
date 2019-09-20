﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using team_dictionary.Data;

namespace teamdictionary.Migrations
{
    [DbContext(typeof(TeamDictionaryContext))]
    [Migration("20190920085753_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("team_dictionary.Data.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Translation");

                    b.Property<string>("Word");

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("team_dictionary.Data.SqlQuery", b =>
                {
                    b.Property<int>("SqlQueryId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<string>("Name");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("SqlQueryId");

                    b.HasIndex("ArticleId");

                    b.ToTable("SqlQueries");
                });

            modelBuilder.Entity("team_dictionary.Data.Translation", b =>
                {
                    b.Property<int>("TranslationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<bool>("BestTranslation");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("TranslationId");

                    b.HasIndex("ArticleId");

                    b.ToTable("Translations");
                });

            modelBuilder.Entity("team_dictionary.Data.SqlQuery", b =>
                {
                    b.HasOne("team_dictionary.Data.Article")
                        .WithMany("SqlQueries")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("team_dictionary.Data.Translation", b =>
                {
                    b.HasOne("team_dictionary.Data.Article")
                        .WithMany("Translations")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

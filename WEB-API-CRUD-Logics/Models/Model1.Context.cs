﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_API_CRUD_Logics.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TheAgoraDBEntities : DbContext
    {
        public TheAgoraDBEntities()
            : base("name=TheAgoraDBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // MarketListing configuration
            modelBuilder.Entity<MarketListing>()
                .HasKey(ml => ml.ListingID);

            modelBuilder.Entity<MarketListing>()
                .HasOptional(ml => ml.User)
                .WithMany() // Assuming no navigation property on User for MarketListings
                .HasForeignKey(ml => ml.UserID)
                .WillCascadeOnDelete(false); // Adjust delete behavior as needed

            // ForumPost configuration
            modelBuilder.Entity<ForumPost>()
                .HasKey(fp => fp.PostID);

            modelBuilder.Entity<ForumPost>()
                .HasOptional(fp => fp.User)
                .WithMany() // Assuming no navigation property on User for ForumPosts
                .HasForeignKey(fp => fp.UserID)
                .WillCascadeOnDelete(false); // Adjust delete behavior as needed

            modelBuilder.Entity<ForumPost>()
                .HasMany(fp => fp.ForumComments)
                .WithRequired(fc => fc.ForumPost)
                .HasForeignKey(fc => fc.PostID)
                .WillCascadeOnDelete(true); // Adjust delete behavior as needed

            // ForumComment configuration
            modelBuilder.Entity<ForumComment>()
                .HasKey(fc => fc.CommentID); // Primary Key

            modelBuilder.Entity<ForumComment>()
                .HasRequired(fc => fc.User)
                .WithMany() // Assuming no navigation property on User for ForumComments
                .HasForeignKey(fc => fc.UserID)
                .WillCascadeOnDelete(false); // Adjust delete behavior as needed

            modelBuilder.Entity<ForumComment>()
                .HasRequired(fc => fc.ForumPost)
                .WithMany(fp => fp.ForumComments)
                .HasForeignKey(fc => fc.PostID)
                .WillCascadeOnDelete(true); // Adjust delete behavior as needed

            modelBuilder.Entity<ForumComment>()
                .HasOptional(fc => fc.Comment)
                .WithMany() // Assuming no navigation property on Comment for ForumComments
                .HasForeignKey(fc => fc.CommentID) // CommentID is a foreign key as well
                .WillCascadeOnDelete(false);

            // AnnouncementComment configuration
            modelBuilder.Entity<AnnouncementComment>()
                .HasKey(ac => ac.CommentID);

            modelBuilder.Entity<AnnouncementComment>()
                .HasRequired(ac => ac.Announcement)
                .WithMany() // Assuming no navigation property on Announcement for AnnouncementComments
                .HasForeignKey(ac => ac.AnnouncementID)
                .WillCascadeOnDelete(false); // Adjust delete behavior as needed

            modelBuilder.Entity<AnnouncementComment>()
                .HasRequired(ac => ac.User)
                .WithMany() // Assuming no navigation property on User for AnnouncementComments
                .HasForeignKey(ac => ac.UserID)
                .WillCascadeOnDelete(false); // Adjust delete behavior as needed

            modelBuilder.Entity<AnnouncementComment>()
                .HasRequired(ac => ac.Comment)
                .WithMany() // Assuming no navigation property on Comment for AnnouncementComments
                .HasForeignKey(ac => ac.CommentID)
                .WillCascadeOnDelete(false);
        }


        /*
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //  throw new UnintentionalCodeFirstException();

                // MarketListing configuration
                modelBuilder.Entity<MarketListing>()
                    .HasKey(ml => ml.ListingID);

                modelBuilder.Entity<MarketListing>()
                    .HasOne(ml => ml.User)
                    .WithMany() // Assuming no navigation property on User for MarketListings
                    .HasForeignKey(ml => ml.UserID)
                    .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior as needed

                // ForumPost configuration
                modelBuilder.Entity<ForumPost>()
                    .HasKey(fp => fp.PostID);

                modelBuilder.Entity<ForumPost>()
                    .HasOne(fp => fp.User)
                    .WithMany() // Assuming no navigation property on User for ForumPosts
                    .HasForeignKey(fp => fp.UserID)
                    .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior as needed

                modelBuilder.Entity<ForumPost>()
                    .HasMany(fp => fp.ForumComments)
                    .WithOne(fc => fc.ForumPost)
                    .HasForeignKey(fc => fc.PostID)
                    .OnDelete(DeleteBehavior.Cascade); // Adjust delete behavior as needed

                // ForumComment configuration
                modelBuilder.Entity<ForumComment>()
                    .HasKey(fc => fc.CommentID); // Primary Key

                modelBuilder.Entity<ForumComment>()
                    .HasOne(fc => fc.User)
                    .WithMany() // Assuming no navigation property on User for ForumComments
                    .HasForeignKey(fc => fc.UserID)
                    .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior as needed

                modelBuilder.Entity<ForumComment>()
                    .HasOne(fc => fc.ForumPost)
                    .WithMany(fp => fp.ForumComments)
                    .HasForeignKey(fc => fc.PostID)
                    .OnDelete(DeleteBehavior.Cascade); // Adjust delete behavior as needed

                modelBuilder.Entity<ForumComment>()
                    .HasOne(fc => fc.Comment)
                    .WithMany() // Assuming no navigation property on Comment for ForumComments
                    .HasForeignKey(fc => fc.CommentID) // CommentID is a foreign key as well
                    .OnDelete(DeleteBehavior.Restrict);


            }*/

        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<AnnouncementComment> AnnouncementComments { get; set; }
        public virtual DbSet<Bookmark> Bookmarks { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<ForumComment> ForumComments { get; set; }
        public virtual DbSet<ForumPost> ForumPosts { get; set; }
        public virtual DbSet<MarketListing> MarketListings { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }


}

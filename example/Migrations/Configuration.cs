namespace example.Migrations
{
    using example.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<example.Models.AlbumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(example.Models.AlbumContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            var album1 = new Album
            {
                albumArtist = " Frank Casino",
                albumName = "IM hungry",
                albumPicture = "frank.png",
                albumYear = DateTime.Now,
                date_created = DateTime.Now,
                id= Guid.NewGuid(),
                isActive = true
            };
            var album2 = new Album
            {
                albumArtist = "Drake",
                albumName = "Its too late",
                albumPicture = "Drake.png",
                albumYear = DateTime.Now,
                date_created = DateTime.Now,
                id = Guid.NewGuid(),
                isActive=true
            };

           // context.albums.Add(album1);
            //context.albums.Add(album2);
            //context.SaveChanges();

            var rew = new reviews
            {
                id=Guid.NewGuid(),
                albumID=Guid.Parse( "cdee176e-c360-4f0c-97a4-2a7e0bf2f4e3"),
                name="Godfrey",
                isActive=true,
                date_created=DateTime.Now,
                review="this album is wack"

            };
            var rew1 = new reviews
            {
                id = Guid.NewGuid(),
                albumID = Guid.Parse("3e475ea0-dfd3-489a-aaf4-9a12a4dfe1b8"),
                name = "Godfrey",
                isActive = true,
                date_created = DateTime.Now,
                review = "this album is wack"

            };
            context.reviews.Add(rew);
            context.reviews.Add(rew1);
            context.SaveChanges();
        }
    }
}

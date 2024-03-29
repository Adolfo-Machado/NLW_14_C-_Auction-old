﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories
{
    public class RocketseatAuctionDbContext : DbContext
    {
        public RocketseatAuctionDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(@"Data Source=C:\Cursos\RocketSeat\NLW-14\C#\Arquivos\leilaoDbNLW.db");
        //}
    }
}

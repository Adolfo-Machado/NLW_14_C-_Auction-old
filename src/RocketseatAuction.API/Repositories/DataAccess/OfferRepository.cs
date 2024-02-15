﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess
{
    public class OfferRepository : IOfferRepository
    {
        private readonly RocketseatAuctionDbContext _dbContext;
        public OfferRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;
        public void Add(Offer offer)
        {
            _dbContext.Offers.Add(offer);

            _dbContext.SaveChanges();

        }

        public List<Offer> GetAll ()
        {
            return _dbContext.Offers
                .Include(offer => offer.User)
                .Include(offer => offer.Item)
                .ToList();
        }
    }
}
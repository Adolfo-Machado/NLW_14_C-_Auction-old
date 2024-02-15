using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.UseCases.Offers.GetOffers
{
    public class GetOffersUseCase
    {
        public class GetOffers
        {
            private readonly IAuctionRepository _repository;

            public GetOffers(IAuctionRepository repository) => _repository = repository;
            
        }
    }
}

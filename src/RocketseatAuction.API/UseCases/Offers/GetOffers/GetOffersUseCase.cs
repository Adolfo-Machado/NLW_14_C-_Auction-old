using RocketseatAuction.API.Contracts;

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

using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HoteListingDbContext _context;

        public CountriesRepository(HoteListingDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            var country = await _context.Countries.Include(q => q.Hotels)
                            .FirstOrDefaultAsync(q => q.Id == id);

            return country; 
        }
    }
}

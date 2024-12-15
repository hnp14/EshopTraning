using Microsoft.EntityFrameworkCore;

namespace ShopTraning.Web.Context
{
    public class ShopDb : DbContext
    {
        public ShopDb(DbContextOptions<ShopDb> options) : base(options) { }
    }
}

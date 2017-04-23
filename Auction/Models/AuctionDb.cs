using System.Data.Entity;

// Package Manager Console
// ... for migrations ...
// PM> Enable-Migrations -ContextTypeName AuctionDb
// s.a. Migrations folder
// ... then PM> Update-Database
// For missing Migrations/Initial.cs
// http://stackoverflow.com/questions/11679385/reset-entity-framework-migrations
// ===> PM> Add-Migration Initial

namespace Auction.Models
{
    public class AuctionDb : DbContext
    {
        public AuctionDb()
            : base("name=DefaultConnection")
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemBid> ItemBids { get; set; }
        //public DbSet<UserProfile> UserProfiles { get; set; }

        //public System.Data.Entity.DbSet<CHSAuction.Models.ItemListViewModel> ItemListViewModels { get; set; }
    }
}
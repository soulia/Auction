using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Auction.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Image { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public int Value { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public int MinimumBid { get; set; }
        // virtual helps EF load up the collection in the Views
        public virtual ICollection<ItemBid> Bids { get; set; }
    }
}

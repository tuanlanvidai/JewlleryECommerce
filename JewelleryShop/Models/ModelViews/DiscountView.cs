using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelleryShop.Models.ModelViews
{
	public class DiscountView
	{
        public int ID { get; set; } = 0;

        public string DiscountName { get; set; } = "";

        public decimal Value { get; set; } = 0;

        public DateTime CreateDateAt { get; set; } = DateTime.Now;

        public DateTime EndDateAt { get; set; }

        public int Stock { get; set; } = 0;
    }
}
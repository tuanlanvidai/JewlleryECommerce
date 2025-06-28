using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelleryShop.Models.ModelViews
{
	public class BillView
	{
        public int ID { get; set; } = 0;

        public DateTime CreateDayAt { get; set; } = DateTime.Now;

        public decimal TotalPice { get; set; } = 0;

        public int OrderID { get; set; } = 0;
    }
}
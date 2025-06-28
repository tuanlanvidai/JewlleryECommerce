using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JewelleryShop.Models.ModelViews
{
	public class UserView
	{
        public int ID { get; set; } = 0;

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public string Phone { get; set; } = "";

        public string Address { get; set; } = "";

        public DateTime CreateDayAt { get; set; } = DateTime.Now;

        public int status { get; set; } = 1;

        public int RoleId { get; set; } = 0;
    }
}
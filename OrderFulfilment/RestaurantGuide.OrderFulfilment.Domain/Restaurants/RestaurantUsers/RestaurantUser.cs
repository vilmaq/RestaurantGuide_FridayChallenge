﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantGuide.Domain.Restaurants.RestaurantUsers
{
   public class RestaurantUser
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int UserId { get; set; }

    }
}

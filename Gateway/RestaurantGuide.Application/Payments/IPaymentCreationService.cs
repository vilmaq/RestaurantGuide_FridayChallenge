﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGuide.Application.Payments
{
    public interface IPaymentCreationService
    {

        public Task CreatePaymentAsync(int orderId, string paymentType);
    }
}

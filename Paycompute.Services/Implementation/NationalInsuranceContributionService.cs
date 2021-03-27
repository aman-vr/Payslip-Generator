﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Paycompute.Services.Implementation
{
    public class NationalInsuranceContributionService : INationalInsuranceContributionService
    {
        private decimal NIRate;
        private decimal NIC;
        public decimal NIContribution(decimal totalAmount)
        {
            if(totalAmount < 719)
            {
                NIRate = 0.0m;
                NIC = 0m;
            }
            else if(totalAmount <= 4167)
            {
                NIRate = 0.12m;
                NIC = (totalAmount - 719) * NIRate;
            }
            else
            {
                NIRate = 0.02m;
                NIC = (4167 - 719) * 0.12m + (totalAmount - 4167) * NIRate;
            }
            return NIC;
        }
    }
}
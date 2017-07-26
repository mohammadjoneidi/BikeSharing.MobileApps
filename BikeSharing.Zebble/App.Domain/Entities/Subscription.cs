﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Subscription
    {
        public int Id { get; set; }
        public string CreditCard { get; set; }
        public string CreditCardType { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}

using System;

namespace OOP_With_CSharp
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            this.Name = "Gabriel";
            this.Id = 1;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie1
{
    internal class Randomizer : IRandomizer
    {
        private readonly List<string> Coupons = new();
        private readonly Random random = new();

        public void AddNewCoupon(string value) => Coupons.Add(value);
        
        public List<string> GetAllCoupons() => Coupons;

        public string GetRandomCoupon()
        {
            int randomCouponIndex = random.Next(Coupons.Count);
            string randomCoupon = Coupons[randomCouponIndex];
            Coupons.RemoveAt(randomCouponIndex);
            return randomCoupon;
        }

        public bool IsCouponListEmpty() => !(Coupons?.Any() ?? false);
    }
}

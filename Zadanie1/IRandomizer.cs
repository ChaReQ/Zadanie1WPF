using System.Collections.Generic;

namespace Zadanie1
{
    internal interface IRandomizer
    {
        public void AddNewCoupon(string value);

        public List<string> GetAllCoupons();

        public string GetRandomCoupon();

        public bool IsCouponListEmpty();
    }
}

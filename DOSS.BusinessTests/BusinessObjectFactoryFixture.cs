using DOSS.Business.Categories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOSS.BusinessTests
{
    public class BusinessObjectFactoryFixture : IDisposable
    {
        public readonly List<DeliveryCategory> DeliveryCategories;

        public BusinessObjectFactoryFixture()
        {
            DeliveryCategories = new List<DeliveryCategory>
            {
                new Reject(),
                new Heavy(),
                new Small(),
                new Medium(),
                new Large()
            };
        }

        public void Dispose()
        { }
    }
}

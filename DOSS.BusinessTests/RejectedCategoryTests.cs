using DOSS.Business.Enums;
using DOSS.Business.Helpers;
using DOSS.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DOSS.BusinessTests
{
    public class RejectedCategoryTests : IClassFixture<BusinessObjectFactoryFixture>
    {
        readonly BusinessObjectFactoryFixture BusinessObjectFactoryFixture;

        public RejectedCategoryTests(BusinessObjectFactoryFixture fixture)
        {
            BusinessObjectFactoryFixture = fixture;
        }


        [Fact]
        public void ShouldReturn_Small()
        {
            // arrange
            var expected = new DeliveryResult(
                new Delivery
                {
                    Category = DeliveryCategoryEnum.Rejected,
                    Cost = null
                });

            var parcel = new Parcel
            {
                Weight = 110,
                Height = 20,
                Width = 55,
                Depth = 120
            };

            // act 
            var deliveryHelper = new DeliveryHelper(BusinessObjectFactoryFixture.DeliveryCategories);
            var actual = deliveryHelper.GetDelivery(parcel);

            // assert
            Assert.Equal(expected.Category, actual.Category);
            Assert.Equal(expected.Cost, actual.Cost);
        }


    }
}

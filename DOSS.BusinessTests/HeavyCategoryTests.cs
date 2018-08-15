using DOSS.Business.Categories;
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
    public class HeavyCategoryTests : IClassFixture<BusinessObjectFactoryFixture>
    {
        readonly BusinessObjectFactoryFixture BusinessObjectFactoryFixture;

        public HeavyCategoryTests(BusinessObjectFactoryFixture fixture)
        {
            BusinessObjectFactoryFixture = fixture;
        }

        [Fact]
        public void ShouldReturn_Heavy()
        {
            // arrange
            var expected = new DeliveryResult(
                new Delivery
                {
                    Category = DeliveryCategoryEnum.Heavy,
                    Cost = 180m
                });

            // act 
            var deliveryHelper = new DeliveryHelper(BusinessObjectFactoryFixture.DeliveryCategories);
            var actual = deliveryHelper.GetDelivery(new Parcel
            {
                Weight = 12,

                Height = 12,
                Width = 12,
                Depth = 12
            });

            // assert
            Assert.Equal(expected.Category, actual.Category);
            Assert.Equal(expected.Cost, actual.Cost);
        }

        [Fact]
        public void ShouldReturn_Heavy_Basic()
        {
            // arrange
            var expected = new DeliveryResult(
                new Delivery
                {
                    Category = DeliveryCategoryEnum.Heavy,
                    Cost = 330m
                });

            var parcel = new Parcel
            {
                Weight = 22,
                Height = 5,
                Width = 5,
                Depth = 5
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

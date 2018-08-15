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
    public class MediumCategoryTests : IClassFixture<BusinessObjectFactoryFixture>
    {
        readonly BusinessObjectFactoryFixture BusinessObjectFactoryFixture;

        public MediumCategoryTests(BusinessObjectFactoryFixture fixture)
        {
            BusinessObjectFactoryFixture = fixture;
        }


        [Fact]
        public void ShouldReturnMedium()
        {
            // arrange
            var expected = new DeliveryResult(
                new Delivery
                {
                    Category = DeliveryCategoryEnum.Medium,
                    Cost = 80m
                });

            // act 
            var deliveryHelper = new DeliveryHelper(BusinessObjectFactoryFixture.DeliveryCategories);
            var actual = deliveryHelper.GetDelivery(new Parcel
            {
                Weight = 10,
                Height = 20,
                Width = 5,
                Depth = 20
            });

            // assert
            Assert.Equal(expected.Category, actual.Category);
            Assert.Equal(expected.Cost, actual.Cost);
        }
    }
}

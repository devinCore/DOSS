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
    public class LargeCategoryTests : IClassFixture<BusinessObjectFactoryFixture>
    {
        readonly BusinessObjectFactoryFixture BusinessObjectFactoryFixture;

        public LargeCategoryTests(BusinessObjectFactoryFixture fixture)
        {
            BusinessObjectFactoryFixture = fixture;
        }

        [Fact]
        public void ShouldReturn_Large()
        {
            // arrange
            var expected = new DeliveryResult(
                new Delivery
                {
                    Category = DeliveryCategoryEnum.Large,
                    Cost = 90m
                });

            // act 
            var deliveryHelper = new DeliveryHelper(BusinessObjectFactoryFixture.DeliveryCategories);
            var actual = deliveryHelper.GetDelivery(new Parcel
            {
                Weight = 10,

                Height = 20,
                Width = 15,
                Depth = 10
            });

            // assert
            Assert.Equal(expected.Category, actual.Category);
            Assert.Equal(expected.Cost, actual.Cost);
        }
    }
}

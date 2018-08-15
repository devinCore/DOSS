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
    public class SmallCategoryTests : IClassFixture<BusinessObjectFactoryFixture>
    {
        readonly BusinessObjectFactoryFixture BusinessObjectFactoryFixture;

        public SmallCategoryTests(BusinessObjectFactoryFixture fixture)
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
                    Category = DeliveryCategoryEnum.Small,
                    Cost = 50m
                });

            // act 
            var deliveryHelper = new DeliveryHelper(BusinessObjectFactoryFixture.DeliveryCategories);
            var actual = deliveryHelper.GetDelivery(new Parcel
            {
                Weight = 10,

                Height = 20,
                Width = 10,
                Depth = 5
            });

            // assert
            Assert.Equal(expected.Category, actual.Category);
            Assert.Equal(expected.Cost, actual.Cost);
        }


        [Fact]
        public void ShouldReturn_CategorySmall_And_CostOf2()
        {
            // arrange
            var expected = new DeliveryResult(
                new Delivery
                {
                    Category = DeliveryCategoryEnum.Small,
                    Cost = 2m
                });

            // act 
            var deliveryHelper = new DeliveryHelper(BusinessObjectFactoryFixture.DeliveryCategories);
            var actual = deliveryHelper.GetDelivery(new Parcel
            {
                Weight = 3,

                Height = 2,
                Width = 4,
                Depth = 5
            });

            // assert
            Assert.Equal(expected.Category, actual.Category);
            Assert.Equal(expected.Cost, actual.Cost);
        }


        [Fact]
        public void ShouldReturn_CategorySmall_And_CostOfPoint18()
        {
            // arrange
            var expected = new DeliveryResult(
                new Delivery
                {
                    Category = DeliveryCategoryEnum.Small,
                    Cost = .18m
                });

            // act 
            var deliveryHelper = new DeliveryHelper(BusinessObjectFactoryFixture.DeliveryCategories);
            var actual = deliveryHelper.GetDelivery(new Parcel
            {
                Weight = 2.12m,

                Height = 5.42m,
                Width = 3.4m,
                Depth = .2m
            });

            // assert
            Assert.Equal(expected.Category, actual.Category);
            Assert.Equal(expected.Cost, actual.Cost);
        }


    }
}

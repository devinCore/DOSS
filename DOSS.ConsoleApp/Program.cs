using DOSS.Business.Categories;
using DOSS.Business.Models;
using System;

namespace DOSS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var parcel = RetrieveInput();

            var deliveryHelper = BusinessObjectFactory.CreateDeliveryHelper;

            var deliveryResult = deliveryHelper.GetDelivery(parcel);
            
            Console.WriteLine($"Category: {deliveryResult.Category}");
            Console.WriteLine(string.Format("Cost: {0:C}", deliveryResult.Cost));

            Console.ReadLine();
        }

        public static Parcel RetrieveInput()
        {
            bool weightConversionResult, heightConversionResult, widthConversionResult, depthConversionResult;
            weightConversionResult = heightConversionResult = widthConversionResult = depthConversionResult = false;

            decimal weightResult, heightResult, widthResult, depthtResult;
            weightResult = heightResult = widthResult = depthtResult = 0;

            bool isCorrectInputs = false;
            Parcel parcel = null;

            do
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                if (!weightConversionResult)
                {
                    Console.Write("Input Weight: ");
                    weightConversionResult = Decimal.TryParse(Console.ReadLine(), out weightResult);
                    if (!weightConversionResult)
                    {
                        Console.WriteLine("Incorrect Input. Please input a numeric character");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"Input Weight: {weightResult}");
                }

                if (!heightConversionResult)
                {
                    Console.Write("Input Height: ");
                    heightConversionResult = Decimal.TryParse(Console.ReadLine(), out heightResult);
                    if (!heightConversionResult) 
                    {
                        Console.WriteLine("Incorrect Input. Please input a numeric character");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"Input Height: {heightResult}");
                }

                if (!widthConversionResult)
                {
                    Console.Write("Input Width: ");
                    widthConversionResult = Decimal.TryParse(Console.ReadLine(), out widthResult);
                    if (!widthConversionResult)
                    {
                        Console.WriteLine("Incorrect Input. Please input a numeric character");
                        continue;
                    }
                    
                }
                else
                {
                    Console.WriteLine($"Input Width: {widthResult}");
                }

                if (!depthConversionResult)
                {
                    Console.Write("Input Depth: ");
                    depthConversionResult = Decimal.TryParse(Console.ReadLine(), out depthtResult);
                    if (!depthConversionResult)
                    {
                        Console.WriteLine("Incorrect Input. Please input a numeric character");
                        continue;
                    }
                    isCorrectInputs = true;

                }
                else
                {
                    Console.WriteLine($"Input Depth: {depthtResult}");
                }

                parcel = BusinessObjectFactory.CreateParcel(weightResult, heightResult, widthResult, depthtResult);
            }
            while (!isCorrectInputs);

            Console.WriteLine("------------------------------------------------------------------------------");

            return parcel;
        }

    }
}

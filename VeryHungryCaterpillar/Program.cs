namespace VeryHungryCaterpillar
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("The very hungry caterpillar is a book for children written and illustrated by Eric Carle (https://en.wikipedia.org/wiki/The_Very_Hungry_Caterpillar)");
            Console.WriteLine("This program is inspired by it.");

            string caterpillar = "";
            string[] eatenFoodType = { };
            int[] eatenFoodQuantity = { };
            int? caterpillarSize = 0;

            string log = "";

            string day = "Sunday";
            while (true)
            {
                if (day == "Sunday")
                {
                    Trace.WriteLine("Day is Sunday");

                    caterpillar = "";
                    caterpillarSize = 0;
                    Console.WriteLine("The very hungry caterpillar was just an egg");
                    day = "Monday";

                    Trace.WriteLine("Day changed to Monday");
                }
                else if (day == "Monday")
                {
                    Trace.WriteLine("Day is Monday");

                    caterpillar = "@";
                    caterpillarSize = 1;
                    eatenFoodType = new[] { "Apple" };
                    eatenFoodQuantity = new[] { 1, 2 };
                    Console.WriteLine("On " + day + " the very hungry caterpillar ate " + eatenFoodQuantity[0] + " " + eatenFoodType[0]);
                    Console.WriteLine(caterpillar + "Size: " + caterpillarSize);
                    day = "Tuesday";

                    Trace.WriteLine("Day changed to Tuesday");
                }
                else if (day == "Tuesday")
                {
                    Trace.WriteLine("Day is Tuesday");

                    caterpillar = "@@";
                    caterpillarSize = 2;
                    eatenFoodType = new[] { "Apple", "Pear" };
                    eatenFoodQuantity = new[] { 1, 2 };
                    Console.WriteLine("On " + day + " the very hungry caterpillar ate " + eatenFoodQuantity[1] + " " + eatenFoodType[1]);
                    Console.WriteLine(caterpillar + "Size: " + caterpillarSize);
                    day = "Wednesday";

                    Trace.WriteLine("Day changed to Wednesday");
                }
                else if (day == "Wednesday")
                {
                    Trace.WriteLine("Day is Wednesday");

                    caterpillar = "@@@";
                    caterpillarSize = 3;
                    eatenFoodType = new[] { "Apple", "Pear", "Plum" };
                    eatenFoodQuantity = new[] { 1, 2, 3 };
                    Console.WriteLine("On " + day + " the very hungry caterpillar ate " + eatenFoodQuantity[2] + " " + eatenFoodType[2]);
                    Console.WriteLine(caterpillar + "Size: " + caterpillarSize);
                    day = "Thursday";

                    Trace.WriteLine("Day changed to Thursday");
                }
                else if (day == "Thursday")
                {
                    Trace.WriteLine("Day is Thursday");

                    caterpillar = "@@@@";
                    caterpillarSize = 4;
                    eatenFoodType = new[] { "Apple", "Pear", "Plum", "Straberries" };
                    eatenFoodQuantity = new[] { 1, 2, 3, 4 };
                    Console.WriteLine("On " + day + " the very hungry caterpillar ate " + eatenFoodQuantity[3] + " " + eatenFoodType[3]);
                    Console.WriteLine(caterpillar + "Size: " + caterpillarSize);
                    day = "Friday";

                    Trace.WriteLine("Day changed to Friday");
                }
                else if (day == "Friday")
                {
                    Trace.WriteLine("Day is Friday");

                    caterpillar = "@@@@@";
                    caterpillarSize = 5;
                    eatenFoodType = new[] { "Apple", "Pear", "Plum", "Straberry", "Orange" };
                    eatenFoodQuantity = new[] { 1, 2, 3, 4, 5 };
                    Console.WriteLine("On " + day + " the very hungry caterpillar ate " + eatenFoodQuantity[4] + " " + eatenFoodType[4]);
                    Console.WriteLine(caterpillar + "Size: " + caterpillarSize);
                    day = "Saturday";

                    Trace.WriteLine("Day changed to Saturday");
                }
                else if (day == "Saturday")
                {
                    Trace.WriteLine("Day is Saturday");

                    caterpillar = "@@@@@@@@@@";
                    caterpillarSize = 6;
                    eatenFoodType = new[] { "Apple", "Pear", "Plum", "Straberry", "Orange", "ChocolateCake", "IceCreamCone", "Pickle", "SliceSwissCheese", "SliceSalami" };
                    eatenFoodQuantity = new[] { 1, 2, 3, 4, 5, 1, 1, 1, 1, 1 };
                    Console.WriteLine(
                        "On " + day + " the very hungry caterpillar ate " + eatenFoodQuantity[5] + " " + eatenFoodType[5] + ", " + eatenFoodQuantity[6] + " " + eatenFoodType[6] + ", "
                        + eatenFoodQuantity[7] + " " + eatenFoodType[7] + ", " + eatenFoodQuantity[8] + " " + eatenFoodType[8] + ", " + eatenFoodQuantity[9] + " " + eatenFoodType[9]);
                    Console.WriteLine(caterpillar + "Size: " + caterpillarSize);
                    day = "Sunday";

                    Trace.WriteLine("Day changed to Sunday");
                }
                else if (day == "Sunday")
                {
                    Trace.WriteLine("Day is Sunday");

                    caterpillar = "@@@@@@@@@@";
                    caterpillarSize = 7;
                    eatenFoodType = new[] { "Apple", "Pear", "Plum", "Straberry", "Orange", "ChocolateCake", "IceCreamCone", "Pickle", "SliceSwissCheese", "SliceSalami", "NiceGreenLeaf" };
                    eatenFoodQuantity = new[] { 1, 2, 3, 4, 5, 1, 1, 1, 1, 1, 1 };
                    Console.WriteLine("On " + day + " the very hungry caterpillar ate " + eatenFoodQuantity[10] + " " + eatenFoodType[10]);
                    Console.WriteLine(caterpillar + "Size: " + caterpillarSize);
                    day = "TwoWeeksLater";

                    Trace.WriteLine("Day changed to TwoWeeksLater");
                }
                else if (day == "TwoWeeksLater")
                {
                    Trace.WriteLine("Day is TwoWeeksLater");

                    caterpillar = "[@@@@@@@@@@]";
                    caterpillarSize = 7;
                    eatenFoodType = new[] { "Apple", "Pear", "Plum", "Straberry", "Orange", "ChocolateCake", "IceCreamCone", "Pickle", "SliceSwissCheese", "SliceSalami", "NiceGreenLeaf" };
                    eatenFoodQuantity = new[] { 1, 2, 3, 4, 5, 1, 1, 1, 1, 1, 1 };
                    Console.WriteLine(day + " the very hungry caterpillar built a cocoon");
                    Console.WriteLine(caterpillar + "Size: " + caterpillarSize);
                    day = "MoreThanTwoWeeksLater";

                    Trace.WriteLine("Day changed to MoreThanTwoWeeksLater");
                }
                else if (day == "MoreThanTwoWeeksLater")
                {
                    Trace.WriteLine("Day is MoreThanTwoWeeksLater");

                    caterpillar = @"\\|//";
                    caterpillarSize = null;
                    eatenFoodType = new[] { "Apple", "Pear", "Plum", "Straberry", "Orange", "ChocolateCake", "IceCreamCone", "Pickle", "SliceSwissCheese", "SliceSalami", "NiceGreenLeaf" };
                    eatenFoodQuantity = new[] { 1, 2, 3, 4, 5, 1, 1, 1, 1, 1, 1 };
                    Console.WriteLine(day + " the very hungry caterpillar was a butterfly!");
                    Console.WriteLine(caterpillar);
                    break;

                    Trace.WriteLine("Tale end.");
                }

                Thread.Sleep(1000);
            }
        }
    }
}
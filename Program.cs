using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Parking testParking = new Parking(26);

        Console.WriteLine("Total slots is:" + Convert.ToString(testParking.totalSlot));
        testParking.DisplayParking();
        for (int i = 0; i < 10; i++)
            testParking.ParkCar();
        testParking.DisplayParking();
        testParking.CarLeaves();
        testParking.DisplayParking();
    }
}
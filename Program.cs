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
            testParking.ParkCar(0);
        testParking.DisplayParking();
        testParking.ExitCar(0);
        testParking.DisplayParking();
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Parking testParking = new Parking(25);

        Console.WriteLine("Total slots is:" + Convert.ToString(testParking.totalSlot));
        testParking.DisplayParking();
    }
}
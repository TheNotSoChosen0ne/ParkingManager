
internal class Level
{
    private int _id;
    internal int level { get; private set; }
    internal int totalSlot { get; private set; }
    internal int availableSlot { get; private set; }

    internal Level(int level, int nbrSlot = 100)
    {
        this._id = 0;
        this.level = level;
        this.totalSlot = nbrSlot;
        this.availableSlot = nbrSlot;
    }

    internal bool ExitVehicule()
    {
        if (availableSlot >= totalSlot) {
            Console.WriteLine("No Vehicule left in level " +
            Convert.ToString(level) + "!");
            return false;
        }
        availableSlot++;
        return true;
    }

    internal bool ParkVehicule()
    {
        if (availableSlot <= 0) {
            Console.WriteLine("No Parking slot available in level " +
            Convert.ToString(level) + "!");
            return false;
        }
        availableSlot--;
        return true;
    }

    protected int DisplaySpot(int spot)
    {
        if (spot < totalSlot - availableSlot) {
            spot++;
            Console.Write("▮|");
        } else if (spot < totalSlot) {
            spot++;
            Console.Write(" |");
        }
        return spot;
    }

    protected void DisplayCurb(int RowSize, int RowIdx)
    {
        for (int idx = 0; idx < RowSize && RowIdx * RowSize + idx < totalSlot; idx++) {
            if (idx == 0)
                Console.Write("—");
            Console.Write("——");
        }
    }

    internal void DisplayLevel()
    {
        float sqrt = (float)System.Math.Sqrt(totalSlot);
        int rowSize = (int)sqrt;
        int spot = 0;

        if (rowSize < sqrt)
            rowSize++;
        for (int i = 0; i < rowSize; i++) {
            if (i * rowSize < totalSlot)
                Console.Write("|");
            for (int j = 0; j < rowSize; j++)
                spot = DisplaySpot(spot);
            if (i * rowSize < totalSlot)
                Console.WriteLine();
            DisplayCurb(rowSize, i);
            if (i * rowSize < totalSlot)
                Console.WriteLine();
        }
    }

    internal int GetId()
    {
        return _id;
    }
}
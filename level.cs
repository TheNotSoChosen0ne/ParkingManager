
class Levels
{
    private int _id;
    public int level { get; private set; }
    public int totalSlot { get; private set; }
    public int availableSlot { get; private set; }

    public Levels(int level, int nbrSlot = 100)
    {
        this._id = 0;
        this.level = level;
        this.totalSlot = nbrSlot;
        this.availableSlot = nbrSlot;
    }

    public bool ParkVehicule()
    {
        if (availableSlot >= totalSlot) {
            Console.WriteLine("No Parking slot available!");
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

    public void DisplayLevel()
    {
        float Sqrt = (float)System.Math.Sqrt(totalSlot);
        int RowSize = (int)Sqrt;
        int Spot = 0;

        if (RowSize < Sqrt)
            RowSize++;
        for (int i = 0; i < RowSize; i++) {
            if (i * RowSize < totalSlot)
                Console.Write("|");
            for (int j = 0; j < RowSize; j++)
                Spot = DisplaySpot(j, Spot);
            if (i * RowSize < totalSlot)
                Console.WriteLine();
            DisplayCurb(RowSize, i);
            if (i * RowSize < totalSlot)
                Console.WriteLine();
        }
    }
}
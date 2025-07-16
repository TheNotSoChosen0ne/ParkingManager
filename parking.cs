

public class Parking
{
    private int _id;
    public int totalSlot { get; protected set; }
    public int availableSlot { get; protected set; }
    public int totalLevels { get; protected set; }
    public List<Level> levels { get; protected set; }

    public Parking(int nbrSlot = 100)
    {
        if (nbrSlot <= 0) {
            Console.WriteLine("Cannot have negative or null parking spots!" +
            "Set to 100 spots by default");
            nbrSlot = 100;
        }
        this.totalSlot = nbrSlot;
        this.availableSlot = nbrSlot;
        this._id = 0;
        this.totalLevels = 0;
        this.levels = new List<Level>();
        this.levels.Add(new Level(0));
    }

    public void AddLevel(int nbrSlot = 100)
    {
        Level newLevel = new Level(totalLevels, nbrSlot);

        this.levels.Add(newLevel);
        this.totalLevels++;
    }

    protected int DisplaySpot(int spot)
    {
        if (spot < this.totalSlot - this.availableSlot) {
            spot++;
            Console.Write("▮|");
        } else if (spot < this.totalSlot) {
            spot++;
            Console.Write(" |");
        }
        return spot;
    }

    protected void DisplayCurb(int RowSize, int RowIdx)
    {
        for (int idx = 0; idx < RowSize && RowIdx * RowSize + idx < this.totalSlot; idx++) {
            if (idx == 0)
                Console.Write("—");
            Console.Write("——");
        }
    }

    public void DisplayParking()
    {
        float sqrt = (float)System.Math.Sqrt(this.totalSlot);
        int rowSize = (int)sqrt;
        int spot = 0;

        if (rowSize < sqrt)
            rowSize++;
        for (int i = 0; i < rowSize; i++) {
            if (i * rowSize < this.totalSlot)
                Console.Write("|");
            for (int j = 0; j < rowSize; j++)
                spot = DisplaySpot(spot);
            if (i * rowSize < this.totalSlot)
                Console.WriteLine();
            DisplayCurb(rowSize, i);
            if (i * rowSize < this.totalSlot)
                Console.WriteLine();
        }
    }

    public void ParkCar()
    {
        if (this.availableSlot > 0)
            this.availableSlot--;
        else
            Console.WriteLine("No parking-spots left!");
    }

    public void CarLeaves()
    {
        if (this.availableSlot == this.totalSlot)
            Console.WriteLine("No car left in the parking!");
        else
            this.availableSlot++;
    }

    public int GetId()
    {
        return this._id;
    }
}

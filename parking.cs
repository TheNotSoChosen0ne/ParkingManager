

public class Parking
{
    private int _id;
    internal int totalSlot { get; private set; }
    internal int availableSlot { get; private set; }
    internal int totalLevels { get; private set; }
    internal List<Level> levels { get; private set; }

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
        this.AddLevel(nbrSlot);
    }

    public void AddLevel(int nbrSlot = 100)
    {
        Level newLevel = new Level(totalLevels, nbrSlot);

        this.levels.Add(newLevel);
        this.totalLevels++;
    }

    public void DisplayParking()
    {
        foreach (Level lvl in levels)
            lvl.DisplayLevel();
    }

    public void ParkCar(int level)
    {
        if (level < 0 || level >= totalLevels) {
            Console.WriteLine("Level does not exist!");
            return ;
        }
        if (levels[level].ParkVehicule())
            this.availableSlot--;
    }

    public void ExitCar(int level)
    {
        if (level < 0 || level >= totalLevels) {
            Console.WriteLine("Level does not exist!");
            return;
        }
        if (levels[level].ExitVehicule())
            this.availableSlot++;
    }

    internal int GetId()
    {
        return _id;
    }
}

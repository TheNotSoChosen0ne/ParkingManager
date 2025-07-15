
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
}
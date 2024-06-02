package lab07.Vehicles;

public class Bike extends Vehicle 
{
    public Bike() 
    {
        super();
        unitType="bike";
    }

   

	public String getIdentifier() 
    {
		return this.identifier + " by bike";
	}
}

package lab07.Vehicles;

public class scooter extends Vehicle
{
    public scooter() 
    {
        super();
        unitType="scooter";
    }

	public String getIdentifier() 
    {
		return this.identifier + " by scooter";
	}
    
}

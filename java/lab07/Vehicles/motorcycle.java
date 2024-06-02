package lab07.Vehicles;

public class motorcycle extends Car
{
    public motorcycle() 
    {
        super();
        unitType="motorcycle";
    }
    
    public String getIdentifier() 
    {
		return this.identifier + " by motorcycle [" + this.plates + "]";
	}

     public String getPlates()
    {
      return plates;
    }

    public String getUnitType()
    {
      return unitType;
    }
}

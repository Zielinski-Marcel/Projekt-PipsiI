package lab07.Vehicles;

public class ambulance extends Car
{
    public ambulance() 
    {
        super();
        unitType="ambulance";
    }

    public String getIdentifier() 
    {
		return "ambulance [" + this.plates + "]";
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

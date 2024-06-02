package lab07.Vehicles;

public class tank extends Car
{
    public tank() 
    {
        super();
        unitType="tank";
    }

    public String getIdentifier() 
    {
		return "tank [" + this.plates + "]";
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

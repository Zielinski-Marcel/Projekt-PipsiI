package lab07.Vehicles;
import java.util.Random;

final public class truck extends Car
{
    protected String Company;
    public truck() 
    {
        super();
        getCompany();
        unitType="truck";
    }

    public String getIdentifier() 
    {
		return Company +" truck [" + this.plates + "]";
	}

    private String getCompany()
    {
       Random rand = new Random();
       int random=rand.nextInt(3);
        
        switch (random) 
        {
            case 0:
             Company="DHL";
             break;
            case 1:
             Company="Inpost";
             break;
            case 2:
             Company="DPD";
             break;
            case 3:
             Company="Poczta Polska";
        }
        return Company;
        
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

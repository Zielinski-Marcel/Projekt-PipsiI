package lab07.Vehicles;

import java.util.Random;

public abstract class Vehicle 
{
    abstract protected String getIdentifier();
    protected String unitType = "unknown ";
    protected boolean isAnonymous = false;
    protected String identifier="anonymous";
    protected String plates;

    public Vehicle() 
    {
        this.isAnonymous = true;
        this.identifier = getName();
        if(identifier=="anonymous")
        isAnonymous=true;
    }

    final public String identify()
    {
        return this.getIdentifier();
    }
    
    public String getPlates()
    {
      return this.plates;
    }

    public String getUnitType()
    {
      return this.unitType;
    }
    
    protected String getName()
    {
      Random rand = new Random();
      int random=rand.nextInt(5);
        
        switch (random) 
        {
            case 0:
             identifier="John Doe";
             break;
            case 1:
             identifier="Jane Doe";
             break;
            case 2:
             identifier="Mark Ham";
             break;
            case 3:
            identifier="Kate Ted";
            break;
            case 4:
            identifier="anonymous";
        }
        return identifier;
    }
}

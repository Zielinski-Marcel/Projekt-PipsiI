package lab07.Vehicles;

import java.util.Random;

public class regularCar extends Car 
{
    String color;
    String brand;

    public regularCar() 
    {
        super();
        getBrand();
        getColor();
        unitType="car";
    }

    public String getBrand() 
    {
      Random rand = new Random();
      int random=rand.nextInt(3);
        
        switch (random) 
        {
            case 0:
             brand="Audi";
             break;
            case 1:
             brand="Fiat";
             break;
            case 2:
             brand="BMW";
             break;
            case 3:
             brand="Mercedes";
        }
        return brand;
	  } 

    public String getColor() 
    {
      Random rand = new Random();
      int random=rand.nextInt(3);
        
        switch (random) 
        {
            case 0:
             color="black";
             break;
            case 1:
             color="white";
             break;
            case 2:
             color="red";
             break;
            case 3:
             color="grey";
        }
        return color;
	  } 
    
    public String getIdentifier() 
    {
		return this.identifier + " by " + color + " " + brand + " " + "[" + this.plates + "]";
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
 
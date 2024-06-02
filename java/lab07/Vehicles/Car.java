package lab07.Vehicles;

import java.util.Random;

public abstract class Car extends Vehicle 
{
    public Car() 
    {
        super();
        this.plates = getPlate();
        
    }
   

    private String getPlate()
    {
    Random rand = new Random();
      int random=rand.nextInt(100000);
      return "DL"+ String.valueOf(random);  
    }
}

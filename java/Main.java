import java.util.Random;
import lab07.Vehicles.Bike;
import lab07.Vehicles.Car;
import lab07.Vehicles.Vehicle;
import lab07.Vehicles.ambulance;
import lab07.Vehicles.dog;
import lab07.Vehicles.tank;
import lab07.Vehicles.truck;
import lab07.Vehicles.motorcycle;
import lab07.Vehicles.pedestriant;
import lab07.Vehicles.regularCar;
import lab07.Vehicles.scooter;
import lab07.Vehicles.pedestriant;
import lab07.Vehicles.dog;



public class Main {
  public static void main(String[] args) 
  {
    parking parkman=new parking();
    int vehicleAmount=100;
	Vehicle[] vehicles=new Vehicle[vehicleAmount];
  for(int i=0; i < vehicleAmount; i++)
  {
    Random rand = new Random();
      int random=rand.nextInt(9);
        
        switch (random) 
        {
          case 0:
      vehicles[i]=new dog();
      break;
      case 1:
      vehicles[i]=new pedestriant();
      break;
      case 2:
      vehicles[i]=new scooter();
      break;
      case 3:
      vehicles[i]=new regularCar();
      break;
      case 4:
      vehicles[i]=new motorcycle();
      break;
      case 5:
      vehicles[i]=new truck();
      break;
      case 6:
      vehicles[i]=new tank();
      break;
      case 7:
      vehicles[i]=new ambulance();
      break;
      case 8:
      vehicles[i]=new Bike();
      }
        
	}
  

	for(Vehicle vehicle : vehicles) 
  {
		System.out.println(vehicle.identify() + parkman.vehicleEntranceAttempt(vehicle.getUnitType(),vehicle.getPlates()));
	
  }

  System.out.println(parkman.endDayRaport());
  }
  
}

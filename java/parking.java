import java.time.format.DateTimeFormatter;
import java.time.LocalDateTime;
public class parking 
{
    
    private final static int carSpot=20;
    private final static int bikeSpot=10;
    private final static int motorcycleSpot=10;
    private int carSpotOccupied;
    private int bikeSpotOccupied;
    private int motorcycleSpotOccupied;


    private int colectedMoney;
    private int entranceCount;
    private int returnedCarCount;
    private int returnedBikeCount;
    private int returnedMotorcycleCount;
    private int blackListattemped;
    String[] list=
        {
            "DL00001"
        };

    public String vehicleEntranceAttempt(String unitType, String plates)
    {
     if(blackList(plates)==true && unitType!="ambulance")
        {
            blackListattemped++;
            return " is returned at " + getTime();
        }
        else
        switch (unitType) 
        {
            case "worker car":
            if (carSpotOccupied<carSpot)
            {
                colectedMoney+=5;
                carSpotOccupied++; 
                return " is entering at " + getTime();
            }
            else 
                return " is return at " + getTime();
            case "dog":
                return " is returned at " + getTime();
            case "tank":
                return " is returned at " + getTime();
            case "ambulance":
                return " is entering at " + getTime();
            case "truck":
                return " is entering at " + getTime(); 
            case "pedestriant":
                return " is entering at " + getTime();
            case "scooter":
                return " is entering at " + getTime();
            case "motorcycle":
            if (motorcycleSpotOccupied<motorcycleSpot)
            { 
                motorcycleSpotOccupied++;
                colectedMoney+=2;
                return " is entering at " + getTime();
            }
            else 
                return " is return at " + getTime();
            case "car":
            if (carSpotOccupied<carSpot)
            {
                colectedMoney+=5;
                carSpotOccupied++; 
                return " is entering at " + getTime();
            }
            else 
                return " is return at " + getTime();
               
            
                default:
                 return " is returned at " + getTime();
             case "bike":
            if (bikeSpotOccupied<bikeSpot)
            { 
                bikeSpotOccupied++;
                return " is entering at " + getTime();
            }
            else 
                return " is return at " + getTime();
        }
    }
    
public String vehicleExitAttempt(String unitType)
    {
        switch (unitType) 
        {
            case "ambulance":
                return " is leaving at " + getTime();
            case "truck":
                return " is leaving at " + getTime(); 
            case "pedestriant":
                return " is leaving at " + getTime();
            case "scooter":
                return " is leaving at " + getTime();
            case "motorcycle":
            {
                motorcycleSpotOccupied--;
                return " is leaving at " + getTime();
            }
            case "car":
            {
                carSpotOccupied--; 
                return " is leaving at " + getTime();
            } 
            case "bike":
            
            { 
                bikeSpotOccupied--;
                return " is leaving at " + getTime();
            }

            default:
                 return " is leaving at " + getTime();
        }
    }




   private boolean blackList (String plates) 
   {
        for(String lists : list) 
        {
           if(plates==lists)
           return true; 
	    }
        return false;
   }

    private String getTime()
    {
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("yyyy/MM/dd HH:mm:ss");  
        LocalDateTime now = LocalDateTime.now();  
    return dtf.format(now);  
    }
    
    
    
    
    public String endDayRaport()
    {
       return 
       "money collected: " + colectedMoney + " zł\n" +
       "entrances count:  " + entranceCount + "\n" +
       "car spaces occupied: " + carSpotOccupied + "/" + carSpot + "\n"+
       "motocycle spaces occupied: "  + motorcycleSpotOccupied + "/" + motorcycleSpot + "\n"+
       "bicycle spaces occupied:  "  + bikeSpotOccupied + "/" + bikeSpot + "\n"+
       "cars returned: "  + returnedCarCount + "\n"+
       "motocycles returned: "  + returnedMotorcycleCount + "\n"+
       "bicycles returned: "  + returnedBikeCount + "\n"+
       "blacklisted vehicle entrance attempted: " + blackListattemped + "\n";
    } 
    
}

    public abstract class HomeAppliance
    {
        protected public string Proizvoditel;
       
    }
    public abstract class HomeApp_Energy: HomeAppliance  
    {
        protected public string EnergyConsumption;
       
    }
    public class Iron: HomeApp_Energy
    {
        protected public string Set_of_functions;
        protected public string Color;
    }

    public class Washing_machine: HomeApp_Energy
    {
        protected public string Download_metod;
        protected public string Color;
    }

    public class SVCH_microwave: HomeApp_Energy
    {
        protected public string Power ;
        protected public string Number_of_modes;
    }

 public class Dishwasher: HomeApp_Energy
    { 
        protected public string Number_of_modes;
    }

    public class Kitchen_stove: HomeAppliance
    { 
        protected public string Number_of_burner;
        protected public string Number_of_modes;
        protected public string Recessed;
    }
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DesignPattern.Creational_Pattern
{
    public interface Builder
    {
         void setType(Type type);
         void setSeats(int seats);
         void setEngine(Engine engine);
         void setTransmission(Transmission transmission);
         void setTripComputer(TripComputer tripComputer);
         void setGPSNavigator(GPSNavigator gpsNavigator);
    }

    public class CarBuilder : Builder
    {
        private Type type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;


        public void setType(Type type)
        {
            this.type = type;
        }


        public void setSeats(int seats)
        {
            this.seats = seats;
        }


        public void setEngine(Engine engine)
        {
            this.engine = engine;
        }


        public void setTransmission(Transmission transmission)
        {
            this.transmission = transmission;
        }


        public void setTripComputer(TripComputer tripComputer)
        {
            this.tripComputer = tripComputer;
        }


        public void setGPSNavigator(GPSNavigator gpsNavigator)
        {
            this.gpsNavigator = gpsNavigator;
        }

        public Car getResult()
        {
            return new Car(type, seats, engine, transmission, tripComputer, gpsNavigator);
        }
    }

    public class CarManualBuilder : Builder
    {
        private Type type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;


        public void setType(Type type)
        {
            this.type = type;
        }

        public void setSeats(int seats)
        {
            this.seats = seats;
        }


        public void setEngine(Engine engine)
        {
            this.engine = engine;
        }


        public void setTransmission(Transmission transmission)
        {
            this.transmission = transmission;
        }


        public void setTripComputer(TripComputer tripComputer)
        {
            this.tripComputer = tripComputer;
        }


        public void setGPSNavigator(GPSNavigator gpsNavigator)
        {
            this.gpsNavigator = gpsNavigator;
        }

        public Manual getResult()
        {
            return new Manual(type, seats, engine, transmission, tripComputer, gpsNavigator);
        }
    }

    public class Car
    {
        private Type type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;
        private double fuel = 0;

        public Car(Type type, int seats, Engine engine, Transmission transmission,
                   TripComputer tripComputer, GPSNavigator gpsNavigator)
        {
            this.type = type;
            this.seats = seats;
            this.engine = engine;
            this.transmission = transmission;
            this.tripComputer = tripComputer;
            this.tripComputer.setCar(this);
            this.gpsNavigator = gpsNavigator;
        }

        public Type getType()
        {
            return type;
        }

        public double getFuel()
        {
            return fuel;
        }

        public void setFuel(double fuel)
        {
            this.fuel = fuel;
        }

        public int getSeats()
        {
            return seats;
        }

        public Engine getEngine()
        {
            return engine;
        }

        public Transmission getTransmission()
        {
            return transmission;
        }

        public TripComputer getTripComputer()
        {
            return tripComputer;
        }

        public GPSNavigator getGpsNavigator()
        {
            return gpsNavigator;
        }
    }

    public class Manual
    {
        private Type type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;

        public Manual(Type type, int seats, Engine engine, Transmission transmission,
                      TripComputer tripComputer, GPSNavigator gpsNavigator)
        {
            this.type = type;
            this.seats = seats;
            this.engine = engine;
            this.transmission = transmission;
            this.tripComputer = tripComputer;
            this.gpsNavigator = gpsNavigator;
        }

        public String print()
        {
            String info = "";
            info += "Type of car: " + type + "\n";
            info += "Count of seats: " + seats + "\n";
            info += "Engine: volume - " + engine.getVolume() + "; mileage - " + engine.getMileage() + "\n";
            info += "Transmission: " + transmission + "\n";
            if (this.tripComputer != null)
            {
                info += "Trip Computer: Functional" + "\n";
            }
            else
            {
                info += "Trip Computer: N/A" + "\n";
            }
            if (this.gpsNavigator != null)
            {
                info += "GPS Navigator: Functional" + "\n";
            }
            else
            {
                info += "GPS Navigator: N/A" + "\n";
            }
            return info;
        }
    }
    public enum Type
    {
        CITY_CAR, SPORTS_CAR, SUV
    }

    public class Engine
    {
        private double volume;
        private double mileage;
        private Boolean started;

        public Engine(double volume, double mileage)
        {
            this.volume = volume;
            this.mileage = mileage;
        }

        public void on()
        {
            started = true;
        }

        public void of()
        {
            started = false;
        }

        public Boolean isStarted()
        {
            return started;
        }

        public void go(double mileage)
        {
            if (started)
            {
                this.mileage += mileage;
            }
            else
            {
                Console.WriteLine("Cannot go(), you must start engine first!");
            }
        }

        public double getVolume()
        {
            return volume;
        }

        public double getMileage()
        {
            return mileage;
        }
    }

    public class GPSNavigator
    {
        private String route;

        public GPSNavigator()
        {
            this.route = "221b, Baker Street, London  to Scotland Yard, 8-10 Broadway, London";
        }

        public GPSNavigator(String manualRoute)
        {
            this.route = manualRoute;
        }

        public String getRoute()
        {
            return route;
        }
    }

    public enum Transmission
    {
        SINGLE_SPEED, MANUAL, AUTOMATIC, SEMI_AUTOMATIC
    }

    public class TripComputer
    {

        private Car car;

        public void setCar(Car car)
        {
            this.car = car;
        }

        public void showFuelLevel()
        {
            Console.WriteLine("Fuel level: " + car.getFuel());
        }

        public void showStatus()
        {
            if (this.car.getEngine().isStarted())
            {
                Console.WriteLine("Car is started");
            }
            else
            {
                Console.WriteLine("Car isn't started");
            }
        }
    }

    public class Director
    {

        public void constructSportsCar(Builder builder)
        {
            builder.setType(Type.SPORTS_CAR);
            builder.setSeats(2);
            builder.setEngine(new Engine(3.0, 0));
            builder.setTransmission(Transmission.SEMI_AUTOMATIC);
            builder.setTripComputer(new TripComputer());
            builder.setGPSNavigator(new GPSNavigator());
        }

        public void constructCityCar(Builder builder)
        {
            builder.setType(Type.CITY_CAR);
            builder.setSeats(2);
            builder.setEngine(new Engine(1.2, 0));
            builder.setTransmission(Transmission.AUTOMATIC);
            builder.setTripComputer(new TripComputer());
            builder.setGPSNavigator(new GPSNavigator());
        }

        public void constructSUV(Builder builder)
        {
            builder.setType(Type.SUV);
            builder.setSeats(4);
            builder.setEngine(new Engine(2.5, 0));
            builder.setTransmission(Transmission.MANUAL);
            builder.setGPSNavigator(new GPSNavigator());
        }
    }
}

#region implementation

//Director director = new Director();

//// Director gets the concrete builder object from the client
//// (application code). That's because application knows better which
//// builder to use to get a specific product.
//CarBuilder builder = new CarBuilder();
//director.constructSportsCar(builder);

//			// The final product is often retrieved from a builder object, since
//			// Director is not aware and not dependent on concrete builders and
//			// products.
//			Car car = builder.getResult();
//Console.WriteLine("Car built:\n" + car.getType());


//			CarManualBuilder manualBuilder = new CarManualBuilder();

//// Director may know several building recipes.
//director.constructSportsCar(manualBuilder);
//			Manual carManual = manualBuilder.getResult();
//Console.WriteLine("\nCar manual built:\n" + carManual.print());

#endregion
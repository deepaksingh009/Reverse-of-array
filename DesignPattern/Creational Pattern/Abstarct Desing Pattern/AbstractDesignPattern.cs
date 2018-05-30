using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.DesignPattern.Creational_Pattern
{
    #region interface
    public interface shape
    {
        void dimensions();
    }
    public interface color
    {
        void fill();
    }
    #endregion
    #region concreteClasses
    public class circle : shape
    {
        public void dimensions()
        {
            Console.WriteLine("circle");
        }
    }
    public class Rectangle : shape
    {
        public void dimensions()
        {
            Console.WriteLine("Rectangle");
        }
    }
    public class red : color
    {
        public void fill()
        {
            Console.WriteLine("Red");
        }
    }
    public class Green : color
    {
        public void fill()
        {
            Console.WriteLine("Green");
        }
    }
    #endregion
    #region Abstractfactory
    public abstract class AbstractFactory
    {
        public abstract shape GetShape(string shape);
        public abstract color Getcolor(string color);
    }
    #endregion
    #region Concrete factories
    public class Colorfactor : AbstractFactory
    {
        public override color Getcolor(string color)
        {
            color colors = null;
            if (color == "RED")
            {
                colors = new red();
            }
            else if (color == "Green")
            {
                colors = new Green();
            }
            return colors;
        }

        public override shape GetShape(string shape)
        {
            throw new NotImplementedException();
        }
    }
    public class Shapefactor : AbstractFactory
    {
        public override color Getcolor(string color)
        {
            throw new NotImplementedException();
        }
        public override shape GetShape(string shape)
        {
            shape colors = null;
            if (shape == "RECTANGLE")
            {
                colors = new Rectangle();
            }
            else if (shape == "CIRCLE")
            {
                colors = new circle();
            }
            return colors;
        }
    }
    #endregion
    #region Factoryproducer
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(String choice)
        {

            if (choice == "SHAPE")
            {
                return new Shapefactor();

            }
            else if (choice == "COLOR")
            {
                return new Colorfactor();
            }

            return null;
        }
    }
    #endregion


}

#region Implementation
////get shape factory
//AbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");

////get an object of Shape Circle
//shape shape1 = shapeFactory.GetShape("CIRCLE");

////call draw method of Shape Circle
//shape1.dimensions();

//            //get an object of Shape Rectangle
//            shape shape2 = shapeFactory.GetShape("RECTANGLE");

////call draw method of Shape Rectangle
//shape2.dimensions();

         

//            //get color factory
//            AbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");

////get an object of Color Red
//color color1 = colorFactory.Getcolor("RED");

////call fill method of Red
//color1.fill();

//            //get an object of Color Green
//            color color2 = colorFactory.Getcolor("Green");

////call fill method of Green
//color2.fill();
#endregion


#region Rough
///// <summary>

///// The 'AbstractFactory' abstract class

///// </summary>

//abstract class ContinentFactory

//{
//    public abstract Herbivore CreateHerbivore();
//    public abstract Carnivore CreateCarnivore();
//}

///// <summary>

///// The 'ConcreteFactory1' class

///// </summary>

//class AfricaFactory : ContinentFactory

//{
//    public override Herbivore CreateHerbivore()
//    {
//        return new Wildebeest();
//    }
//    public override Carnivore CreateCarnivore()
//    {
//        return new Lion();
//    }
//}

///// <summary>

///// The 'ConcreteFactory2' class

///// </summary>

//class AmericaFactory : ContinentFactory

//{
//    public override Herbivore CreateHerbivore()
//    {
//        return new Bison();
//    }
//    public override Carnivore CreateCarnivore()
//    {
//        return new Wolf();
//    }
//}

///// <summary>

///// The 'AbstractProductA' abstract class

///// </summary>

//abstract class Herbivore

//{
//}

///// <summary>

///// The 'AbstractProductB' abstract class

///// </summary>

//abstract class Carnivore

//{
//    public abstract void Eat(Herbivore h);
//}

///// <summary>

///// The 'ProductA1' class

///// </summary>

//class Wildebeest : Herbivore

//{
//}

///// <summary>

///// The 'ProductB1' class

///// </summary>

//class Lion : Carnivore

//{
//    public override void Eat(Herbivore h)
//    {
//        // Eat Wildebeest

//        Console.WriteLine(this.GetType().Name +
//          " eats " + h.GetType().Name);
//    }
//}

///// <summary>

///// The 'ProductA2' class

///// </summary>

//class Bison : Herbivore

//{
//}

///// <summary>

///// The 'ProductB2' class

///// </summary>

//class Wolf : Carnivore

//{
//    public override void Eat(Herbivore h)
//    {
//        // Eat Bison

//        Console.WriteLine(this.GetType().Name +
//          " eats " + h.GetType().Name);
//    }
//}

///// <summary>

///// The 'Client' class 

///// </summary>

//class AnimalWorld

//{
//    private Herbivore _herbivore;
//    private Carnivore _carnivore;

//    // Constructor

//    public AnimalWorld(ContinentFactory factory)
//    {
//        _carnivore = factory.CreateCarnivore();
//        _herbivore = factory.CreateHerbivore();
//    }

//    public void RunFoodChain()
//    {
//        _carnivore.Eat(_herbivore);
//    }
//}
////}
#endregion

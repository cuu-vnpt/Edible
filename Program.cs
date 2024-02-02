internal class Program
{
    private static void Main(string[] args)
    {
        Animal[] animals = new Animal[2];
        animals[0] = new Tiger();
        animals[1] = new Chickens();
        foreach (Animal item in animals)
        {
            if(item is Chickens)
            {
                
            }
        }
        Fruit[] fruits = new Fruit[2];
        fruits[0] = new Apple();
        fruits[1] = new Orange();

        foreach (Fruit item in fruits)
        {
            if(item is Apple)
            {

            }
        }
        
    }
}
public abstract class Animal
{
    public abstract string MakeSound();
}
public interface Edible
{
    public string HowToEat();
}
public abstract class Fruit : Edible
{
    public abstract string HowToEat();
}
public class Chickens : Animal, Edible
{
    public string HowToEat()
    {
        return "Cound something";
    }

    public override string MakeSound()
    {
        return "Chickens: Cluck Kluck";
    }
}
public class Tiger : Animal
{
    public override string MakeSound()
    {
        return " Tiger: Grower";
    }
}
public class Apple : Fruit
{
    public override string HowToEat()
    {
        throw new NotImplementedException();
    }
}
public class Orange : Fruit
{
    public override string HowToEat()
    {
        throw new NotImplementedException();
    }
}
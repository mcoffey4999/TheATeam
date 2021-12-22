//Factory for string of products
public interface Istore {
    string getProducts();
}

public class NorthStore : Istore {
    public string getProducts() {
        return "Milk, Eggs, Meat";
    }
}
public class SouthStore : Istore {
    public string getProducts() {
        return "Fruit, Cheese, Meat";
    }
}
public class WestStore : Istore {
    public string getProducts() {
        return "Milk, Veg, Fruit";
    }
}
public abstract class storeProducts {
    public abstract Istore getStore(string input);
}

public class products : storeProducts{
    public override Istore getStore(string input)
    {
            switch (input) {
        case "North":
        return new NorthStore();
        //don't need breaks
        case "South":
        return new SouthStore();

        case "West":
        return new WestStore();
        default:
        throw new ApplicationException(string.Format("Not a valid store.", input));

    }
    }

}

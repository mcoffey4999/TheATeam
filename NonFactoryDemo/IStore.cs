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
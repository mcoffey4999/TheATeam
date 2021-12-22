Istore obj = null;
Console.WriteLine("From which store would you like to see products?");
Console.WriteLine("North");
Console.WriteLine("South");
Console.WriteLine("West");
string input = Console.ReadLine();

switch (input) {
                case "North":
                obj = new NorthStore();
                break;
                case "South":
                obj = new SouthStore();
                break;

                case "West":
                obj = new WestStore();
                break;
                case "x":
                break;
}
Console.WriteLine("The products at store "+input+" are " + obj.getProducts());

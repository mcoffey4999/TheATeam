storeProducts obj = new products();
Console.WriteLine("From which store would you like to view products?");
Console.WriteLine("North");
Console.WriteLine("South");
Console.WriteLine("West");
string input =  Console.ReadLine();
Istore inst = obj.getStore(input);
Console.WriteLine("The products at store "+input+" are " + inst.getProducts());

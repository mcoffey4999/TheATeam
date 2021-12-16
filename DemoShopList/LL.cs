LinkedList<String> list = new LinkedList<String>();
    bool exit = false;
        //AddFirst
        //AddLast
        list.AddLast("Milk");
        list.AddLast("Eggs");
        list.AddLast("Cheese");
        list.AddFirst("Meat");
        list.AddLast("Veg");
        list.AddLast("Fruit");
  
        Console.WriteLine("Shopping List: \n");
  
        
        foreach(string item in list)
        {
            Console.WriteLine(item);
        }

        
        
        while(!exit) {
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("1. Add item");
        Console.WriteLine("2. Remove item");
        Console.WriteLine("x. Exit List");

        string input = Console.ReadLine();
            switch (input) {
                case "1":
                Console.WriteLine("Put what you'd like to add");
                string item = Console.ReadLine();

                list.AddLast(item);
                break;
                case "2":
                Console.WriteLine("Put what you'd like to remove");
                string item2 = Console.ReadLine();

                list.Remove(item2);
                break;

                case "x":
                exit = true;
                break;
            }
        }

        //AddAfter
        //AddBefore
        LinkedListNode<string> node = list.Find("Meat");
        list.AddAfter(node, "a)lunch meats");
         foreach(string item in list)
        {
            Console.WriteLine(item);
        }
        
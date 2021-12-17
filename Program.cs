

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
        Console.WriteLine("2. Find item");
        Console.WriteLine("3. Delete item");
        Console.WriteLine("x. Exit List");

        string input = Console.ReadLine();
            switch (input) {
                case "1":
                Console.WriteLine("Put what you'd like to add");
                string item = Console.ReadLine();

                list.AddLast(item);
                break;
                case "2":
                Console.WriteLine("Type the specific item.");
                string nitem = Console.ReadLine();
                if(list.Contains(nitem) == true){
                    Console.WriteLine(nitem + " was found in the list!");
                }
                else{
                    Console.WriteLine("Can't find " + nitem);
                }
                break;
                case "3":
                Console.WriteLine("State the item that will be removed");
                string foundItem = Console.ReadLine();
                list.Remove(foundItem);
                Console.WriteLine("The item has been deleted");
                foreach(string food in list){
                    Console.WriteLine(food);
                }
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
=======
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
        Console.WriteLine("x. Exit List");

        string input = Console.ReadLine();
            switch (input) {
                case "1":
                Console.WriteLine("Put what you'd like to add");
                string item = Console.ReadLine();

                list.AddLast(item);
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

        
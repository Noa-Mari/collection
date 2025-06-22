using System;

public class CollectionOperations : ICollectionOperations
{
    public void ListOperations(List<string> list)
    {
        // Deleting a middle element
        list.RemoveAt(list.Count / 2);

        // sharcing in the list for the word "mama"
        if (list.Contains("mama"))
        {
            list.Add("6");
        }
        Console.WriteLine($"\n\nsharcing in the list for the word mama :");
        loopPrint(list);
        
          //flip list if the index of "course59" is even
        int index = list.IndexOf("course59");
        if (index >= 0 && index % 2 == 0)
        {
            list.Reverse();
        }
        Console.WriteLine($"\nflip list if the index of course59 is even {list}");
        loopPrint(list);
    }

 

    public void DictionaryOperations(Dictionary<string, int> dictionary)
    {
      

    }
    public void StackOperations(Stack<DateTime> stack)
    {
       
    }
}
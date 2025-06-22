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
    }

 

    public void DictionaryOperations(Dictionary<string, int> dictionary)
    {
      

    }
    public void StackOperations(Stack<DateTime> stack)
    {
       
    }
}
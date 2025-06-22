using System;

public class CollectionOperations : ICollectionOperations
{
    public void ListOperations(List<string> list)
    {
        // Deleting a middle element
        list.RemoveAt(list.Count / 2);
    }

    private void loopPrint(List<string> list)
    {
       
    }

    public void DictionaryOperations(Dictionary<string, int> dictionary)
    {
      

    }
    public void StackOperations(Stack<DateTime> stack)
    {
       
    }
}
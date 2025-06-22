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
     

        //flip list if the index of "course59" is even
        int index = list.IndexOf("course59");
        if (index >= 0 && index % 2 == 0)
        {
            list.Reverse();
        }
       
         //number of elements in the list no repeated
        int count = 0;
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i; i < list.Count; i++)
            {
                if (i != j)
                {
                    count++;
                }
            }
        }
        if (count == 3)
        {
            list.Insert(3, "2");
            list.Insert(4, "3");
            list.Insert(5, "4");
        }
    }

 

    public void DictionaryOperations(Dictionary<string, int> dictionary)
    {
       if (dictionary["scuba"] == 6)
        {
            dictionary["dive"] = 6;
        }

    }
    public void StackOperations(Stack<DateTime> stack)
    {
        DateTime currentDate = DateTime.Now;
        DateTime stackDate = stack.Pop();
        if (stackDate < currentDate)
        {
            stack.Push(currentDate);
        }
        else
        {
            stack.Push(stackDate);
        }
    }
}
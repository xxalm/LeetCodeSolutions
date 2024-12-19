using System;
using System.Collections.Generic;

public class RandomizedSet
{
    private Dictionary<int, int> valueToIndex;
    private List<int> values;
    private Random rand;

    public RandomizedSet()
    {
        valueToIndex = new Dictionary<int, int>();
        values = new List<int>();
        rand = new Random();
    }

    public bool Insert(int val)
    {
        if (valueToIndex.ContainsKey(val))
        {
            return false; 
        }

        
        values.Add(val);
        valueToIndex[val] = values.Count - 1; 

        return true;
    }

    public bool Remove(int val)
    {
        if (!valueToIndex.ContainsKey(val))
        {
            return false; 
        }

        
        int indexToRemove = valueToIndex[val];
        int lastIndex = values.Count - 1;
        int lastValue = values[lastIndex];

        
        values[indexToRemove] = lastValue;
        valueToIndex[lastValue] = indexToRemove;

        
        values.RemoveAt(lastIndex);
        valueToIndex.Remove(val);

        return true;
    }

    public int GetRandom()
    {
        int randomIndex = rand.Next(values.Count);
        return values[randomIndex];
    }
}

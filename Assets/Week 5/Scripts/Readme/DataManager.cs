using UnityEngine;
using System;
using System.Collections.Generic;

public class DataManager<T> 
{
    private List<T> items = new();

    public void Add(T item) => items.Add(item);
    public void Remove(T item) => items.Remove(item);
    public void PrintAll()
    {
        foreach (T item in items)
            Debug.Log(item);
    }

    public bool Contains(T value)
    {
        foreach (T item in items)
        {
            if (item.Equals(value))
                return true;
        }
        return false;
    }

}

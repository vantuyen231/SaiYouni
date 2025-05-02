using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericUtility : MonoBehaviour
{
    public static T MaxElement<T>(T[] array) where T : System.IComparable<T>
    {
        T max = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxValues : MonoBehaviour
{
    void Start()
    {
        // Giá trị lớn nhất của int
        int maxInt = 0;
        maxInt = int.MaxValue;
        Debug.Log("Giá trị lớn nhất của int: " + maxInt);

        // Giá trị lớn nhất của float
        float maxFloat = 0;
        maxFloat = float.MaxValue;
        Debug.Log("Giá trị lớn nhất của float: " + maxFloat);

        // Giá trị lớn nhất của double
        double maxDouble = 0;
        maxDouble = double.MaxValue;
        Debug.Log("Giá trị lớn nhất của double: " + maxDouble);
    }

}

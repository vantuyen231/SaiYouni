using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManagerTester : MonoBehaviour 
{
    void Start()
    {
        Bai1();
        Bai2();
        Bai3();
    }

    void Bai1()
    {
        //Debug.Log("====Bai1=====");
        var holder = gameObject.AddComponent<IntHolder>();
        holder.SetData(999);
        //Debug.Log("Data: " + holder.GetData());
    }

    void Bai2()
    {
        //Debug.Log("====Bai2=====");
        DataManager<string> stringManager = new DataManager<string>();
        stringManager.Add("Enemy");
        stringManager.Add("Player");
        stringManager.PrintAll();

        bool found = stringManager.Contains("Enemy");
        //Debug.Log("Enemy ton tai: " + found);


        DataManager<int> intManager = new DataManager<int>();
        intManager.Add(10);
        intManager.Add(20);
        //Debug.Log("Danh sach so nguyen:");
        intManager.PrintAll();
        //Debug.Log("Chua 10? " + intManager.Contains(10));
    }

    void Bai3()
    {
        //Debug.Log("====Bai3=====");
        int[] numbers = { 1, 3, 7, 2 };
        int max = GenericUtility.MaxElement(numbers);
        //Debug.Log("So lon nhat: " + max);

        string a = "Hello", b = "World";
        GenericUtility.Swap(ref a, ref b);
        //Debug.Log($"a = {a}, b = {b}");
    }
}

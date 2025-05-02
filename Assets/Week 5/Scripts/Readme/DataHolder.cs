using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntHolder : MonoBehaviour
{
    [SerializeField] private int data;

    public void SetData(int value) => data = value;
    public int GetData() => data;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_1 : MonoBehaviour
{
    public int num1 = 5;
    public int num2 = 10;
    public int num3 = 15;
    private int result;

    private void Start()
    {
        Operation(num1, num2, num3);
        Debug.Log($" The arithmetic mean of {num1}, {num2} and {num3} is {result}");
    }
    private int Operation(int x, int y, int z)
    {
        result = (x + y + z) / 3;
        return result;
    }
}

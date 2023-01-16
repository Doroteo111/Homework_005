using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_4 : MonoBehaviour
{
    public int[] numbers;

    private void Start()
    {
        Debug.Log($"First element = {numbers[0]}");
        Debug.Log($"Third element = {numbers[2]}");
        Debug.Log($"Fifth element = {numbers[4]}");

    }
}

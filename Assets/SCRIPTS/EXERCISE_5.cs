using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_5 : MonoBehaviour
{
    public int[] numbers;
 
    private void Start()
    {

        if (numbers.Length >= 5) //accedo al numero de elementos del array
        {
            Debug.Log($"First element = {numbers[0]}");
            Debug.Log($"Third element = {numbers[2]}");
            Debug.Log($"Fifth element = {numbers[4]}");
        }
        else 
        {
            Debug.Log("Missing elements");
        }
    }

}

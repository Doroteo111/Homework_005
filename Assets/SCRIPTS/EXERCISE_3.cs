using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_3 : MonoBehaviour
{
    public int pointCounter;
    private int limitNumber;

   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))  //
        {
            AddOneToCounter();

        }
       
    }

    private void AddOneToCounter()  //Will count ever time we click 'A' and it shown in the console as well
    {
        pointCounter++;
        Debug.Log($"You have collected {pointCounter} points");
        
        GameisOver();
    }

    private void GameisOver()
    {
        if (pointCounter >= 10)
        {
            Debug.Log("GAME OVER");
        }
        
    }
}

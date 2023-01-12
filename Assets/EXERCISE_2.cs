using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_2 : MonoBehaviour
{
    public string nickname ;
    public string password ;

    private void Start()
    {
        if (Login())
        {
            Debug.Log("Your login have be successful");

        }
        else
        {
            Debug.Log("Your password or nickname are incorrect, try again.");
        }
        
    }
    private bool Login()
    {
        if( nickname == "admin" &&  password == "abccba")
        {
            return true;

        }
        else
        {
            return false;

        }

            


    }
}

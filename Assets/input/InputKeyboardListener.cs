using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboardListener : MonoBehaviour, IInputeable
{
    public void GetDirection(Vector3 direction)
    {
        /* throw new System.NotImplementedException(); */
        InputProvider.TriggerDirection(direction);
    }


    private void Update()
    {
        if(Input.GetButtonDown("Shoot"))
        {
            Shootpressed();
        }
        GetDirection(new Vector3(Input.GetAxis("Horizontal"), 
        Input.GetAxis("Vertical")));
       
    }
}

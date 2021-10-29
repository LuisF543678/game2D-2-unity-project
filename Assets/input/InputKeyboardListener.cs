using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboardListener : MonoBehaviour, IInputeable
{
    public void GetDirection(Vector3 direction)
    {
        throw new System.NotImplementedException();
    }


    public void GetHorizontalAxis(float value)
    {
        //throw new System.NotSupportedException();
        InputProvider.TriggerHorizontalAxis(value);
    }

    public void GetVerticalAxis(float value)
    {
        //throw new System.NotSupportedException();
        InputProvider.TriggerVerticalAxis(value);
    }

    public void Shootpressed()
    {
       InputProvider.Instance.TriggerOnHasShoot();
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

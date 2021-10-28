using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboardListener : MonoBehaviour, IInputeable
{
    public static InputKeyboardListener Instance;

    public delegate void HaveShoot( /* int a, float wyz */);
    public event HaveShoot OnHasShoot;

    private void Awake(){
        Instance = this;
    }

    public void Shootpressed()
    {
       OnHasShoot?.Invoke();
    }
    private void Update()
    {
        if(Input.GetButtonDown("Shoot"))
        {
            Shootpressed();
        }
    }
}

//using unityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class InputProvider : MonoBehaviour
{
    public delegate void HaveShoot();
    public static event HaveShoot OnHasShoot;
    public delegate void direccion(Vector3 direccion);
    public static event Direccion OnDireccion;

    public static void TriggerOnHasShoot() 
    {
        OnHasShoot?.Invoke();
    }

    public static void TriggerDirection(Vector3 direccion) {
        OnDireccion?.Invoke(direccion);
    }


}

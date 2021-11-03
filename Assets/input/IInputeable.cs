using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IInputeable
{
    void Shootpressed();

   /*  void GetHorizontalAxis( float value );
    void GetVerticalAxis( float value ); */

    void GetDirection(Vector3 direccion );
}

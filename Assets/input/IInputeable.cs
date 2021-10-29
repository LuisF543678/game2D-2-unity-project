using UnityEngine;

public interface IInputeable
{
    void Shootpressed();

   /*  void GetHorizontalAxis( float value );
    void GetVerticalAxis( float value ); */

    void GetDirection(Vector3 direction );
}

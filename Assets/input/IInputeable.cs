using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IInputeable
{
    void Shootpressed();

    void GetDirection(Vector3 direccion );
}

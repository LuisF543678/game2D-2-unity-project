using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour
{
    // Start is called before the first frame update
    public Mover mover;
    
    private void update()
    {
        Vector3 desplazamiento=new Vector3(UnityEngine.Random.RandomRange(-1f, 1f), UnityEngine.Random.RandomRange(-1f, 1f));

        mover.DoMove(desplazamiento);
    }
}

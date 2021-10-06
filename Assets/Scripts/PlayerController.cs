using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Mover moverComponent;
    public float speed = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKey(KeyCode.A)) {
            transform.Translate(-1f,0,0);
        }
        
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(1f,0,0);
        } */

        Vector3 desplazamiento=new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") *  speed * Time.deltaTime, transform.position.z);
        moverComponent.DoMove(desplazamiento);
        //transform.Translate();
    }
}

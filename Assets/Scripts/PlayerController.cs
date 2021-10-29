using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMinimum, xMaximum, yMinimum, yMaximun;
}

public class PlayerController : MonoBehaviour
{
    public Mover moverComponent;
    public float speed;
    public Boundary boundary;

/*     public InputKeyboardListener asdf;
 */

    public Transform shootOrigin;
    public GameObject shootPrefab;

    private void Start()
    {
        moverComponent.speed = speed;
        //Debug.Log(speed);
        InputProvider.Instance.OnHasShoot += OnHasShoot;
        InputProvider.OnHorizontalAxis += OnHorizontalAxis;
        InputProvider.OnVerticallAxis += onVerticallAxis;
    }

    private void OnhorizontalAxis(float value)
    {
        Vector3 direction = new Vector3(value, transform.position.y, transform.position.z); 
        moverComponent.direction = direction; 
    }

    private void OnVerticallAxis(float value)
    {
        Vector3 direction = new Vector3(transform.position.x, value, transform.position.z); 
        moverComponent.direction = direction; 
    }



    private void OnHasShoot()
    {
        Instantiate(shootPrefab, shootOrigin, false);
    }
 
    void Update()
    {

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 
        Input.GetAxis("Vertical"), 
        transform.position.z);
        moverComponent.direction = direction; 

 
        float x = Mathf.Clamp(transform.position.x, boundary.xMinimum, boundary.xMaximum);
        float y = Mathf.Clamp(transform.position.y, boundary.yMinimum, boundary.yMaximun);
        transform.position = new Vector3(x, y);

       /*  if (Input.GetButtonDown("shoot"))
        {
            Instantiate(shootPrefab, shootOrigin, false);
        } */
    }
}

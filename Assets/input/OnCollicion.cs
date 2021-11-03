using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollicion : MonoBehaviour
{
    [SerializeField] private UnityEvent action;

    private GameObject collisione;

   private void OnTriggerEnter2D(Collider2D collision)
   {
       collisione = collisione.gameObject;
       action.Invoke();
   }

   public void DestroyCollosionee()
   {
       if (collisione != null)
       {
           Destroy(collisione);
       }
   }
}

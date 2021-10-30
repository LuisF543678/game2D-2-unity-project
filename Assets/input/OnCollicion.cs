using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollicion : MonoBehaviour
{
    [SerializeField] private UnityEvent action;

    private GameObject collisionee;

   private void OnTriggerEnter2D(Collider2D collision)
   {
       collisionee = collisionee.gameObject;
       action.Invoke();
   }

   public void DestroyCollosionee()
   {
       if (collisionee != null)
       {
           Destroy(collisionee);
       }
   }
}

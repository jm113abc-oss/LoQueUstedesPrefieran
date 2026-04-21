using Unity.VisualScripting;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    //public AudioClip Colletclip;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("contacto con el trigger " + collider);

        Pcont controller = collider.GetComponent<Pcont>();

        if (controller != null)
        {

            if (controller.Health < controller.maxHealt)
            {


                controller.ChangeHealt(1);
                Destroy(gameObject);
              //  controller.PlaySound(Colletclip);
            }


        }



    }
}
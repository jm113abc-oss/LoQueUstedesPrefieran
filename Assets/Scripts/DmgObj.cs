using UnityEngine;

public class DmgObj : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        Pcont controller = collision.GetComponent<Pcont>();

        if (controller != null)

        {
            //controller.ChangeLive(-1);
            Debug.Log("Estás perdiendo vida");  
        }


    }
}

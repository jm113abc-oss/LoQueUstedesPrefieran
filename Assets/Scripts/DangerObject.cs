using UnityEngine;

public class Dangerobject : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        Pcont controller = collision.GetComponent<Pcont>();

        if (controller != null)
        {
            controller.ChangeHealt(-1);
            Debug.Log("estas perdiendo vida");
        }
    }


}

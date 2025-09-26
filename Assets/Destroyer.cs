using UnityEngine;

public class Destroyer : MonoBehaviour 
{



    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "CleanUp")
        {
            Destroy(collision.gameObject);

        }

    }
}

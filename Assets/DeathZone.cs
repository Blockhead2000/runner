using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [HeaderAttribute("Death Settings")]
    public float deathY = -10f;
    public DeathManager deathManager;


    private void Update()
    {
        if(transform.position.y < deathY)
        {
            if(deathManager != null)
            {

                deathManager.ShowDeathScreen();



            }
            else
            {
                Debug.LogWarning("DeathManager not assigned!");

            }





        }




    }

}

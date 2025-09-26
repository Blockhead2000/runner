using UnityEngine;
using Unity;

public class spawner : MonoBehaviour
{

    public GameObject[] objectsToSpawn;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;

    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 3.0f;

    void Start()
    {

        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Update()
    {

        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;


      if  (timeSinceLastSpawn > timeToNextSpawn)
        {

            int selection = Random.Range(0, objectsToSpawn.Length);


            Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity);
            timeSinceLastSpawn = 0;





        }
    }
    
}

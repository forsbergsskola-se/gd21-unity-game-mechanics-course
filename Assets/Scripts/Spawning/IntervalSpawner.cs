using System.Collections;
using UnityEngine;

public class IntervalSpawner : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private Transform spawnPointTransform;
    [SerializeField] private Transform spawnedObjectParent;

    // private float spawnTimer;

    //Starting our coroutine in OnEnable() allows us to resume spawning when re-activating the GameObject.
    private void OnEnable()
    {
        StartCoroutine(SpawnTimerCoroutine());
    }

    //Example of a timer using Update().
    // private void Update()
    // {
    //     RunSpawnTimer();
    // }
    //
    // private void RunSpawnTimer()
    // {
    //     spawnTimer += Time.deltaTime;
    //     if (spawnTimer > spawnInterval)
    //     {
    //         // spawnTimer = 0; //Reset timer to 0.
    //         spawnTimer -= spawnInterval; //Decrease time by spawnInterval. This one will give us a slightly more accurate timer.
    //         SpawnPrefab();
    //     }
    // }

    //A spawn timer implemented as a coroutine. Note that the name does NOT need to contain Coroutine.
    private IEnumerator SpawnTimerCoroutine()
    {
        while (true) //This creates an infinite loop. Be really careful when using infinite loops. We use it here because we can pause execution inside the coroutine.
        {
            // yield return null; //This pauses the coroutine for one frame.
            yield return new WaitForSeconds(spawnInterval); //This pauses the coroutine for spawnInterval amount of seconds. 
            SpawnPrefab();
        }
    }

    private void SpawnPrefab()
    {
        Instantiate(prefabToSpawn, spawnPointTransform.position, spawnPointTransform.rotation, spawnedObjectParent);
    }
}
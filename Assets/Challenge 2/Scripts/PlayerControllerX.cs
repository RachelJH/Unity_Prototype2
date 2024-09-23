using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastSpawnTime = 2.0f;
    private float spawnTime = 0;
    // Update is called once per frame
    void Update()
    {
        spawnTime = spawnTime + Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spawnTime > lastSpawnTime)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spawnTime = 0;
            }
        }
    }
}

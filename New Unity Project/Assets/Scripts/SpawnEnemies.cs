using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float timeToSpawn = 0;
    public float spawnCooldown = 10f;
    public GameObject shipPrefab;

    public void FixedUpdate()
    {
        if (Time.time > timeToSpawn)
        {
            timeToSpawn = Time.time + spawnCooldown;
            Instantiate(shipPrefab, new Vector3(Random.Range(-18, 18), Random.Range(-15, 15)), Quaternion.Euler(0, 0, 0));
            if(spawnCooldown > 3)
            {
                spawnCooldown *= .90f;
            }
        }
    }
}

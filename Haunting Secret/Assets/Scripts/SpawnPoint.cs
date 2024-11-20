using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public string SpawnPoint;

    private void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            Transform spawnPoint = GameObject.Find(SpawnPoint).transform;
            player.transform.position = spawnPoint.position;
        }
    }
}

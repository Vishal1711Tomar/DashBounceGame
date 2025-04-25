using UnityEngine;

public class FloorTrigger : MonoBehaviour
{ private bool isfloorSpawn = false;
    public Spawner spawner;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogError(collision.tag);
        if (collision.CompareTag("Player") && !isfloorSpawn)
        {
            isfloorSpawn = true;
            spawner.Spawnfloor();
        }
    }
}

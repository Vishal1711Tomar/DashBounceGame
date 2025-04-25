using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] floorPrefabs;
    public Transform spawnPoint;
    public void  Spawnfloor()
    {
        Debug.Log("call hua hai");
        int randomIndex = Random.Range(0, floorPrefabs.Length);
        Instantiate(floorPrefabs[randomIndex], spawnPoint.position,Quaternion.identity);
        Debug.Log(randomIndex);
    }
}

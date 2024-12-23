using UnityEngine;
using Random = UnityEngine.Random;
public class SlimeSpawner : MonoBehaviour
{
    
    [SerializeField] private GameObject[] slimes;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Transform container;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject slime in slimes)
            {
                int randomIndex = Random.Range(3, 7);
                for (int i = 0; i < randomIndex; i++)
                {
                    Instantiate(slime, spawnPoints[Random.Range(0,spawnPoints.Length)].position + 
                                       new Vector3(Random.Range(-2f, 2f), 0, Random.Range(-2f, 2f)), Random.rotation, container);
                }
            }
            GetComponent<BoxCollider>().size *= 5;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Transform child in container)
            {
                Destroy(child.gameObject);
            }
            GetComponent<BoxCollider>().size /= 5;
        }
    }
}

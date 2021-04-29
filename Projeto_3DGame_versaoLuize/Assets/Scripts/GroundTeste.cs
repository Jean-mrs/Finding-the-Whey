using UnityEngine;

public class GroundTeste : MonoBehaviour
{
	GroundSpawner groundSpawner;
    // Start is called before the first frame update
    private void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit (Collider other){
    	groundSpawner.SpawnTile();
    	Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle ()
    {
        // Chose a random point to spawn the object
        int obstacleSpawnIndex = Random.Range(2,5); // esses numeros se referen a ordem no prefab do GroundTest em que os abstaculos são lsitados
                                                    // atualmente, ainda há a cerca
                                                    // Esse último .transform apenas retorna o componente Transform dos tres tipos de obstáculos: da esquerda, do centro e da direita
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        // Spawn the osbtacle at the position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}

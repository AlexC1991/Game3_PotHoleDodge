using UnityEngine;

namespace AlexzanderCowell
{
    public class LineSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject itemToSpawn;
        [SerializeField] private Transform whereToSpawn;
        private int whatToSpawn;
        private int whereToSpawnIndex;
        private Vector3 currentPosition;
        private Quaternion _rotation;
       [SerializeField] private float startTimer;

        private void Start()
        {
            MovingSpeedGlobalScript.lineSpawnerSpeed = startTimer;
        }

        private void Update()
        {
            startTimer -= Time.deltaTime;
            
            if (startTimer < 0.1f)
            {
                Instantiate(itemToSpawn, whereToSpawn.position, Quaternion.identity);
                startTimer = MovingSpeedGlobalScript.lineSpawnerSpeed;
            }
        }

    }
}

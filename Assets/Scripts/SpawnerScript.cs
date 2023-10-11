using UnityEngine;

namespace AlexzanderCowell
{
    public class SpawnerScript : MonoBehaviour
    {
        [SerializeField] private GameObject[] itemsToSpawn;
        private float nextSpawn = 4f;
        [SerializeField] private Transform[] whereToSpawn;
        private int whatToSpawn;
        private int whereToSpawnIndex;
        public static bool increaseSpawnerSpeed;

        private void Update()
        {
            if (Time.time > nextSpawn)
            {
                whatToSpawn = Random.Range(0, itemsToSpawn.Length);
                whereToSpawnIndex = Random.Range(0, whereToSpawn.Length);
                Instantiate(itemsToSpawn[whatToSpawn], whereToSpawn[whereToSpawnIndex].position, Quaternion.identity);
                nextSpawn = Time.time + MovingSpeedGlobalScript.normalSpawningSpeed;
            }

            if (increaseSpawnerSpeed)
            {
                MovingSpeedGlobalScript.normalSpawningSpeed -= 0.5f;
                increaseSpawnerSpeed = false;
            }
        }
    }
}

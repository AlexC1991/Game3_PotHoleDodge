using UnityEngine;
namespace AlexzanderCowell
{
    public class LineandBushMovement : MonoBehaviour
    {
        private float currentSpeed;
        private Vector3 currentPosition;
        public static bool increaseLineSpeed;

        private void Awake()
        {
            currentPosition = transform.position;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DeathBox"))
            {
                Destroy(this.gameObject);
            }
        }

        void FixedUpdate()
        {
            currentPosition.y -= MovingSpeedGlobalScript.lineandBushMovingSpeed * Time.fixedDeltaTime;
            transform.position = currentPosition;
        }

        private void Update()
        {
            Debug.Log("Line Speed: " + MovingSpeedGlobalScript.lineandBushMovingSpeed);
            
            if (increaseLineSpeed)
            {
                MovingSpeedGlobalScript.lineandBushMovingSpeed += 0.2f;
                increaseLineSpeed = false;
            }
        }
    }
}

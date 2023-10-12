using UnityEngine;
namespace AlexzanderCowell
{
    public class LineandBushMovement : MonoBehaviour
    {
        private float currentSpeed;
        private Vector3 currentPosition;

        private void Start()
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
    }
}

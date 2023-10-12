using UnityEngine;
namespace AlexzanderCowell
{
    public class DodgeItemMovement : MonoBehaviour
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

        private void FixedUpdate()
        {
                currentPosition.y -= MovingSpeedGlobalScript.dodgeItemMovingSpeed * Time.fixedDeltaTime;
                transform.position = currentPosition;
        }


    }
}

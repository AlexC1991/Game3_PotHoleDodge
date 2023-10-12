using UnityEngine;
namespace AlexzanderCowell
{
    public class MovingSpeedGlobalScript : MonoBehaviour
    {
        public static float lineandBushMovingSpeed = 0.6f;
        public static float dodgeItemMovingSpeed = 0.8f;
        public static float lineSpawnerSpeed = 2;
        public static float normalSpawningSpeed = 3;
        public static bool increaseSpeeds;

        //[Range(-20,20)]
        //[SerializeField] private float lineandBushMovingSpeedEditor;
        //[Range(-20,20)]
        //[SerializeField] private float dodgeItemMovingSpeedEditor;
        //[Range(-20,20)]
        //[SerializeField] private float lineSpawnerSpeedEditor;
        //[Range(-20,20)]
        //[SerializeField] private float normalSpawningSpeedEditor;

        private void Start()
        {
            increaseSpeeds = false;
            lineandBushMovingSpeed = 0.6f;
            dodgeItemMovingSpeed = 0.8f;
            lineSpawnerSpeed = 2;
            normalSpawningSpeed = 3;
        }

        private void FixedUpdate()
        {
            if (increaseSpeeds)
            {
                lineandBushMovingSpeed += 0.2f;
                dodgeItemMovingSpeed += 0.2f;
                lineSpawnerSpeed -= 0.2f;
                normalSpawningSpeed -= 0.2f;
                increaseSpeeds = false;
            }
        }


    }

   
    
}

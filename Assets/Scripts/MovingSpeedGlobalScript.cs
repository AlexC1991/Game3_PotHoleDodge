using System;
using UnityEngine;
namespace AlexzanderCowell
{
    public class MovingSpeedGlobalScript : MonoBehaviour
    {
        public static float lineandBushMovingSpeed = 1f;
        public static float dodgeItemMovingSpeed = 1f;
        public static float lineSpawnerSpeed = 20f;
        public static float normalSpawningSpeed = 1f;
        
        
        [Range(-20,20)]
        [SerializeField] private float lineandBushMovingSpeedEditor;
        [Range(-20,20)]
        [SerializeField] private float dodgeItemMovingSpeedEditor;
        [Range(-20,20)]
        [SerializeField] private float lineSpawnerSpeedEditor;
        [Range(-20,20)]
        [SerializeField] private float normalSpawningSpeedEditor;


        private void Update()
        {
            lineSpawnerSpeed = lineSpawnerSpeedEditor;
            lineandBushMovingSpeed = lineandBushMovingSpeedEditor;
            dodgeItemMovingSpeed = dodgeItemMovingSpeedEditor;
            normalSpawningSpeed = normalSpawningSpeedEditor;
        }
    }
    
}

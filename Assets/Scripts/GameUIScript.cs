using UnityEngine;
using UnityEngine.UI;
namespace AlexzanderCowell
{
    public class GameUIScript : MonoBehaviour
    {
        [SerializeField] private Text _distanceTextTravelled;
        public static float _distanceNumbers;
        private void Start()
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }

        private void Update()
        {
            if (CarMovement._carIsMoving)
            { 
                _distanceNumbers += MovingSpeedGlobalScript.dodgeItemMovingSpeed * Time.deltaTime;
                _distanceTextTravelled.text = "Distance Travelled " + "\n" + _distanceNumbers.ToString("0");

                if (_distanceNumbers == 60 || _distanceNumbers == 120 || _distanceNumbers == 180 ||
                    _distanceNumbers == 240)
                {
                    DodgeItemMovement.increaseDodgeSpeed = true;
                    LineandBushMovement.increaseLineSpeed = true;
                    LineSpawner.increaseLineSpawnerSpeed = true;
                    SpawnerScript.increaseSpawnerSpeed = true;
                }
                
            }
        }
    }
}

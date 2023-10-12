using UnityEngine;
using UnityEngine.UI;
namespace AlexzanderCowell
{
    public class GameUIScript : MonoBehaviour
    {
        [SerializeField] private Text _distanceTextTravelled;
        public static float _distanceNumbers;
        private float holdingNumber;
        [SerializeField] private GameObject startButton;
        [SerializeField] private GameObject _playerCar;
        [SerializeField] private GameObject distanceText;
        [SerializeField] private GameObject _gameOverText;
        [SerializeField] private GameObject _restartButton;
        [SerializeField] private GameObject _Hearts;
        public static bool resetGameNow;
        private bool checkStart;
        private void Start()
        {
            checkStart = true;
            BeginPlaying();
            Screen.orientation = ScreenOrientation.Portrait;
            resetGameNow = false;
        }

        private void BeginPlaying()
        {
            if (checkStart)
            {
                startButton.SetActive(true);
                _playerCar.SetActive(false);
                distanceText.SetActive(false);
                _gameOverText.SetActive(false);
                _restartButton.SetActive(false);
                _Hearts.SetActive(false);
                _distanceNumbers = 0;
            }

            if (CarMovement._carIsMoving)
            {
                checkStart = false;
            }
        }

        private void FixedUpdate()
        {
            Debug.Log(holdingNumber);

            if (CarMovement._carIsMoving)
            { 
                _distanceNumbers += MovingSpeedGlobalScript.dodgeItemMovingSpeed * Time.deltaTime;
                _distanceTextTravelled.text = "Distance Travelled " + "\n" + _distanceNumbers.ToString("0");

                if (_distanceNumbers > 20 && _distanceNumbers < 20.02f)
                {
                    SpeedChange();
                    holdingNumber = _distanceNumbers * 2;  
                }
                else if (_distanceNumbers >= holdingNumber - 0.2f && _distanceNumbers <= holdingNumber + 0.2f && holdingNumber > 1)
                {
                    SpeedChange();
                    holdingNumber = _distanceNumbers * 2;
                }
            }
        }

        private void Update()
        {
            if (CarMovement._flickerCount == 4)
            {
                distanceText.SetActive(true);
                _Hearts.SetActive(true);
            }
            
            if (HealthScript._health == -1)
            {
                CarMovement._carIsMoving = false;
                _gameOverText.SetActive(true);
                _restartButton.SetActive(true);
                _playerCar.SetActive(false);
            }
        }

        private void SpeedChange()
        {
            MovingSpeedGlobalScript.increaseSpeeds = true;
        }
        
        public void StartTheGame()
        {
            CarMovement._carIsMoving = true;
            startButton.SetActive(false);
            _playerCar.SetActive(true);
        }

        public void ResetGameButton()
        {
            HealthScript._health = 4;
            resetGameNow = true;
        }
    }
    
}

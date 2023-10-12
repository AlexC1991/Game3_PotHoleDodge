using System;
using UnityEngine;
namespace AlexzanderCowell
{
    public class HealthScript : MonoBehaviour
    {
        [SerializeField] private GameObject heartOne;
        [SerializeField] private GameObject heartTwo;
        [SerializeField] private GameObject heartThree;

        public static int _health;
        private bool _isHit;
        private bool _canNotBeHit;

        private void Start()
        {
            heartOne.SetActive(true);
            heartTwo.SetActive(true);
            heartThree.SetActive(true);
            _isHit = false;
            _health = Mathf.Clamp(_health, 3, -1);
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("EnemyObject") && !_canNotBeHit)
            {
                _isHit = true;
            }
        }

        private void Update()
        {
            if (_isHit && !_canNotBeHit)
            {
                _health -= 1;
                CarMovement._flickerCount = 0;
                _canNotBeHit = true;
                _isHit = false;
            }
            
            if (CarMovement._flickerCount == 4)
            {
                _canNotBeHit = false;
            }
            else if (CarMovement._flickerCount < 4)
            {
                _canNotBeHit = true;
            }

            if (_health == 3)
            {
                heartOne.SetActive(true);
                heartTwo.SetActive(true);
                heartThree.SetActive(true);
            }
            else if (_health == 2)
            {
                heartOne.SetActive(true);
                heartTwo.SetActive(true);
                heartThree.SetActive(false);
            }
            else if (_health == 1)
            {
                heartOne.SetActive(true);
                heartTwo.SetActive(false);
                heartThree.SetActive(false);
            }
            else if (_health == 0)
            {
                heartOne.SetActive(false);
                heartTwo.SetActive(false);
                heartThree.SetActive(false);
            }
        }
    }
}

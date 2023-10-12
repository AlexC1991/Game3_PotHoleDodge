using System;
using UnityEngine;
namespace AlexzanderCowell
{
public class CarMovement : MonoBehaviour
{
    private Rigidbody2D _rB;
    private float _speed;
    private Vector2 _position;
    public static bool _carIsMoving;
    private float _carFlicker = 0.4f;
    private float _carFlickerOriginalTime;
    public static int _flickerCount;
    private bool _startthisGameNow;
    [SerializeField] private Transform origianlPosition;

    private void Start()
    {
        _rB = GetComponent<Rigidbody2D>();
        _carFlickerOriginalTime = _carFlicker;
    }

    private void Update()
    {
        Debug.Log(_flickerCount);
        
        if (_carIsMoving)
        {
            origianlPosition = transform;
            _carFlicker -= Time.deltaTime;
            StartFlickering();
            
            if (_flickerCount == 4)
            {
                _carFlicker = 0.4f;
                SpriteRenderer thisRenderer = GetComponent<SpriteRenderer>();
                Color currentColor = thisRenderer.color;
                currentColor.a = 1;
                thisRenderer.color = currentColor;
                _startthisGameNow = true;
            }
        }
        
        if (_startthisGameNow)
        {
                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);

                    if (touch.phase == TouchPhase.Moved) 
                    {
                        Vector2 pos = touch.position;
                        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(pos);
                        pos.x = Mathf.Clamp(worldPosition.x, -1.25f, 1.25f);
                        transform.position = new Vector3(pos.x, -1.92f, -0.24f);
                    }
                }
           
                
                //_position = Input.mousePosition;
            
            //if (_position.x > 0 || _position.x < 0)
            //{
               // Vector2 worldPosition = Camera.main.ScreenToWorldPoint(_position);
                //_position.x = Mathf.Clamp(worldPosition.x, -1.25f, 1.25f);
                
            //}
        }
    }

    private void StartFlickering()
    {
        if (_carFlicker > 0.2f)
        {
            SpriteRenderer thisRenderer = GetComponent<SpriteRenderer>();
            Color currentColor = thisRenderer.color;
            currentColor.a = 0.1f;
            thisRenderer.color = currentColor;
            transform.position = origianlPosition.position;
        }
        else if (_carFlicker > 0.1f)
        {
            SpriteRenderer thisRenderer = GetComponent<SpriteRenderer>();
            Color currentColor = thisRenderer.color;
            currentColor.a = 0.5f;
            thisRenderer.color = currentColor;
        }
        else if (_carFlicker < 0.1f)
        {
            SpriteRenderer thisRenderer = GetComponent<SpriteRenderer>();
            Color currentColor = thisRenderer.color;
            currentColor.a = 0.8f;
            thisRenderer.color = currentColor;
        }

        if (_carFlicker <= 0.1f)
        {
            _flickerCount += 1;
            _carFlicker = _carFlickerOriginalTime;
        }
    }
}
}

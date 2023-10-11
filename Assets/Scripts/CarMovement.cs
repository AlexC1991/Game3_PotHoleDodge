
using UnityEngine;
namespace AlexzanderCowell
{
public class CarMovement : MonoBehaviour
{
    private Rigidbody2D _rB;
    private float _speed;
    private Vector2 _position;
    public static bool _carIsMoving;

    private void Awake()
    {
        _rB = GetComponent<Rigidbody2D>();
        _carIsMoving = true;
    }

    private void Update()
    {
        if (_carIsMoving)
        {
            _position = Input.mousePosition;
            _position.x = Mathf.Clamp(_position.x, -1.07f, Screen.width);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(_position);
            transform.position = new Vector3(worldPosition.x,-3.99f, -0.04f);
        }
        
    }

}
}

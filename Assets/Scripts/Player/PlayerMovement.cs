using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Velocidad del personaje")]
    public float speed = 5f;

    [Header("Dependencias")]
    private Rigidbody2D _rb;
    public Vector2 _vectorMovement { get; private set; }
    

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (_rb != null)
        {
            _rb.velocity = _vectorMovement * speed;
        }
    }

    public void OnPlayerMovement(InputAction.CallbackContext vector2Dvalue)
    {
        _vectorMovement = vector2Dvalue.ReadValue<Vector2>();
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Velocidad del personaje")]
    public float speed;

    [Header("Dependencias")]
    private Vector2 _vectorMovement;
    private Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (_rb != null)
        {
            _rb.velocity = speed * _vectorMovement;
        }
    }

    public void OnPlayerMovement(InputAction.CallbackContext vector2Dvalue)
    {
        _vectorMovement = vector2Dvalue.ReadValue<Vector2>();
        Debug.Log("Input found");
    }
}

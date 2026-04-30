using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerAnimations : MonoBehaviour
{
    [Header("Dependencies")]
    private Animator _animator;
    private PlayerMovement _playerMovementSCR;

    void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _playerMovementSCR = GetComponent<PlayerMovement>();
    }

    void LateUpdate()
    {
        if (_animator != null && _playerMovementSCR != null)
        {
            _animator.SetBool("isWalking", _playerMovementSCR._vectorMovement != Vector2.zero);
            _animator.SetFloat("InputX", _playerMovementSCR._vectorMovement.x);
            _animator.SetFloat("InputY", _playerMovementSCR._vectorMovement.y);
        }
    }

    public void UpdateLastInput(InputAction.CallbackContext value)
    {
        Vector2 _temporalAxis = value.ReadValue <Vector2>();

        if (value.performed && _animator != null)
        {
            _animator.SetFloat("LastInputX", _temporalAxis.x);
            _animator.SetFloat("LastInputY", _temporalAxis.y);

            Debug.Log(_temporalAxis.x);
        }
    }
}

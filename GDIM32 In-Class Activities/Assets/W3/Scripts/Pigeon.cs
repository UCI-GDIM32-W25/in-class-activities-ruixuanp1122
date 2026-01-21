using UnityEngine;

public enum MovementState {
    Idle, Flying
}

public class Pigeon : MonoBehaviour
{
    [SerializeField] private Animator _animator;


    private MovementState _currentState;
    void Update()
    {
        UpdateState();
        UpdateAppearance();
    }

    private void UpdateState ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _currentState = MovementState.Flying;
        }
        else
        {
            _currentState = MovementState.Idle;
        }
    }

    private void UpdateAppearance()
    {
        switch (_currentState)
        {
            case MovementState.Flying:
                PlayFlyAnimation();
                break;

            case MovementState.Idle:
                PlayIdleAnimation();
                break;
        }
    }

    private void PlayFlyAnimation () {
        _animator.SetBool("isFlying", true);
    }

    private void PlayIdleAnimation () {
        _animator.SetBool("isFlying", false);
    }
}

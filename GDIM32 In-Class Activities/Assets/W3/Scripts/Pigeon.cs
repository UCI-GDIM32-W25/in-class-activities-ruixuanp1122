using UnityEngine;

public enum MovementState {
    Idle, Flying
}

public class W4Pigeon : MonoBehaviour
{
    public delegate void PigeonCooAction();
    public event PigeonCooAction OnPigeonCoo;

    [SerializeField] private Animator _animator;


    private MovementState _currentState;
    void Update()
    {
        UpdateState();
        UpdateAppearance();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Coo();
        }
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

    private void Coo()
    {

        OnPigeonCoo?.Invoke();
    }
}

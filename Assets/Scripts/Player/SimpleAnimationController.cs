using UnityEngine;

public class SimpleAnimationController : MonoBehaviour
{
    private Animator _animator;
    private PlayerController _playerController;
    
    private bool _isActiveAnimation;
    
    private static readonly int Action1 = Animator.StringToHash("Action1");
    private static readonly int Action2 = Animator.StringToHash("Action2");
   

    void Start()
    {
        _animator = GetComponent<Animator>();
        
        for(int i=0; i<_animator.runtimeAnimatorController.animationClips.Length; i++)
        {
            AnimationClip clip = _animator.runtimeAnimatorController.animationClips[i];
            
            AnimationEvent animationStartEvent = new AnimationEvent();
            animationStartEvent.time = clip.length;
            animationStartEvent.functionName = "SetAllBoolFalse";
            clip.AddEvent(animationStartEvent);
        }

        _playerController = GetComponent<PlayerController>();
        _playerController.Action1+= SetBoolActive1;
        _playerController.Action2+= SetBoolActive2;
    }

    public void SetAllBoolFalse()
    {
        _animator.SetBool(Action1,false);
        _animator.SetBool(Action2,false);
        _isActiveAnimation = false;
    }

    private void SetBoolActive1()
    {
        _animator.SetBool(Action1,true);
        _isActiveAnimation = true;
    }
    private void SetBoolActive2()
    {
        _animator.SetBool(Action2,true);
        _isActiveAnimation = true;
    }
}

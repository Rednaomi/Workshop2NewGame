using UnityEngine;
using UnityEngine.InputSystem;

public class KeyBindTest : MonoBehaviour
{
    public InputActionAsset YolanaPlayerAction;
    public Animator YolanaAnimator;
    
   

    // Update is called once per frame
    void Update()
    {
        if (YolanaPlayerAction.FindAction("Jump").IsPressed())
        {
            YolanaAnimator.SetBool("Jump", true);
        }
        else
        {
            YolanaAnimator.SetBool("Jump", false);
        }
        
        if (YolanaPlayerAction.FindAction("Move").IsPressed())
        {
            YolanaAnimator.SetBool("walk", true);
        }
        else
        {
            YolanaAnimator.SetBool("walk", false);
        }
    }
}

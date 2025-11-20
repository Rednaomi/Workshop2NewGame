using UnityEngine;
using unityEngine.InputSystem;

public class KeyBindTest : MonoBehaviour
{
    public InputActionAsset YolanaPlayerAction;
    public Animator YolanaAnimator;
    
   

    // Update is called once per frame
    void Update()
    {
        if (YolanaPlyerAction.FindAction("Jump").IsPressed())
        {
            YolanaAnimator.SetBool("Jump", true);
        }
        else
        {
            YolanaAnimator.SetBool("Jump", false);
        }
        
        if (YolanaPlyerAction.FindAction("Move").IsPressed())
        {
            YolanaAnimator.SetBool("walk", true);
        }
        else
        {
            YolanaAnimator.SetBool("walk", false);
    }
}

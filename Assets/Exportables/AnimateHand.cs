using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHand : MonoBehaviour
{
    public InputActionProperty pinchAction;
    public Animator handAnimation;
    public InputActionProperty gripAction;

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAction.action.ReadValue<float>();
        handAnimation.SetFloat("Trigger", triggerValue);

        float gripValue = gripAction.action.ReadValue<float>();
        handAnimation.SetFloat("Grip", gripValue);
    }
}

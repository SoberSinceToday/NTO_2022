using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandGrabInteractable : XRGrabInteractable
{
    [SerializeField]
    private Transform _secondAttachTransform;
    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        if (interactorsSelecting.Count == 1)
        {
            base.ProcessInteractable(updatePhase);
        }
        else if (interactorsSelecting.Count == 2 &&
                updatePhase ==  XRInteractionUpdateOrder.UpdatePhase.Dynamic)
        {
            ProcessDoubleGrip();
        }
        
    }

    private void ProcessDoubleGrip()
    {
        Transform firstAttach = GetAttachTransform(null);
        Transform firstHand = interactorsSelecting[0].transform;
        Transform secondAttach = _secondAttachTransform;
        Transform secondHand = interactorsSelecting[1].transform;

        Vector3 directionBetweenHands = secondHand.position - firstHand.position;

        Quaternion targetRotation = Quaternion.LookRotation(directionBetweenHands);

        Vector3 worldDirectionFromHandleToBase = transform.position - firstAttach.position;
        Vector3 localDirectionFromHandleToBase = transform.InverseTransformDirection(worldDirectionFromHandleToBase);

        Vector3 targetposition = firstHand.position + localDirectionFromHandleToBase;

        transform.SetPositionAndRotation(targetposition, targetRotation);
    }

    protected override void Awake()
    {
        base.Awake();
    }
    protected override void Grab()
    {
        if(!isSelected)
        base.Grab();
    }
}

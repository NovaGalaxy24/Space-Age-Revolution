using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetPokeToFingerAttachPoint : MonoBehaviour
{
    public Transform PokeAttachPoint;

    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor _xrPokeInteractor;

    void Start()
    {
        _xrPokeInteractor = transform.parent.parent.GetComponentInChildren<UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor>();
        SetPokeAttachPoint();
    }

    void SetPokeAttachPoint()
    {
        if (PokeAttachPoint == null) { Debug.Log("Poke Attach Point is null"); return; }
        if (_xrPokeInteractor == null) { Debug.Log("XR Poke Interactor Is null"); return; }

        _xrPokeInteractor.attachTransform = PokeAttachPoint;
    }
}

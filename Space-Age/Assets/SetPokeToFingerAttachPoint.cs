using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetPokeToFingerAttachPoint : MonoBehaviour
{
    public Transform PokeAttachPoint;

    private XRPokeInteractor _xrPokeInteractor;

    void Start()
    {
        _xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
        SetPokeAttachPoint();
    }

    void SetPokeAttachPoint()
    {
        if (PokeAttachPoint == null) { Debug.Log("Poke Attach Point is null"); return; }
        if (_xrPokeInteractor == null) { Debug.Log("XR Poke Interactor Is null"); return; }

        _xrPokeInteractor.attachTransform = PokeAttachPoint;
    }
}

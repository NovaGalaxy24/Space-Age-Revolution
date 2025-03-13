using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SmileSocketCheck : MonoBehaviour
{
    public XRSocketInteractor socketCheck;
    public string objectTag;
    private bool correctPiece = false;
    public SmileLock smileLock;
   

    public void GetInteractable()
    {
       IXRInteractable itemInteractable = socketCheck.GetOldestInteractableSelected(); //get interactable component
        GameObject item = itemInteractable.transform.gameObject; //get object attached to component
        if (item.tag == objectTag) //checks tag is correct
        {
           
            smileLock.AddSmileLock();
            correctPiece = true;
        }

        else
        {
            Debug.Log("no");
        }
    }

    public void RemovePiece()
    {
        if (correctPiece) //check is correct piece
        {
            
            smileLock.RemoveSmileLock();
            correctPiece = false;
            Debug.Log("correct piece removed");
        }

        else
        {
            Debug.Log("incorrect piece removed");
        }
    }
}

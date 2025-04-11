using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dialogue
{
    public class DialogueState : MonoBehaviour
    {
        //Dict(npcName, DialougeTreeState)
        public Dictionary<string, string> stateDict;

        //the tutorial guy listed a TODO message of "add save/load methods (serialization)" here
        private void Start()
        {
            stateDict = new Dictionary<string, string> ();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Helpers;
using UIElements;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit.Attachment;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace Dialogue
{

    public class DialogueHandler : MonoBehaviour
    {
        [SerializeField] private DialogueTreeObject dialogueTree;
        [SerializeField] private DialogueUI dialogueUI;
        [SerializeField] private UnityEvent onDialogueEnd;
        [SerializeField] private ScriptableEvent[] scriptableEvents;
        // Dialouge UI provider????? im so lost man

        private void Start()
        {
            dialogueTree.ResetCallbacks();
            foreach (var scriptableEvent in scriptableEvents)
            {
                dialogueTree.RegisterScriptableCallback(
                    scriptableEvent.eventName,
                    () => scriptableEvent.UnityEvent.Invoke()
                    );
            }
            dialogueTree.SetUpDialogueUnitsDict();
            dialogueTree.continueCallback += dialogueUI.ContinueDialogue;
            dialogueTree.continueCallback += ContinueDialogue;
            dialogueTree.endDialogueCallback += dialogueUI.EndDialogue;
            dialogueTree.endDialogueCallback += EndDialogue;

        }

        public void OnInteract(XRPokeInteractor pokeInteractor)
        {
            var dialogueState = pokeInteractor.gameObject.GetComponent<DialogueState>();
            if (dialogueState == null) return;

            dialogueTree.SetUpDialogueState(dialogueState);
            ContinueDialogue();
        }

        public void ContinueDialogue()
        {
            HandleDialogue(dialogueTree.GetNextDialogueUnity());
        }

        public void EndDialogue()
        {
            onDialogueEnd.Invoke();
        }

        private void HandleDialogue(DialogueUnit dialogueUnit)
        {
            //Get the UI from the UI provider
            //populate the Dialogue UI
            dialogueUI.SetNpcName(dialogueTree.npcName);
            dialogueUI.SetSentences(dialogueUnit.sentences);
            dialogueUI.SetDialogueOptions(dialogueUnit.options, dialogueTree.defaultOption);
            dialogueUI.ContinueDialogue();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    //public void TrigerDialogue()
    //{
    //  FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    //}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        if (collision.CompareTag("PlayerEndScreen"))
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}

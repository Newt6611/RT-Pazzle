using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.Instance.ShowDialogue();
            GameManager.Instance.SetState(GameManager.Instance.state_cache["DIA"]);
        }
    }
}

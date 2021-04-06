using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.Instance.Dialogue.SetActive(true);
            GameManager.Instance.SetState(GameManager.Instance.state_cache["DIA"]);
        }
    }
}

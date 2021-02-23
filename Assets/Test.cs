using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    PlayerInput input;

    public void Start() 
    {
        input = GetComponent<PlayerInput>();
    }

    private void Update() 
    {
        Debug.Log(input.currentControlScheme);    
    }

    public void OnWASD()
    {
        Debug.Log("WASD");
    }

    public void OnEnter()
    {
        Debug.Log("Enter");
    }

    public void OnSkill()
    {
        Debug.Log("Skill");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Right = 1, Back, Left, Forward
}

public class TurnCube : Cube
{
    [SerializeField] private Transform arrow_object;
    [SerializeField] private Direction direction;
    private float turn_degreed = 90f;

    private void Start() 
    {
        switch(direction)
        {
            case Direction.Left:
                turn_degreed = 0;
                break;
            case Direction.Forward:
                turn_degreed = 90;
                break;
            case Direction.Right:
                turn_degreed = 180;
                break;
            case Direction.Back:
                turn_degreed = 270;
                break;
        }
    }

    private void Update()
    {
        HasPlayerToTranslate();    
    }

    public override void OnCursorTrigger()
    {
        direction++;
        turn_degreed += 90;
        if(direction > Direction.Forward) 
            direction = Direction.Right;

        if(turn_degreed >= 360)
            turn_degreed = 0;

        StartCoroutine(RotateTo(Quaternion.Euler(0, turn_degreed, 0)));
    }

    public override void OnCursorTrigger(float degree)
    {   
        // the input degree should be always 180, otherwise some strange thing will happen...
        // Always Rotate 180
        turn_degreed += 180;
        if(turn_degreed >= 360)
            turn_degreed = 0;

        switch(direction)
        {
            case Direction.Right:
                direction = Direction.Left;
                break;
            case Direction.Left:
                direction = Direction.Right;
                break;
            case Direction.Forward:
                direction = Direction.Back;
                break;
            case Direction.Back:
                direction = Direction.Forward;
                break;
        }
        arrow_object.transform.Rotate(0, turn_degreed, 0);
    }

    private IEnumerator RotateTo(Quaternion target)
    {
        Quaternion from = arrow_object.rotation;
        for(float i=0f; i<1.0f; i += 20 * Time.deltaTime)
        {
            arrow_object.rotation = Quaternion.Slerp(from, target, i);
            yield return null;
        }
        arrow_object.rotation = target;
    }


    public override void SetDirection(Vector3 dir)
    {
        if(dir == Vector3.forward)
        {
            arrow_object.transform.rotation = Quaternion.Euler(0, 90, 0);
            direction = Direction.Forward;
        }
        else if(dir == Vector3.right)
        {
            arrow_object.transform.rotation = Quaternion.Euler(0, 180, 0);
            direction = Direction.Right;
        }
        else if(dir == Vector3.back)
        {
            arrow_object.transform.rotation = Quaternion.Euler(0, -90, 0);
            direction = Direction.Back;
        }
        else if(dir == Vector3.left)
        {   
            arrow_object.transform.rotation = Quaternion.Euler(0, 0, 0);
            direction = Direction.Left;
        }
    } 

    // if this cube has palyer to translate
    public void HasPlayerToTranslate() 
    {
        if(players.Count > 0)
        {
            for(int i=0; i<players.Count; i++)
            {
                if(players[i] != null)
                {
                    StartCoroutine(SendPlayerToNextCube(players[i]));
                }
            }
        }
    }
    
    private bool isCor = false; // For Delay
    private IEnumerator SendPlayerToNextCube(Player player)
    {
        if(isCor)
            yield break;

        isCor = true;

        yield return new WaitForSeconds(player.GetSpeed());
        
        Ray ray = new Ray(transform.position, GetDirection());
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, cube_mask)) 
        {
            Cube c = hit.transform.GetComponent<Cube>();

            // Set Player's Target Position To Next Cube
            for(int i=0; i<players.Count; i++)
            {
                if(players[i] != null)
                {
                    players[i].target_position = c.player_position;
                    RemovePlayer(players[i]);
                }
            }
        }
        isCor = false;
    }   
    
    public Vector3 GetDirection() 
    {
        // convert enum class Direction to Vector3
        switch(direction)
        {
            case Direction.Forward:
                return Vector3.forward;
            case Direction.Back:
                return Vector3.back;
            case Direction.Right:
                return Vector3.right;
            case Direction.Left:
                return Vector3.left;
        }

        return Vector3.zero;
    }
}

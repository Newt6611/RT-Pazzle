using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    [SerializeField] private Transform move_point;
    [SerializeField] private float cursor_speed;
    
    private Vector2 movement;
    private bool can_input_from_player;
    private Cube current_cube;
    [SerializeField] private LayerMask cube_layer;
    
    // For Player
    public bool ShouldGetNewDir { get; private set; }
    private Vector3 direction;

    private void Start()
    {
        move_point.parent = null;
        direction = Vector3.forward;
    }

    private void Update()
    {
        CursorMovement();
    }

    public void InitCursor(Player player)
    {
        transform.position = new Vector3(player.transform.position.x, 6.0f, player.transform.position.z);
    }

    public void SetMovement(Vector2 movement) 
    {
        this.movement = movement.normalized;
    }

    public void OnTriggerCursor() 
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(move_point.position);
        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, cube_layer)) 
        {
            Cube c = hit.transform.GetComponent<Cube>();
            c.OnCursorTrigger();

            // if touch turn cube then update the direction for player
            if(c.transform.CompareTag("TurnCube") && c.HasPlayer())
            {
                direction = c.transform.GetComponent<TurnCube>().GetDirection();
                ShouldGetNewDir = true;
            }
        }
    }

    public void OnTriggerCursor(float degree)
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(move_point.position);
        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, cube_layer)) 
        {
            Cube c = hit.transform.GetComponent<Cube>();
            c.OnCursorTrigger(degree);

            // if touch turn cube then update the direction for player
            if(c.transform.CompareTag("TurnCube") && c.HasPlayer())
            {
                direction = c.transform.GetComponent<TurnCube>().GetDirection();
                ShouldGetNewDir = true;
            }
        }
    }

    public Cube GetNearCube(Vector3 dir)
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(move_point.position);
        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, cube_layer)) 
        {
            Cube c = hit.transform.GetComponent<Cube>();
            return c.GetNextCube(dir);
        }

        Debug.Log("Priest's skill GetNearCube : Error, No Cube To return");
        return null;
    }

    public Vector3 GetDirection()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(move_point.position);
        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, cube_layer)) 
        {
            Cube c = hit.transform.GetComponent<Cube>();

            if(c.transform.CompareTag("TurnCube"))
            {
                return c.GetComponent<TurnCube>().GetDirection();
            }
        }
        return Vector3.zero;
    }

    public Vector3 GetNewDirection()
    {
        ShouldGetNewDir = false;
        return direction;
    }

    private void CursorMovement()
    {
        can_input_from_player = Vector3.Distance(transform.position, move_point.position) == 0.0f;

        if(can_input_from_player) 
        {
            bool has_cube = HasNearCube(new Vector3(move_point.position.x + movement.normalized.x * 6, 6, move_point.position.z + movement.normalized.y * 6));

            if(Mathf.Abs(movement.x) == 1 && has_cube) 
            {
                move_point.position += new Vector3(movement.normalized.x * 6, 0, 0);
            }
            else if(Mathf.Abs(movement.y) == 1 && has_cube)
            {
                move_point.position += new Vector3(0, 0, movement.normalized.y * 6);
            }
        }
        else if(!can_input_from_player) 
        {
            transform.position = Vector3.MoveTowards(transform.position, move_point.position, cursor_speed * Time.deltaTime);
        }
    }

    private bool HasNearCube(Vector3 position) 
    {
        Collider[] c = Physics.OverlapSphere(position, 1.5f, cube_layer);
        if(c.Length != 0 && !c[0].CompareTag("EmptyCube"))
            return true;
        return false;
    }
}

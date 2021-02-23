using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] protected List<Player> players = new List<Player>();
    public Transform player_position;
    
    [SerializeField] protected LayerMask cube_mask;

    public virtual void OnCursorTrigger() {}
    public virtual void OnCursorTrigger(float degree) {}
    public virtual void SetDirection(Vector3 dir) {}

    public void SetPlayer(Player player)
    {
        players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        if(players.Contains(player))
            players.Remove(player);
    }

    public void ClearAllPlayer()
    {
        players.Clear();
    }
    
    public Cube GetNextCube(Vector3 dir)
    {
        Ray ray = new Ray(transform.position, dir);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, cube_mask))
        {
            return hit.transform.GetComponent<Cube>();
        }

        Debug.Log("No Next Cube");
        return null;
    }

    public Transform GetNextCubePlayerPos(Vector3 dir)
    {
        Ray ray = new Ray(transform.position, dir);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, cube_mask))
        {
            return hit.transform.GetComponent<Cube>().player_position;
        }

        Debug.Log("No Next Cube");
        return null;
    }

    // For Sword Man's Skill
    public void StunPlayer()
    {
        if(HasPlayer())
        {
            foreach(Player p in players)
            {
                if(p != null)
                {
                    p.Stuned();
                }
            }
        }
    }


    public bool HasPlayer() => players.Count > 0;
}

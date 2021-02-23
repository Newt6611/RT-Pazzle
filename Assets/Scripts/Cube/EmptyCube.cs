using UnityEngine;

public class EmptyCube : Cube
{
    private float wait_time = 3.0f;
    private float timeBTW;

    private void Start()
    {
        timeBTW = wait_time;
    }

    private void Update() 
    {
        if(HasPlayer())
        {
            if(timeBTW <= 0f)
            {
                SendPlayerBackToPreCube();
                timeBTW = wait_time;
            }
            else
            {
                timeBTW -= Time.deltaTime;
            }
        }
    }

    private void SendPlayerBackToPreCube()
    {
        foreach(Player player in players)
        {
            player.target_position = player.Current_Cube.player_position;
        }

        players.Clear();
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(new Vector3(transform.position.x + -0.0999999f, (float)transform.position.y + 5.9f/2.0f, transform.position.z + 0.04999995f), new Vector3(6.0f, 5.9f, 6.1f));
    }   
}

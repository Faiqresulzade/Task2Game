using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] float Enemyspeed = 1;
    Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        //  player=FindObjectOfType<Player>();
        // transform.position += new Vector3(0, 0, 1 * Time.deltaTime * -Enemyspeed);
        // transform.Translate(player.transform.position);
        transform.position = Vector3.Lerp(transform.position, player.transform.position,.1f*Time.deltaTime);
       transform.LookAt(player.transform);

    }
}

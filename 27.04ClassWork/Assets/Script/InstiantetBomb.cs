using System.Collections;
using UnityEngine;

public class InstiantetBomb : MonoBehaviour
{
   [SerializeField] GameObject bumm;
    Player player;
    GameObject Go;
    public Collider[] colliders;
    void Start()
    {
        player=FindObjectOfType<Player>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
          Go=Instantiate(bumm, player.transform.position,player.transform.rotation);
            Go.AddComponent<MoveBumm>();
            colliders = Physics.OverlapSphere(transform.position,12f);
            StartCoroutine(Bomb());
        }
    }
    IEnumerator Bomb()
    {
        yield return new WaitForSeconds(2f);
        foreach (Collider collider in colliders)
        {
            collider.gameObject.AddComponent<Rigidbody>();
            Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>();
            rb.AddExplosionForce(250f, transform.position, 2 * 2f);
        }
    }
}

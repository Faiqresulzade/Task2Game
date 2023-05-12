using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{
    InstiantetEnemy enemy;
    void Start()
    {
        StartCoroutine(DestroyEnemyBullet());
    }

    void Update()
    {
       // enemy = FindObjectOfType<InstiantetEnemy>();
        // transform.position += new Vector3(0, 0, 1f * Time.deltaTime);
        transform.Translate(new Vector3(0, 0, 8f * Time.deltaTime),Space.Self);
        // Debug.Log(player.vertical);
    }
    IEnumerator DestroyEnemyBullet()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}

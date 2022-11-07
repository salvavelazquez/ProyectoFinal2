using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemyShoot : MonoBehaviour
{
    public GameObject enemyBullet;

    public Transform spawnBulletPoint;

    private Transform playerPosition;

    public float bulletVelocity = 100;
    void Start()
    {
        playerPosition = FindObjectOfType<Player>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootPlayer()
    {
        Vector3 playerDirection = playerPosition.position - transform.position;

        GameObject newBullet;

        newBullet = Instantiate(enemyBullet, spawnBulletPoint.position, spawnBulletPoint.rotation);

        newBullet.GetComponent<Rigidbody>().AddForce(playerDirection, ForceMode.Force);

        Invoke("ShootPLayer", 3);
    }
}

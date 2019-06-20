using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject endGame;
    public float speed;
    public float ballCount = 100;

    public Text ballLimit;

    void Start()
    {
        // ballCount = 100;
        ballLimit.text = ballCount + ("");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject insBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody insBulletRig = insBullet.GetComponent<Rigidbody>();
            insBulletRig.AddForce(transform.forward * speed);

            ballCount -= 1;
            if (ballCount <= 0)
            {
                endGame.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}

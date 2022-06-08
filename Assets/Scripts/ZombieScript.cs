using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    private int speed = 2;
    private Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerVerfolgen();
    }

    private void PlayerVerfolgen()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space))
        {
            GameScript.anzahlZombies--;
            this.gameObject.SetActive(false);
        }
    }
}
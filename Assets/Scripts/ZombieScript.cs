using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    private int speed = 2;
    private Transform Player;

    private float ZombieHP;
    private bool ZombieSchadenBekommen;
    private bool ZombieKriegtRückstoß;

    // Start is called before the first frame update
    void Start()
    {
        ZombieHP = 9;
        PlayerScript.SchlagCountdown = 3;
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerVerfolgen();
        PlayerScript.PlayerKannSchlagen();
        Debug.Log(PlayerScript.SchlagCountdown);
    }

    private void PlayerVerfolgen()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space) && PlayerScript.schlagfähig == true)
        {
            ZombieSchadenBekommen = true;
            ZombieSchaden();
            stirbZombie();
        }
    }

    private void ZombieSchaden()
    {
        if (ZombieSchadenBekommen == true)
        {
            PlayerScript.SchlagCountdown = 3;
            ZombieHP = ZombieHP - 1;
            ZombieKriegtRückstoß = true;
            ZombieRückstoß();
            ZombieSchadenBekommen = false;
        }
    }

    private void ZombieRückstoß()
    {
        if(ZombieKriegtRückstoß == true)
        {
            transform.Translate(transform.position.x - Player.transform.position.x, transform.position.y - Player.transform.position.y, 0);
            Debug.Log("Cbug");
            ZombieKriegtRückstoß = false;
        }
    }

    private void stirbZombie()
    {
        if(ZombieHP == 0)
        {
            GameScript.anzahlZombies--;
            GameScript.score += 100;
            this.gameObject.SetActive(false);
        }
    }
}
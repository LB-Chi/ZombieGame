using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameScript : MonoBehaviour
{
    public GameObject Zombie;
    private Vector2 spawning;

    public static int anzahlZombies;

    public static int score;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        anzahlZombies = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        NeueWelleStarten();
        scoreAnzeigen();
    }

    private void spawnZombie()
    {
        int x = Random.Range(-15, 15);
        int y = Random.Range(-10, 10);
        anzahlZombies++;
        spawning = new Vector2(x, y);
        Instantiate(Zombie, spawning, Quaternion.identity);
    }

    private void NeueWelleStarten()
    {
        if (anzahlZombies == 0)
        {
            //ICH WEI� FOR SCHLEIFE GEHT AUCH! BIN ZU FAUL
            spawnZombie();
            spawnZombie();
            spawnZombie();
        }
    }

    private void scoreAnzeigen()
    {
        scoreText.text = "Score: " + score;
    }
}

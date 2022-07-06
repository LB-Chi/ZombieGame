using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameScript : MonoBehaviour
{
    public GameOver GameOver;
    int currentHealth = 0;

    public void GameOver1()
    {
        GameOver.Setup(currentHealth);
    }

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
        int LR = Random.Range(0, 2);

        if (LR == 0)
        {
            int x = Random.Range(-1, 1);
            int y = Random.Range(-1, 1);
            spawning = new Vector2(x + 20, y);
            Instantiate(Zombie, spawning, Quaternion.identity);
        }

        if (LR == 1)
        {
            int x = Random.Range(-1, 1);
            int y = Random.Range(-1, 1);
            spawning = new Vector2(x - 20, y);
            Instantiate(Zombie, spawning, Quaternion.identity);
        }

        anzahlZombies++;
    }

    private void NeueWelleStarten()
    {
        if (anzahlZombies == 0)
        {
            //ICH WEI� FOR SCHLEIFE GEHT AUCH! BIN ZU FAUL
            spawnZombie();
            spawnZombie();
            spawnZombie();
            spawnZombie();
            spawnZombie();
            spawnZombie();
        }
    }

    public void scoreAnzeigen()
    {
        scoreText.text = "Score: " + score;
    }
}

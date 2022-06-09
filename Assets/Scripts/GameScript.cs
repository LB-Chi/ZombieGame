using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public GameObject Zombie;
    private Vector2 spawning;

    public static int anzahlZombies;


    // Start is called before the first frame update
    void Start()
    {
        anzahlZombies = 0;
    }

    // Update is called once per frame
    void Update()
    {
        NeueWelleStarten();
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
            spawnZombie();
            spawnZombie();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public GameObject Zombie;

    private Vector2 spawning;

    // Start is called before the first frame update
    void Start()
    {
        spawnZombie();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnZombie()
    {
        spawning = new Vector2(0, 0);
        Instantiate(Zombie, spawning, Quaternion.identity);
    }
}

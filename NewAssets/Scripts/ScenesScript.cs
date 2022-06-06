using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToGame()
    {
        // File -> Build Settings - Da hab ich die Szenen eine "Nummer" gegeben per Drag&Drop und darum die Nummer 1 für Spiel. Die Lobby hat Nummer 0
        SceneManager.LoadScene(1);
    }
}

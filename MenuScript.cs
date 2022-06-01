using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public bool inBesitz = false;

    public static bool GalaxyAusgesucht = false;
    public static bool UnderWaterAusgesucht = false;
    public static bool DesertAusgesucht = false;

    public bool loading;

    public Canvas loadingCanvas;
    public Canvas LobbyCanvas;

    float maxZeit = 4;
    float aktuelleZeit = 4;

    // Start is called before the first frame update
    void Start()
    {
        //SaveScript.LoadData();
        //aktuelleZeit = maxZeit;
        loadingCanvas.gameObject.SetActive(false);
        LobbyCanvas.gameObject.SetActive(true);
        //loading = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (inBesitz == true)
        {
            SceneManager.LoadScene(4);
        }

        /*if(GalaxyAusgesucht == true)
        {
            GalaxyAusgesucht = true;
            UnderWaterAusgesucht = false;
            DesertAusgesucht = false;
        }
        if(UnderWaterAusgesucht == true)
        {
            GalaxyAusgesucht = false;
            UnderWaterAusgesucht = true;
            DesertAusgesucht = false;
        }
        if(DesertAusgesucht == true)
        {
            GalaxyAusgesucht = false;
            UnderWaterAusgesucht = false;
            DesertAusgesucht = true;
        }*/
        //aGalaxyAusgesucht();
        //aUnderWaterAusgesucht();
        //aDesertAusgesucht();

        if (loading == true)
        {
            Debug.Log("Debug.Log();");

            loadingCanvas.gameObject.SetActive(true);
            LobbyCanvas.gameObject.SetActive(false);

            aktuelleZeit -= 1 * Time.deltaTime;

            if (aktuelleZeit <= 0)
            {
                Debug.Log("Eine Runde Valorant auf ganz entspannt");
                aktuelleZeit = 0;
                //loadingCanvas.gameObject.SetActive(false);
                //LobbyCanvas.gameObject.SetActive(true);
                SceneManager.LoadScene(7);
                loading = false;
            }

            //loading = false;
        }

        Debug.Log(aktuelleZeit);

    }

    public void BuyBP()
    {
        inBesitz = true;
    }

    public void ToSPMP() 
    {
        SceneManager.LoadScene(0);
    }

    public void ToLobby()
    {
        SceneManager.LoadScene(0);
        PlayerScript.platz = false;
        ApfelBot.platz = false;
        BMBot.platz = false;
        CABot.platz = false;
        CMBot.platz = false;
        HühnchenBot.platz = false;
        NoSkinBot.platz = false;
        PinkoBot.platz = false;
        PiratBot.platz = false;
        RoboterBot.platz = false;

        Platz1Script.voll1 = false;
        Platz2Script.voll2 = false;
        Platz3Script.voll3 = false;

        PlayerScript.erledigt = false;
    }
    public void ToBP()
    {
        if (inBesitz == false)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void ToShop()
    {
        SceneManager.LoadScene(2);
    }
    public void ToCustoms()
    {
        SceneManager.LoadScene(3);
    }

    public void ToCustoms2()
    {
        SceneManager.LoadScene(10);
    }

    public void ToMoney()
    {
        SceneManager.LoadScene(7);
    }

    public void beenden()
    {
        SaveScript.SaveData();
        Application.Quit();
    }

    public void ToRun()
    {
        

        if (GalaxyAusgesucht == true)
        {
            loading = true;
            Debug.Log("What's going on?");
            //SceneManager.LoadScene(11);
            
            //SceneManager.LoadScene(7);

        }
        if(UnderWaterAusgesucht == true)
        {
            SceneManager.LoadScene(4);
        }
        if(DesertAusgesucht == true)
        {
            SceneManager.LoadScene(5);
        }
        if(GalaxyAusgesucht == false && UnderWaterAusgesucht == false && DesertAusgesucht == false)
        {
            SceneManager.LoadScene(8);
            Debug.Log("bunker mit rrrrrrrrrr");
        }
        
    }

    public void ToSelectMap()
    {
        SceneManager.LoadScene(8);
    }
    
    public void ToMultiPlayer()
    {
        SceneManager.LoadScene(9);
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ToGalaxyRun()
    {
        SceneManager.LoadScene(6);
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameManager : MonoBehaviour
{
    public float invokeFaedTime;
    public GameObject text;
    public bool isGame = false;

    public GameObject GameBg;
    public GameObject GameTitle;

    //public float invokeFadeTime;
    public float FadeTime = 2f;
    public float startbg = 0f;
    public float Endbg = 255.0f;
    float time = 0f;
    bool isPlaying = false;

    public AudioSource sound;
    public AudioClip swordsound;
    public SystemManager system;

    // Start is called before the first frame update
    void Start()
    {
        system = GameObject.FindGameObjectWithTag("SystemManager").GetComponent<SystemManager>();
        Invoke("startGAME", invokeFaedTime);
    }
    void startGAME()
    {
        text.SetActive(true);
        StartCoroutine(faedText());
        isGame = true;
    }

    private void Update()
    {
        if (isGame)
        {
            if (Input.anyKey)
            {
                GameTitle.GetComponent<Image>();
                GameBg.GetComponent<Image>();
                text.GetComponent<Text>();
                startFaidin();
                Invoke("LoadSceneStart", 2);
            }
        }
        else
        {
            return;
        }
    }
    void LoadSceneStart()
    {
        system.DB.isGames = true;
        SceneManager.LoadScene("SampleScene");
    }

    public void startFaidin()
    {
        
        if (isPlaying)
        {
            return;
        }
        
        startbg = 1;
        Endbg = 0;
        StartCoroutine(fadeoutplay());
        sound.PlayOneShot(swordsound);
    }
    IEnumerator fadeoutplay()

    {

        isPlaying = true;



        Color fadecolor = GameBg.GetComponent<Image>().color;

        time = 0;

        fadecolor.a = Mathf.Lerp(startbg, Endbg, time);



        while (fadecolor.a > 0)

        {

            time += Time.deltaTime / FadeTime;

            fadecolor.a = Mathf.Lerp(startbg, Endbg, time);

            GameTitle.GetComponent<Image>().color = fadecolor;
            GameBg.GetComponent<Image>().color = fadecolor;
            text.GetComponent<Text>().color = fadecolor;

            yield return null;

        }

        isPlaying = false;

    }
    public int st;
    public int sb;
    IEnumerator faedText()
    {
        //text.GetComponent<Text>().color = new Color(text.GetComponent<Text>().color.r, text.GetComponent<Text>().color.g, text.GetComponent<Text>().color.b, 0);
        for (int i = 0; i < 60; i++)
        {
            
            yield return new WaitForSeconds(0.15f);
            st++;
            if (st > 1)
            {
                text.GetComponent<Text>().color = new Color(text.GetComponent<Text>().color.r, text.GetComponent<Text>().color.g, text.GetComponent<Text>().color.b, 255);
                st = 0;
                sb++;
                if (sb > 3)
                {
                    sb = 0;
                    text.GetComponent<Text>().color = new Color(text.GetComponent<Text>().color.r, text.GetComponent<Text>().color.g, text.GetComponent<Text>().color.b, 0);
                }
                
                //text.GetComponent<Text>().color = new Color(text.GetComponent<Text>().color.r, text.GetComponent<Text>().color.g, text.GetComponent<Text>().color.b, 255);
            }
            i = 0;
        }
    }
}

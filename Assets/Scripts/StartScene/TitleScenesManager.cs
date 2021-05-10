using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScenesManager : MonoBehaviour
{
    public GameObject TitleText;
    public GameObject StartText;
    public GameObject GameBg;
    public Sprite title2;
    public float invokeFadeTime;
    public float FadeTime = 2f;
    public float startbg = 0f;
    public float Endbg = 255.0f;
    float time = 0f;
    bool isPlaying = false;
    public bool isTitleName;
    public AudioSource sound;
    public AudioClip swordsound;


    public void Awake()
    {
        GameBg.GetComponent<Image>();
        Invoke("startFaidin", invokeFadeTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void startFaidin()
    {
        if (isPlaying)
        {
            return;
        }

        startbg = 0;
        Endbg = 1;
        StartCoroutine(fadeoutplay());
        
    }
    IEnumerator fadeoutplay()

    {

        isPlaying = true;



        Color fadecolor = GameBg.GetComponent<Image>().color;

        time = 0;

        fadecolor.a = Mathf.Lerp(startbg, Endbg, time);
        

        
        while (fadecolor.a < 1)

        {

            time += Time.deltaTime / FadeTime;

            fadecolor.a = Mathf.Lerp(startbg, Endbg, time);

            GameBg.GetComponent<Image>().color = fadecolor;
            
            yield return null;

        }
        if (isTitleName)
        {
            GameBg.GetComponent<Image>().sprite = title2;
            sound.PlayOneShot(swordsound);
        }

        isPlaying = false;
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFaidManager : MonoBehaviour
{
    public GameObject TitleText;

    public float invokeFadeTime;

    public float FadeTime = 2f;
    public float startbg = 0f;
    public float Endbg = 255.0f;
    float time = 0f;
    bool isPlaying = false;

    public void Awake()
    {
        TitleText.GetComponent<Text>();
        Invoke("startFaidin", invokeFadeTime);
        //startFaidin
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



        Color fadecolor = TitleText.GetComponent<Text>().color;

        time = 0;

        fadecolor.a = Mathf.Lerp(startbg, Endbg, time);



        while (fadecolor.a < 1)

        {

            time += Time.deltaTime / FadeTime;

            fadecolor.a = Mathf.Lerp(startbg, Endbg, time);

            TitleText.GetComponent<Text>().color = fadecolor;

            yield return null;

        }

        isPlaying = false;

    }
}

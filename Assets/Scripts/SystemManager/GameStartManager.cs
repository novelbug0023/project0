using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartManager : MonoBehaviour
{
    public SystemManager systemM; 
    // Start is called before the first frame update
    void Start()
    {
        systemM = GameObject.FindGameObjectWithTag("SystemM").GetComponent<SystemManager>();
        if (systemM.DB.isTutorial)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EventManagers : MonoBehaviour
{
    public string envent_Name;
    public ShowDialogue Showdialogue;
    public SystemManager systemManager;
    public MapDatabass mapdb;
    public GameObject target;
    public GameObject[] jobPotall;
    //public string eventKinds;

    // Start is called before the first frame update
    void Start()
    {
        Showdialogue = GameObject.FindGameObjectWithTag("ShowDialogue").GetComponent<ShowDialogue>();
        systemManager = GameObject.FindGameObjectWithTag("SystemManager").GetComponent<SystemManager>();
        mapdb = GameObject.FindGameObjectWithTag("MapDB").GetComponent<MapDatabass>();
    }

    // Update is called once per frame
    void Update()
    {
        if (systemManager.DB.isEvent)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                switch (target.GetComponent<PlayerMove>().eventKinds)
                {
                    case "³²±Ã":
                        Debug.Log("³²±Ã¼¼°¡¼±ÅÃ");
                        target.GetComponent<PlayerMove>().eventKinds = null;
                        break;
                    case "¸¶±³":
                        Debug.Log("ÀÏ¿ùÃµ¸¶½Å±³¼±ÅÃ");
                        target.GetComponent<PlayerMove>().eventKinds = null;
                        break;
                    case "ºù±Ã":
                        Debug.Log("ºÏÇØºù±Ã¼±ÅÃ");
                        target.GetComponent<PlayerMove>().eventKinds = null;
                        break;
                    case "Ç÷±³":
                        Debug.Log("Ç÷Ãµ¼ö¶ó±³¼±ÅÃ");
                        target.GetComponent<PlayerMove>().eventKinds = null;
                        break;
                }
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (this.gameObject.GetComponent<EventManagers>().envent_Name)
            {
                case "Æ©Åä¸®¾ó":
                    if (systemManager.DB.isTutorial)
                    {
                        Debug.Log("Æ©Åä¸®¾ó");
                        Showdialogue.startDI();
                    }
                    break;
                case "³²±Ã":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;
                    
                    systemManager.DB.isEvent = true;
                    Debug.Log("³²±Ã¼¼°¡·çÆ®");
                    
                    break;
                case "¸¶±³":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;
                    
                    systemManager.DB.isEvent = true;
                    Debug.Log("ÀÏ¿ùÃµ¸¶½Å±³·çÆ®");
                    
                    break;
                case "ºù±Ã":
                     target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;
                   
                    systemManager.DB.isEvent = true;
                    Debug.Log("ºÏÇØºù±Ã·çÆ®");
                    
                    break;
                case "Ç÷±³":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;
                    systemManager.DB.isEvent = true;
                    Debug.Log("Ç÷Ãµ¼ö¶ó±³·çÆ®");
                    
                    break;

            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (this.gameObject.GetComponent<EventManagers>().envent_Name)
            {
                case "Á÷¾÷¼±ÅÃ":
                    if (systemManager.DB.isJob)
                    {
                        StartCoroutine(invokeTimes());
                        Debug.Log("Á÷¾÷¼±ÅÃ");
                        mapdb.DB.mapNum = 0;
                        mapdb.DB.Player.position = mapdb.DB.home.transform.position;
                        Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.home.transform.position.y + 3f, Camera.main.transform.position.z);
                        mapdb.minmap.transform.position = new Vector3(mapdb.minmapPos[0].transform.position.x, mapdb.minmapPos[0].transform.position.y, -25.0f);
                        mapdb.fadeMap();
                        for (int i = 0; i <= jobPotall.Length; i++)
                        {
                            jobPotall[i].SetActive(true);
                        }
                        //Showdialogue.startDI();
                    }
                    break;
                    #region ¼¼·Â¼±ÅÃ ¾ÈµÈºÎºÐ
                    //case "³²±Ã":
                    //    if (Input.GetKeyDown(KeyCode.Z))
                    //    {
                    //        Debug.Log("³²±Ã¼¼°¡¼±ÅÃ");
                    //    }
                    //    break;
                    //case "¸¶±³":
                    //    if (Input.GetKeyDown(KeyCode.Z))
                    //    {
                    //        Debug.Log("ÀÏ¿ùÃµ¸¶½Å±³¼±ÅÃ");
                    //    }
                    //    break;
                    //case "ºù±Ã":
                    //    if (Input.GetKeyDown(KeyCode.Z))
                    //    {
                    //        Debug.Log("ºÏÇØºù±Ã¼±ÅÃ");
                    //    }
                    //    break;
                    //case "Ç÷±³":
                    //    if (Input.GetKeyDown(KeyCode.Z))
                    //    {
                    //        Debug.Log("Ç÷Ãµ¼ö¶ó±³¼±ÅÃ");
                    //    }
                    //    break;
                    #endregion
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (this.gameObject.GetComponent<EventManagers>().envent_Name)
            {
                case "³²±Ã":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("³²±Ã¼¼°¡·çÆ®³ª°¡±â");
                    
                    break;
                case "¸¶±³":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("ÀÏ¿ùÃµ¸¶½Å±³·çÆ®³ª°¡±â");
                    
                    break;
                case "ºù±Ã":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("ºÏÇØºù±Ã·çÆ®³ª°¡±â");
                    
                    break;
                case "Ç÷±³":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("Ç÷Ãµ¼ö¶ó±³·çÆ®³ª°¡±â");
                    
                    break;
            }
        }
    }
    IEnumerator invokeTimes()
    {
        yield return new WaitForSeconds(10f);
    }


}

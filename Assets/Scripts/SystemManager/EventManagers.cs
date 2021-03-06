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
        if (target != null)
        {
            if (systemManager.DB.isEvent)
            {
                switch (target.GetComponent<PlayerMove>().eventKinds)
                {
                    case "남궁":
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            Debug.Log("남궁세가선택");
                            target.GetComponent<PlayerMove>().eventKinds = null;
                            systemManager.DB.isEvent = false;
                            PlayerDB.Instance.DB.KINDS = "남궁";
                            PlayerDB.Instance.DB.Xskill_Attack = PlayerDataBass.XSKILL_ATTACK.X_2004;
                            PlayerDB.Instance.DB.Cskill_Attack = PlayerDataBass.CSKILL_ATTACK.C_2004;
                            PlayerDB.Instance.DB.Vskill_Attack = PlayerDataBass.VSKILL_ATTACK.V_2004;
                        }
                        break;
                    case "마교":
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            Debug.Log("일월천마신교선택");
                            target.GetComponent<PlayerMove>().eventKinds = null;
                            systemManager.DB.isEvent = false;
                            PlayerDB.Instance.DB.KINDS = "마교";
                            PlayerDB.Instance.DB.Xskill_Attack = PlayerDataBass.XSKILL_ATTACK.X_2001;
                            PlayerDB.Instance.DB.Cskill_Attack = PlayerDataBass.CSKILL_ATTACK.C_2001;
                            PlayerDB.Instance.DB.Vskill_Attack = PlayerDataBass.VSKILL_ATTACK.V_2001;
                        }
                        break;
                    case "빙궁":
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            Debug.Log("북해빙궁선택");
                            target.GetComponent<PlayerMove>().eventKinds = null;
                            systemManager.DB.isEvent = false;
                            PlayerDB.Instance.DB.KINDS = "빙궁";
                            PlayerDB.Instance.DB.Xskill_Attack = PlayerDataBass.XSKILL_ATTACK.X_2003;
                            PlayerDB.Instance.DB.Cskill_Attack = PlayerDataBass.CSKILL_ATTACK.C_2003;
                            PlayerDB.Instance.DB.Vskill_Attack = PlayerDataBass.VSKILL_ATTACK.V_2003;
                        }
                        break;
                    case "혈교":
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            Debug.Log("혈천수라교선택");
                            target.GetComponent<PlayerMove>().eventKinds = null;
                            systemManager.DB.isEvent = false;
                            PlayerDB.Instance.DB.KINDS = "혈교";
                            PlayerDB.Instance.DB.Xskill_Attack = PlayerDataBass.XSKILL_ATTACK.X_2002;
                            PlayerDB.Instance.DB.Cskill_Attack = PlayerDataBass.CSKILL_ATTACK.C_2002;
                            PlayerDB.Instance.DB.Vskill_Attack = PlayerDataBass.VSKILL_ATTACK.V_2002;
                        }
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
                case "튜토리얼":
                    if (systemManager.DB.isTutorial)
                    {
                        Debug.Log("튜토리얼");
                        Showdialogue.startDI();
                    }
                    break;
                case "남궁":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;

                    systemManager.DB.isEvent = true;
                    Debug.Log("남궁세가루트");

                    break;
                case "마교":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;

                    systemManager.DB.isEvent = true;
                    Debug.Log("일월천마신교루트");

                    break;
                case "빙궁":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;

                    systemManager.DB.isEvent = true;
                    Debug.Log("북해빙궁루트");

                    break;
                case "혈교":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;
                    systemManager.DB.isEvent = true;
                    Debug.Log("혈천수라교루트");

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
                case "직업선택":
                    if (systemManager.DB.isJob)
                    {
                        StartCoroutine(invokeTimes());
                        Debug.Log("직업선택");
                        mapdb.DB.mapNum = 0;
                        mapdb.DB.Player.position = mapdb.DB.home.transform.position;
                        Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.home.transform.position.y + 3f, Camera.main.transform.position.z);
                        mapdb.minmap.transform.position = new Vector3(mapdb.minmapPos[0].transform.position.x, mapdb.minmapPos[0].transform.position.y, -25.0f);
                        mapdb.fadeMap();
                        for (int i = 0; i < jobPotall.Length; i++)
                        {
                            if (i == jobPotall.Length) { break; }
                            jobPotall[i].SetActive(true);
                        }
                        //Showdialogue.startDI();
                    }
                    break;
                #region 세력선택 안된부분
                //case "남궁":
                //    if (Input.GetKeyDown(KeyCode.Z))
                //    {
                //        Debug.Log("남궁세가선택");
                //    }
                //    break;
                //case "마교":
                //    if (Input.GetKeyDown(KeyCode.Z))
                //    {
                //        Debug.Log("일월천마신교선택");
                //    }
                //    break;
                //case "빙궁":
                //    if (Input.GetKeyDown(KeyCode.Z))
                //    {
                //        Debug.Log("북해빙궁선택");
                //    }
                //    break;
                //case "혈교":
                //    if (Input.GetKeyDown(KeyCode.Z))
                //    {
                //        Debug.Log("혈천수라교선택");
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
                case "남궁":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("남궁세가루트나가기");

                    break;
                case "마교":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("일월천마신교루트나가기");

                    break;
                case "빙궁":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("북해빙궁루트나가기");

                    break;
                case "혈교":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("혈천수라교루트나가기");

                    break;
            }
        }
    }
    IEnumerator invokeTimes()
    {
        yield return new WaitForSeconds(10f);
    }


}

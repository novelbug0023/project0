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
                    case "����":
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            Debug.Log("���ü�������");
                            target.GetComponent<PlayerMove>().eventKinds = null;
                            systemManager.DB.isEvent = false;
                            PlayerDB.Instance.DB.KINDS = "����";
                            PlayerDB.Instance.DB.Xskill_Attack = PlayerDataBass.XSKILL_ATTACK.X_2004;
                            PlayerDB.Instance.DB.Cskill_Attack = PlayerDataBass.CSKILL_ATTACK.C_2004;
                            PlayerDB.Instance.DB.Vskill_Attack = PlayerDataBass.VSKILL_ATTACK.V_2004;
                        }
                        break;
                    case "����":
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            Debug.Log("�Ͽ�õ���ű�����");
                            target.GetComponent<PlayerMove>().eventKinds = null;
                            systemManager.DB.isEvent = false;
                            PlayerDB.Instance.DB.KINDS = "����";
                            PlayerDB.Instance.DB.Xskill_Attack = PlayerDataBass.XSKILL_ATTACK.X_2001;
                            PlayerDB.Instance.DB.Cskill_Attack = PlayerDataBass.CSKILL_ATTACK.C_2001;
                            PlayerDB.Instance.DB.Vskill_Attack = PlayerDataBass.VSKILL_ATTACK.V_2001;
                        }
                        break;
                    case "����":
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            Debug.Log("���غ��ü���");
                            target.GetComponent<PlayerMove>().eventKinds = null;
                            systemManager.DB.isEvent = false;
                            PlayerDB.Instance.DB.KINDS = "����";
                            PlayerDB.Instance.DB.Xskill_Attack = PlayerDataBass.XSKILL_ATTACK.X_2003;
                            PlayerDB.Instance.DB.Cskill_Attack = PlayerDataBass.CSKILL_ATTACK.C_2003;
                            PlayerDB.Instance.DB.Vskill_Attack = PlayerDataBass.VSKILL_ATTACK.V_2003;
                        }
                        break;
                    case "����":
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            Debug.Log("��õ���󱳼���");
                            target.GetComponent<PlayerMove>().eventKinds = null;
                            systemManager.DB.isEvent = false;
                            PlayerDB.Instance.DB.KINDS = "����";
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
                case "Ʃ�丮��":
                    if (systemManager.DB.isTutorial)
                    {
                        Debug.Log("Ʃ�丮��");
                        Showdialogue.startDI();
                    }
                    break;
                case "����":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;

                    systemManager.DB.isEvent = true;
                    Debug.Log("���ü�����Ʈ");

                    break;
                case "����":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;

                    systemManager.DB.isEvent = true;
                    Debug.Log("�Ͽ�õ���ű���Ʈ");

                    break;
                case "����":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;

                    systemManager.DB.isEvent = true;
                    Debug.Log("���غ��÷�Ʈ");

                    break;
                case "����":
                    target = collision.gameObject;
                    target.GetComponent<PlayerMove>().eventKinds = this.gameObject.GetComponent<EventManagers>().envent_Name;
                    systemManager.DB.isEvent = true;
                    Debug.Log("��õ���󱳷�Ʈ");

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
                case "��������":
                    if (systemManager.DB.isJob)
                    {
                        StartCoroutine(invokeTimes());
                        Debug.Log("��������");
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
                #region ���¼��� �ȵȺκ�
                //case "����":
                //    if (Input.GetKeyDown(KeyCode.Z))
                //    {
                //        Debug.Log("���ü�������");
                //    }
                //    break;
                //case "����":
                //    if (Input.GetKeyDown(KeyCode.Z))
                //    {
                //        Debug.Log("�Ͽ�õ���ű�����");
                //    }
                //    break;
                //case "����":
                //    if (Input.GetKeyDown(KeyCode.Z))
                //    {
                //        Debug.Log("���غ��ü���");
                //    }
                //    break;
                //case "����":
                //    if (Input.GetKeyDown(KeyCode.Z))
                //    {
                //        Debug.Log("��õ���󱳼���");
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
                case "����":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("���ü�����Ʈ������");

                    break;
                case "����":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("�Ͽ�õ���ű���Ʈ������");

                    break;
                case "����":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("���غ��÷�Ʈ������");

                    break;
                case "����":
                    target.GetComponent<PlayerMove>().eventKinds = null;
                    target = null;
                    systemManager.DB.isEvent = false;
                    Debug.Log("��õ���󱳷�Ʈ������");

                    break;
            }
        }
    }
    IEnumerator invokeTimes()
    {
        yield return new WaitForSeconds(10f);
    }


}

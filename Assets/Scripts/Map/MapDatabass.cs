using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MapDB
{
    public Transform Player;
    public Transform home;
    public Transform[] spwan;
    public Transform[] leatelebosssspwan;
    public Transform[] bossspwan;
    public Transform[] falststoypos;
    public GameObject[] map;
    public int SpwanNum;
    public int mapNum;
    public int mapLevel = 0;
}
public class MapDatabass : MonoBehaviour
{
    
    public MapDB DB;
    public Camera minmap;
    public Transform[] minmapPos;

    //#region ½Ì±ÛÅæ
    //private static MapDatabass instance = null;
    //void Awake()
    //{
    //    if (null == instance)
    //    {
    //        instance = this;

    //        DontDestroyOnLoad(this.gameObject);
    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}

    //public static MapDatabass Instance
    //{
    //    get
    //    {
    //        if (null == instance)
    //        {
    //            return null;
    //        }
    //        return instance;
    //    }
    //}


    //#endregion

    void Start()
    {
        DB.mapNum = 0;
        fadeMap();
    }
    public void fadeMap()
    {
        for (int i = 0; i < DB.map.Length; i++)
        {
            DB.map[i].SetActive(false);
        }
        DB.map[DB.mapNum].SetActive(true);
    }
    public void SpwanPlayer()
    {
        Debug.Log("¸Ê·»´ý ÀÌµ¿");
        if (DB.SpwanNum == 0)
        {
            DB.mapNum = 1;
            Debug.Log("¸Ê·»´ý ÀÌµ¿1");
            DB.Player.position = DB.spwan[0].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, DB.spwan[0].transform.position.y + 3f, Camera.main.transform.position.z);
            minmap.transform.position = new Vector3(minmapPos[1].transform.position.x, minmapPos[1].transform.position.y, -25.0f);
            fadeMap();
        }
        if (DB.SpwanNum == 1)
        {
            DB.mapNum = 2;
            Debug.Log("¸Ê·»´ý ÀÌµ¿2");
            DB.Player.position = DB.spwan[1].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, DB.spwan[1].transform.position.y + 3f, Camera.main.transform.position.z);
            minmap.transform.position = new Vector3(minmapPos[2].transform.position.x, minmapPos[2].transform.position.y, -25.0f);
            fadeMap();
        }
        if (DB.SpwanNum == 2)
        {
            DB.mapNum = 3;
            Debug.Log("¸Ê·»´ý ÀÌµ¿3");
            DB.Player.position = DB.spwan[2].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, DB.spwan[2].transform.position.y + 3f, Camera.main.transform.position.z);
            minmap.transform.position = new Vector3(minmapPos[3].transform.position.x, minmapPos[3].transform.position.y,-25.0f);
            fadeMap();
        }
        if (DB.SpwanNum == 3)
        {
            DB.mapNum = 4;
            Debug.Log("¸Ê·»´ý ÀÌµ¿4");
            DB.Player.position = DB.spwan[3].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, DB.spwan[3].transform.position.y + 3f, Camera.main.transform.position.z);
            minmap.transform.position = new Vector3(minmapPos[4].transform.position.x, minmapPos[4].transform.position.y, -25.0f);
            fadeMap();
        }
        if (DB.SpwanNum == 4)
        {
            DB.mapNum = 5;
            Debug.Log("¸Ê·»´ý ÀÌµ¿5");
            DB.Player.position = DB.spwan[4].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, DB.spwan[4].transform.position.y + 3f, Camera.main.transform.position.z);
            minmap.transform.position = new Vector3(minmapPos[5].transform.position.x, minmapPos[5].transform.position.y, -25.0f);
            fadeMap();
        }
        
    }
    public void homePlayer()
    {
        DB.mapNum = 0;
        Debug.Log("±¤Àå ÀÌµ¿");
        DB.Player.position = DB.home.transform.position;
        //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
        //Camera.main.transform.position = new Vector3(DB.home.transform.position.x, DB.home.transform.position.y, -17.0f);
        Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, DB.home.transform.position.y + 3f, Camera.main.transform.position.z);
        minmap.transform.position = new Vector3(minmapPos[0].transform.position.x, minmapPos[0].transform.position.y, -25.0f);
        fadeMap();
    }
}

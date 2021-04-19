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
    public int SpwanNum;
    public int mapLevel = 0;
}
public class MapDatabass : MonoBehaviour
{
    public MapDB DB;

    #region ½Ì±ÛÅæ
    private static MapDatabass instance = null;
    void Awake()
    {
        if (null == instance)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static MapDatabass Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }


    #endregion

    public void SpwanPlayer()
    {
        Debug.Log("¸Ê·»´ý ÀÌµ¿");
        if (DB.SpwanNum == 0)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿1");
           DB.Player.position = DB.spwan[0].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.transform.position = new Vector3(DB.spwan[0].transform.position.x, DB.spwan[0].transform.position.y, -17.0f);
        }
        if (DB.SpwanNum == 1)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿2");
            DB.Player.position = DB.spwan[1].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.transform.position = new Vector3(DB.spwan[1].transform.position.x,DB.spwan[1].transform.position.y, -17.0f);
        }
        if (DB.SpwanNum == 2)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿3");
            DB.Player.position = DB.spwan[2].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.transform.position = new Vector3(DB.spwan[2].transform.position.x, MapDatabass.Instance.DB.spwan[2].transform.position.y, -17.0f);
        }
        if (DB.SpwanNum == 3)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿4");
            DB.Player.position = DB.spwan[3].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.transform.position = new Vector3(DB.spwan[3].transform.position.x,DB.spwan[3].transform.position.y, -17.0f);
        }
        if (DB.SpwanNum == 4)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿5");
            DB.Player.position = DB.spwan[4].transform.position;
            //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
            Camera.main.transform.position = new Vector3(DB.spwan[4].transform.position.x, DB.spwan[4].transform.position.y, -17.0f);
        }
        
    }
    public void homePlayer()
    {
        Debug.Log("±¤Àå ÀÌµ¿");
        DB.Player.position = DB.home.transform.position;
        //Camera.main.transform.position = MapDatabass.Instance.DB.spwan[0].transform.position;
        Camera.main.transform.position = new Vector3(DB.home.transform.position.x, DB.home.transform.position.y, -17.0f);
    }
}

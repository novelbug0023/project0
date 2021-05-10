using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpwonEnemyDB
{
    public List<GameObject> falstEnemy = new List<GameObject>();
    public List<GameObject> mapEnemy = new List<GameObject>();
    //기본 적
    public GameObject[] Enemy;
    //기본 적2
    public GameObject[] Enemy2;
    //중간보스
    public GameObject[] letelbossEnemy;
    //스테이지보스
    public GameObject[] bossEnemy;

    //기본1
    public Transform[] EnemySpwonPOS;
    //기본2
    public Transform[] EnemySpwonPOS2;
    public Transform EnemyPOS;
        
}
public class SpwonEnemy : MonoBehaviour
{
    public SpwonEnemyDB DB;
    public MapDatabass mapdb;
    //#region 싱글톤
    //private static SpwonEnemy instance = null;
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

    //public static SpwonEnemy Instance
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

    private void Start()
    {
        mapdb = GameObject.FindGameObjectWithTag("MapDB").GetComponent<MapDatabass>();
        fadeEnemyout();

    }
    void fadeEnemyout()
    {
        for (int i = 0; i < DB.falstEnemy.Count; i++)
        {
            if (i == DB.falstEnemy.Count) { break; }
            DB.falstEnemy[i].SetActive(false);
        }
    }
    public void fadeEnemyIn()
    {
        for (int i = 0; i < DB.falstEnemy.Count; i++)
        {
            if (i == DB.falstEnemy.Count) { break; }
            DB.falstEnemy[i].SetActive(true);
        }
    }
    public void spwonEnemys()
    {
        StartCoroutine(spownTime());
        
    }
    IEnumerator spownTime()
    {
        if (mapdb.DB.SpwanNum == 0)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("스폰적1");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[0].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS[0].parent*/));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[0].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS2[0].parent*/));
            }
        }
        if (mapdb.DB.SpwanNum == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("스폰적2");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[1].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS[1].parent*/));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[1].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS2[1].parent*/));
            }
        }
        if (mapdb.DB.SpwanNum == 2)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("스폰적3");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[2].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS[2].parent*/));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[2].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS2[2].parent*/));
            }
        }
        if (mapdb.DB.SpwanNum == 3)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("스폰적4");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[3].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS[3].parent*/));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[3].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS2[3].parent*/));
            }
        }
        if (mapdb.DB.SpwanNum == 4)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("스폰적4");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[4].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS[4].parent*/));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[4].transform.position, Quaternion.identity/*, DB.EnemySpwonPOS2[4].parent*/));
            }
        }
    }

}

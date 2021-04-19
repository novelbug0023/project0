using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpwonEnemyDB
{
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

    #region 싱글톤
    private static SpwonEnemy instance = null;
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

    public static SpwonEnemy Instance
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
    public void spwonEnemys()
    {
        
        if (MapDatabass.Instance.DB.mapLevel == 1)
        {
            if (MapDatabass.Instance.DB.SpwanNum == 1)
            {
                for (int i = 0; i < 9; i++)
                {
                    Debug.Log("스폰적1");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[1].transform.position, Quaternion.identity, DB.EnemySpwonPOS[1].parent));
                    //DB.mapEnemy[i] = Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[1].transform.position, Quaternion.identity, DB.EnemySpwonPOS[1].parent);
                }
            }
            if (MapDatabass.Instance.DB.SpwanNum == 2)
            {
                for (int i = 0; i < 9; i++)
                {
                    Debug.Log("스폰적2");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[2].transform.position, Quaternion.identity, DB.EnemySpwonPOS[2].parent));
                }
            }
            if (MapDatabass.Instance.DB.SpwanNum == 3)
            {
                for (int i = 0; i < 9; i++)
                {
                    Debug.Log("스폰적3");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[3].transform.position, Quaternion.identity, DB.EnemySpwonPOS[3].parent));
                }
            }
            if (MapDatabass.Instance.DB.SpwanNum == 4)
            {
                for (int i = 0; i < 9; i++)
                {
                    Debug.Log("스폰적4");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[4].transform.position, Quaternion.identity, DB.EnemySpwonPOS[4].parent));
                }
            }
            if (MapDatabass.Instance.DB.SpwanNum == 5)
            {
                for (int i = 0; i < 9; i++)
                {
                    Debug.Log("스폰적4");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[5].transform.position, Quaternion.identity, DB.EnemySpwonPOS[5].parent));
                }
            }
        }

    }
}

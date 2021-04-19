using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpwonEnemyDB
{
    public List<GameObject> mapEnemy = new List<GameObject>();
    //�⺻ ��
    public GameObject[] Enemy;
    //�⺻ ��2
    public GameObject[] Enemy2;
    //�߰�����
    public GameObject[] letelbossEnemy;
    //������������
    public GameObject[] bossEnemy;

    //�⺻1
    public Transform[] EnemySpwonPOS;
    //�⺻2
    public Transform[] EnemySpwonPOS2;
    public Transform EnemyPOS;
        
}
public class SpwonEnemy : MonoBehaviour
{
    public SpwonEnemyDB DB;

    #region �̱���
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
                    Debug.Log("������1");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[1].transform.position, Quaternion.identity, DB.EnemySpwonPOS[1].parent));
                    //DB.mapEnemy[i] = Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[1].transform.position, Quaternion.identity, DB.EnemySpwonPOS[1].parent);
                }
            }
            if (MapDatabass.Instance.DB.SpwanNum == 2)
            {
                for (int i = 0; i < 9; i++)
                {
                    Debug.Log("������2");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[2].transform.position, Quaternion.identity, DB.EnemySpwonPOS[2].parent));
                }
            }
            if (MapDatabass.Instance.DB.SpwanNum == 3)
            {
                for (int i = 0; i < 9; i++)
                {
                    Debug.Log("������3");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[3].transform.position, Quaternion.identity, DB.EnemySpwonPOS[3].parent));
                }
            }
            if (MapDatabass.Instance.DB.SpwanNum == 4)
            {
                for (int i = 0; i < 9; i++)
                {
                    Debug.Log("������4");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[4].transform.position, Quaternion.identity, DB.EnemySpwonPOS[4].parent));
                }
            }
            if (MapDatabass.Instance.DB.SpwanNum == 5)
            {
                for (int i = 0; i < 9; i++)
                {
                    Debug.Log("������4");
                    DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[5].transform.position, Quaternion.identity, DB.EnemySpwonPOS[5].parent));
                }
            }
        }

    }
}

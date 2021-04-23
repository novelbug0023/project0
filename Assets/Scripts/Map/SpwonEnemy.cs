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
        StartCoroutine(spownTime());
        
    }
    IEnumerator spownTime()
    {
        if (MapDatabass.Instance.DB.SpwanNum == 0)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("������1");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[0].transform.position, Quaternion.identity, DB.EnemySpwonPOS[0].parent));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[0].transform.position, Quaternion.identity, DB.EnemySpwonPOS2[0].parent));
            }
        }
        if (MapDatabass.Instance.DB.SpwanNum == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("������2");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[1].transform.position, Quaternion.identity, DB.EnemySpwonPOS[1].parent));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[1].transform.position, Quaternion.identity, DB.EnemySpwonPOS2[1].parent));
            }
        }
        if (MapDatabass.Instance.DB.SpwanNum == 2)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("������3");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[2].transform.position, Quaternion.identity, DB.EnemySpwonPOS[2].parent));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[2].transform.position, Quaternion.identity, DB.EnemySpwonPOS2[2].parent));
            }
        }
        if (MapDatabass.Instance.DB.SpwanNum == 3)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("������4");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[3].transform.position, Quaternion.identity, DB.EnemySpwonPOS[3].parent));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[3].transform.position, Quaternion.identity, DB.EnemySpwonPOS2[3].parent));
            }
        }
        if (MapDatabass.Instance.DB.SpwanNum == 4)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("������4");
                yield return new WaitForSeconds(2f);
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS[4].transform.position, Quaternion.identity, DB.EnemySpwonPOS[4].parent));
                DB.mapEnemy.Add(Instantiate(DB.Enemy[0], DB.EnemySpwonPOS2[4].transform.position, Quaternion.identity, DB.EnemySpwonPOS2[4].parent));
            }
        }
    }

}

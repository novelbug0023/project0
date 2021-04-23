using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int hp = 100;
    public int Maxhp = 100;
    public int AttackPoint;

    #region ΩÃ±€≈Ê
    private static EnemyManager instance = null;
    public static EnemyManager Instance
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
            SpwonEnemy.Instance.DB.mapEnemy.Remove(this.gameObject);
        }
    }
}

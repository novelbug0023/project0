using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public SpwonEnemy Spwonenemy;
    public int hp = 100;
    public int Maxhp = 100;
    public int AttackPoint;
    public Image hpBar;
    public SystemManager systemManager;
    //#region ΩÃ±€≈Ê
    //private static EnemyManager instance = null;
    //public static EnemyManager Instance
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
    // Start is called before the first frame update
    void Start()
    {
        Spwonenemy = GameObject.FindGameObjectWithTag("MapDB").GetComponent<SpwonEnemy>();
        systemManager = GameObject.FindGameObjectWithTag("SystemManager").GetComponent<SystemManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            if (systemManager.DB.isFirst_story)
            {
                Destroy(this.gameObject);
                Spwonenemy.DB.falstEnemy.Remove(this.gameObject);
                if (Spwonenemy.DB.falstEnemy.Count <= 0)
                {
                    systemManager.DB.isFirst_story = false;
                    systemManager.DB.isJob = true;
                }
            }
            else
            {
                Destroy(this.gameObject);
                Spwonenemy.DB.mapEnemy.Remove(this.gameObject);
                
            }
        }
    }
}

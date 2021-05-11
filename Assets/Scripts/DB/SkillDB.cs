using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillDB : MonoBehaviour
{
    public Attack attack;
    public PlayerMove player;
    public PlayerDB DB;
    public int damage;
    //public PlayerDataBass PDB;
    void Start()
    {
        DB = GameObject.FindGameObjectWithTag("PlayerDB").GetComponent<PlayerDB>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        attack = GameObject.FindGameObjectWithTag("Player").GetComponent<Attack>();
        //PDB = GameObject.FindGameObjectWithTag("PlayerDB").GetComponent<PlayerDataBass>();
    }
    public void XskillKinds()
    {
        switch (DB.DB.Xskill_Attack)
        {
            case PlayerDataBass.XSKILL_ATTACK.X_2001:
                Debug.Log("X��ư �⺻�����ǹ�");
                damage = 20;
                AttackAnime();
                break;
            case PlayerDataBass.XSKILL_ATTACK.X_2002:
                Debug.Log("X��ư �⺻�������ǹ�");
                damage = 20;
                AttackAnime();
                break;
            case PlayerDataBass.XSKILL_ATTACK.X_2003:
                Debug.Log("X��ư �⺻�����ǹ�");
                damage = 20;
                AttackAnime();
                break;
            case PlayerDataBass.XSKILL_ATTACK.X_2004:
                Debug.Log("X��ư �⺻�����ǹ�");
                damage = 20;
                AttackAnime();
                break;
            case PlayerDataBass.XSKILL_ATTACK.X_2005:
                Debug.Log("X��ư �⺻�ǹ�");
                damage = 15;
                AttackAnime();
                break;
        }
    }
    public void CskillKinds()
    {
        switch (DB.DB.Cskill_Attack)
        {
            case PlayerDataBass.CSKILL_ATTACK.C_2001:
                Debug.Log("C��ư �⺻��������");
                damage = 20;
                AttackAnime();
                break;
            case PlayerDataBass.CSKILL_ATTACK.C_2002:
                Debug.Log("C��ư �⺻����������");
                damage = 20;
                AttackAnime();
                break;
            case PlayerDataBass.CSKILL_ATTACK.C_2003:
                Debug.Log("C��ư �⺻��������");
                damage = 20;
                AttackAnime();
                break;
            case PlayerDataBass.CSKILL_ATTACK.C_2004:
                Debug.Log("C��ư �⺻��������");
                damage = 20;
                AttackAnime();
                break;
            case PlayerDataBass.CSKILL_ATTACK.C_2005:
                Debug.Log("C��ư �⺻����");
                damage = 15;
                AttackAnime();
                break;
        }
    }
    public void VskillKinds()
    {
        switch (DB.DB.Vskill_Attack)
        {
            case PlayerDataBass.VSKILL_ATTACK.V_2001:
                Debug.Log("V��ư �⺻�����˹�");
                damage = 25;
                AttackAnime();
                break;
            case PlayerDataBass.VSKILL_ATTACK.V_2002:
                Debug.Log("V��ư �⺻�������˹�");
                damage = 25;
                AttackAnime();
                break;
            case PlayerDataBass.VSKILL_ATTACK.V_2003:
                Debug.Log("V��ư �⺻�����˹�");
                damage = 25;
                AttackAnime();
                break;
            case PlayerDataBass.VSKILL_ATTACK.V_2004:
                Debug.Log("V��ư �⺻�����˹�");
                damage = 25;
                AttackAnime();
                break;
            case PlayerDataBass.VSKILL_ATTACK.V_2005:
                Debug.Log("V��ư �⺻�˹�");
                damage = 20;
                AttackAnime();
                break;
        }
    }
    public void AttackAnime()
    {
        if (attack.isEnemyAttack)
        {
            if (attack.target != null)
            {
                Debug.Log("���� �¾Ҵ�" + damage);
                attack.target.gameObject.GetComponent<EnemyManager>().hp -= damage;
                attack.target.gameObject.GetComponent<EnemyManager>().hpBar.fillAmount = (float)attack.target.gameObject.GetComponent<EnemyManager>().hp / (float)attack.target.gameObject.GetComponent<EnemyManager>().Maxhp;
                attack.target.gameObject.GetComponent<EnemyMove>().isTurn = !player.GetComponent<PlayerMove>().isTurn;
                attack.target.gameObject.GetComponent<EnemyMove>().GetComponent<SpriteRenderer>().flipX = !player.GetComponent<PlayerMove>().GetComponent<SpriteRenderer>().flipX;
                attack.target.gameObject.GetComponent<EnemyMove>().state = EnemyMove.Enemystate.attack;
                attack.target.gameObject.GetComponent<EnemyMove>().moveNum = 0;
                attack.target.gameObject.GetComponent<EnemyMove>().enemyAnime.SetBool("move", false); ;
            }

        }
        else
        {
            return;
        }

    }
}

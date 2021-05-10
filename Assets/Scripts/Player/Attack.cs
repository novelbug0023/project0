using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator myAttackaim;
    public bool isEnemyAttack = false;
    public GameObject target;
    public LayerMask EnemyLayer;
    public enum PlayerKinds
    {
        a, b, c, d, e, f, g
    };
    public PlayerKinds playerKinds;
    // Start is called before the first frame update
    void Start()
    {
        myAttackaim = this.GetComponentInParent<Animator>();
    }

    
    // Update is called once per frame
    void Update()
    {
        attack();
        if (this.GetComponent<PlayerMove>().systemManager.DB.isEvent == false)
        {
            if (Input.GetKeyDown(KeyCode.Z))//�⺻����
            {
                Debug.Log("����");
                switch (playerKinds)
                {
                    case PlayerKinds.a:
                        Debug.Log("�����⺻����");
                        AttackAnime();
                        break;
                    case PlayerKinds.b:
                        Debug.Log("��α⺻����");
                        AttackAnime();
                        break;
                    case PlayerKinds.c:
                        Debug.Log("���ü����⺻����");
                        AttackAnime();
                        break;
                    case PlayerKinds.d:
                        Debug.Log("���غ����⺻����");
                        AttackAnime();
                        break;
                    case PlayerKinds.e:
                        Debug.Log("�����⺻����");
                        AttackAnime();
                        break;
                    case PlayerKinds.f:
                        Debug.Log("�����⺻����");
                        AttackAnime();
                        break;
                    case PlayerKinds.g:
                        Debug.Log("�⺻����");
                        AttackAnime();
                        break;
                }
            }
        }
    }
    void attack()
    {
        
        if (this.GetComponent<PlayerMove>().isTurn == true)
        {
            Ray2D ray = new Ray2D(this.transform.position, Vector2.left);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 1.9f, EnemyLayer);
            Debug.DrawRay(this.transform.position, Vector2.left, Color.red);
            if (hit.collider != null)
            {
                Debug.Log("���Ϳ� ��Ҵ�.");
                this.GetComponentInParent<PlayerMove>().enemyCount++;
                target = hit.collider.gameObject;
                isEnemyAttack = true;
                //enemy.GetComponent<SpriteRenderer>().flipX = false;
                //isTurn = false;
            }
            else
            {
                if (target == null) { return; }
                else
                {
                    Debug.Log("���Ͱ� �����.");
                    if (this.GetComponentInParent<PlayerMove>().enemyCount <= 0) { return; }
                    else { this.GetComponentInParent<PlayerMove>().enemyCount--; }
                    target = null;
                    isEnemyAttack = false;
                }
            }
        }
        else if (this.GetComponent<PlayerMove>().isTurn == false)
        {
            Ray2D ray = new Ray2D(this.transform.position, Vector2.right);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 1.9f, EnemyLayer);
            Debug.DrawRay(this.transform.position, Vector2.right, Color.red);
            if (hit.collider != null)
            {
                Debug.Log("���Ϳ� ��Ҵ�.");
                this.GetComponentInParent<PlayerMove>().enemyCount++;
                target = hit.collider.gameObject;
                isEnemyAttack = true;
                //enemy.GetComponent<SpriteRenderer>().flipX = false;
                //isTurn = false;
            }
            else
            {
                if (target == null) { return; }
                else
                {
                    Debug.Log("���Ͱ� �����.");
                    if (this.GetComponentInParent<PlayerMove>().enemyCount <= 0) { return; }
                    else { this.GetComponentInParent<PlayerMove>().enemyCount--; }

                    target = null;
                    isEnemyAttack = false;
                }
            }
        }
    }
    public void AttackAnime()
    {
        if (isEnemyAttack)
        {
            if (target != null)
            {
                Debug.Log("���� �¾Ҵ�" + PlayerDB.Instance.DB.AttackPint);
                target.gameObject.GetComponent<EnemyManager>().hp -= PlayerDB.Instance.DB.AttackPint;
                target.gameObject.GetComponent<EnemyManager>().hpBar.fillAmount = (float)target.gameObject.GetComponent<EnemyManager>().hp / (float)target.gameObject.GetComponent<EnemyManager>().Maxhp;
                target.gameObject.GetComponent<EnemyMove>().isTurn = !this.gameObject.GetComponent<PlayerMove>().isTurn;
                target.gameObject.GetComponent<EnemyMove>().GetComponent<SpriteRenderer>().flipX = !this.gameObject.GetComponent<PlayerMove>().GetComponent<SpriteRenderer>().flipX;
                target.gameObject.GetComponent<EnemyMove>().state = EnemyMove.Enemystate.attack;
                target.gameObject.GetComponent<EnemyMove>().moveNum = 0;
                target.gameObject.GetComponent<EnemyMove>().enemyAnime.SetBool("move", false); ;
            }
            
        }
        else
        {
            return;
        }

    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        Debug.Log("Ÿ��"+collision.gameObject.name);
    //        this.GetComponentInParent<PlayerMove>().enemyCount++;
    //        target = collision.gameObject;
    //        isEnemyAttack = true;
    //        //target.gameObject.GetComponent<EnemyMove>().isplayer = true;
    //        //target.gameObject.GetComponent<EnemyMove>().Playertarget = this.gameObject.transform;
    //    }
    //}
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        isEnemyAttack = false;
    //    }
    //}
}

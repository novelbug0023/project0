using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform PlayerPOS;
    public Rigidbody2D playerRigd;
    public SpriteRenderer player;
    public float PlayerSpeed = 10.0f;
    public float JumpFowar = 5.0f;
    public bool isjumping = false;
    public int JumpCount = 0;
    public bool isEnemyAttack = false;
    public GameObject target;
    public enum PlayerKinds
    {
        a, b, c, d, e, f, g
    }
    public PlayerKinds playerKinds;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float delta = PlayerSpeed * Time.deltaTime;

            player.flipX = false;

            PlayerPOS.Translate(PlayerPOS.right * delta);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            float delta = PlayerSpeed * Time.deltaTime;

            player.flipX = true;

            PlayerPOS.Translate(-PlayerPOS.right * delta);


        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (JumpCount >= 2)
            {
                isjumping = false;


                return;

            }
            else
            {
                playerRigd.AddForce(Vector2.up * JumpFowar, ForceMode2D.Impulse);
                isjumping = true;
                JumpCount++;
            }

        }
        if (Input.GetKeyDown(KeyCode.Z))//기본공격
        {
            Debug.Log("공격");
            switch (playerKinds)
            {
                case PlayerKinds.a:
                    Debug.Log("거지기본공격");
                    Attack();
                    break;
                case PlayerKinds.b:
                    Debug.Log("평민기본공격");
                    Attack();
                    break;
                case PlayerKinds.c:
                    Debug.Log("남궁세가기본공격");
                    Attack();
                    break;
                case PlayerKinds.d:
                    Debug.Log("북해빙공기본공격");
                    Attack();
                    break;
                case PlayerKinds.e:
                    Debug.Log("마교기본공격");
                    Attack();
                    break;
                case PlayerKinds.f:
                    Debug.Log("혈교기본공격");
                    Attack();
                    break;
                case PlayerKinds.g:
                    Debug.Log("기본공격");
                    Attack();
                    break;
            }
        }
        kinds();
    }
    public void kinds()
    {
        switch (PlayerDB.Instance.DB.KINDS)
        {
            case "거지":
                playerKinds = PlayerKinds.a;
                break;
            case "평민":
                playerKinds = PlayerKinds.b;
                break;
            case "남궁":
                playerKinds = PlayerKinds.c;
                break;
            case "북해":
                playerKinds = PlayerKinds.d;
                break;
            case "마교":
                playerKinds = PlayerKinds.e;
                break;
            case "혈교":
                playerKinds = PlayerKinds.f;
                break;
            case "":

                break;
        }
    }
    public void Attack()
    {
        if (isEnemyAttack)
        {
            Debug.Log("적이 맞았다");
            target.gameObject.GetComponent<EnemyManager>().hp -= PlayerDB.Instance.DB.AttackPint;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isjumping = false;
            JumpCount = 0;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isEnemyAttack = true;
            target = collision.gameObject;
            target.gameObject.GetComponent<EnemyMove>().isplayer = true;
            target.gameObject.GetComponent<EnemyMove>().Playertarget = this.gameObject.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isEnemyAttack = false;
        }
    }
    
}


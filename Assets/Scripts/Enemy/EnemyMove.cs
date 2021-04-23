using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    #region 실패
    /*
    public Transform enemy;
    public Transform Playertarget;
    public Transform ground;
    SpriteRenderer enemySprite;
    public float right;
    public float left;
    public bool isplayer;
    public float speed = 5.0f;
    public Vector2 StartPos;
    public Vector2 thisEnemy;
    public bool isTurn = false;
    public float Dir;
    public int enemyCount;
    public bool isplayerEnemy = false;
    public enum state
    {
        idle,attack,jump
    }
    public state enemyState = state.idle;
    // Start is called before the first frame update
    void Start()
    {
        enemy = this.GetComponent<Transform>();
        enemySprite = this.GetComponent<SpriteRenderer>();
        StartPos = this.transform.position;
        ground = GameObject.FindGameObjectWithTag("Ground").GetComponent<Transform>();
    }
    float a = 1;
    // Update is called once per frame
    void Update()
    {
        stateKind();
    }
    public void stateKind()
    {
        switch (enemyState)
        {
            case state.idle:
                move();
                break;
            case state.attack:
                attack();
                break;
            case state.jump:
                jump();
                break;
        }
    }
    //IEnumerator EnemyMovefor()
    //{
    //    //Debug.Log("왼쪽");
    //    yield return new WaitForSeconds(3);
    //    enemySprite.flipX = true;
    //    float delta = speed * Time.deltaTime;
    //    enemy.Translate(-enemy.right * delta);
    //    yield return new WaitForSeconds(3);
    //    //Debug.Log("오른쪽");
    //    enemySprite.flipX = false;
    //    enemy.Translate(enemy.right * delta);
    //    yield return new WaitForSeconds(3);
    //}
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        enemySprite.flipX = !enemySprite.flipX;
    //        isplayer = true;
    //        Playertarget = other.gameObject.transform;
    //    }
    //    if (other.gameObject.CompareTag("Enemy"))
    //    {
    //        other.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    //        other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
    //    }
    //}
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        enemySprite.flipX = !enemySprite.flipX;
    //        collision.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    //        collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;


    //    }
    //}

    public void attack()
    {
        Dir = enemy.position.x - Playertarget.position.x; ;

        if (Dir > 0)
        {
            enemySprite.flipX = true;

        }
        else if (Dir < 0)
        {
            enemySprite.flipX = false;
            #region 주석
            //if (PlayerMove.Instance.enemyCount == 1)
            //{
            //    Vector3 dir = Playertarget.transform.position - this.transform.position;
            //    Vector3 dist0 = new Vector3(0.5f, 0.0f, 0.0f);
            //    dir += dist0;
            //    Vector3 moveVector = new Vector3(-dir.x * speed * Time.deltaTime, dir.y * speed * Time.deltaTime, 0.0f);
            //    this.transform.Translate(moveVector);
            //}
            //else if (PlayerMove.Instance.enemyCount == 2)
            //{
            //    Vector3 dir = Playertarget.transform.position - this.transform.position;
            //    Vector3 dist0 = new Vector3(0.5f, 0.0f, 0.0f);
            //    dir += dist0;
            //    Vector3 moveVector = new Vector3(-dir.x * speed * Time.deltaTime, dir.y * speed * Time.deltaTime, 0.0f);


            //    this.transform.Translate(moveVector);
            //}
            //else if (PlayerMove.Instance.enemyCount == 3)
            //{
            //    Vector3 dir = Playertarget.transform.position - this.transform.position;
            //    Vector3 dist0 = new Vector3(0.5f, 0.0f, 0.0f);
            //    dir += dist0;
            //    Vector3 moveVector = new Vector3(-dir.x * speed * Time.deltaTime, dir.y * speed * Time.deltaTime, 0.0f);

            //    this.transform.Translate(moveVector);
            //}
            //else
            //{
            //    Vector3 dir = Playertarget.transform.position - this.transform.position;
            //    Vector3 dist0 = new Vector3(0.1f * PlayerMove.Instance.enemyCount / 0.5f, 0.0f, 0.0f);
            //    dir += dist0;
            //    Vector3 moveVector = new Vector3(-dir.x * speed * Time.deltaTime, dir.y * speed * Time.deltaTime, 0.0f);

            //    this.transform.Translate(moveVector);
            //}
            #endregion
        }

        Vector3 dir = Playertarget.transform.position - this.transform.position;
        dir.Normalize();
        
        if (PlayerMove.Instance.isjumping)
        {
            enemy.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 5.0f,ForceMode2D.Impulse);
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, Playertarget.transform.position - dir * ((float)enemyCount + 1.0f), speed * Time.deltaTime);
        }
    }
    public void jump()
    {
        Ray2D ray2 = new Ray2D(enemy.position, -enemy.up * 1f);
        RaycastHit2D hit = Physics2D.Raycast(ray2.origin, ray2.direction);
        if (hit.collider == null)
        {
            Debug.DrawRay(enemy.position, -enemy.up * 1f);
            //Debug.Log("그라운드");

            float jumpY = ground.position.y;
            Vector3 jumpVector = new Vector3(0, jumpY, 0);
            float jumpdist = Vector2.Distance(jumpVector, -enemy.up);
        }
    }
    public void move()
    {
        thisEnemy = transform.position;
        Ray2D ray = new Ray2D(enemy.position, enemy.right * 5f);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

        if (hit.collider != null)
        {
            Debug.DrawRay(enemy.position, -enemy.up * 1f);
            if (isTurn)
            {
                Debug.DrawRay(enemy.transform.position, enemy.right * 5f);

            }
            else if (!isTurn)
            {
                Debug.DrawRay(enemy.transform.position, -enemy.right * 5f);

            }

        }
        float dist = Vector2.Distance(StartPos, thisEnemy);
        if (dist > 10.0f)
        {
            StartPos = transform.position;
            isTurn = !isTurn;
            enemySprite.flipX = !enemySprite.flipX;
            a *= -1;
        }
        else
        {
            float delta = speed * Time.deltaTime;
            enemy.Translate(-enemy.right * a * delta);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enemyState = state.attack;
            enemySprite.flipX = !enemySprite.flipX;
            isplayer = true;
            Playertarget = other.gameObject.transform;
            //enemyCount = other.GetComponent<PlayerMove>().enemyCount++;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            enemyState = state.jump;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            //thisEnemy = transform.position;
            
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            //enemySprite.flipX = !enemySprite.flipX;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            if (!isplayerEnemy)
            {
                enemyCount = collision.gameObject.GetComponent<PlayerMove>().enemyCount++; isplayerEnemy = true;
            }
            //enemySprite.flipX = !enemySprite.flipX;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            enemyState = state.jump;
        }
    }
    */
    #endregion
    public int moveNum = 0;
    public Rigidbody2D enemyRigid;
    public GameObject enemy;
    public float Speed = 5.0f;
    public LayerMask mask;
    public GameObject target;
    public Collider2D coll;
    public enum Enemystate
    {
        idle, attack
    }
    public Enemystate state;
    private void Start()
    {
        enemy = this.gameObject;
        enemyRigid = this.gameObject.GetComponent<Rigidbody2D>();
        Invoke("randomMove", 5f);
    }
    public void Update()
    {
        switch (state)
        {
            case Enemystate.idle:
                
                move();
                break;
            case Enemystate.attack:
                attack();
                break;
        }
    }
    private void move()
    {
        Vector2 moveVelocity = new Vector2(moveNum,0);
        if (moveNum == 1)
        {
            enemy.GetComponent<SpriteRenderer>().flipX = false;
            enemyRigid.AddForce(moveVelocity * Speed);
        }
        else if (moveNum == -1)
        {
            enemy.GetComponent<SpriteRenderer>().flipX = true;
            enemyRigid.AddForce(-moveVelocity * Speed);
        }
        attackTarget();
        enterground();
        
        
        if (enemyRigid.velocity.x < 50)
        {
            enemyRigid.velocity = new Vector2(moveNum, 0);
        }
        
    }
    public void attack()
    {

    }
    public void Damage()
    {
        target.GetComponent<PlayerDB>().DB.hp -= this.GetComponent<EnemyManager>().AttackPoint;
    }
    void enterground()
    {
        Ray2D ray2 = new Ray2D(this.transform.position, -Vector2.up);
        RaycastHit2D hit = Physics2D.Raycast(ray2.origin, ray2.direction,1.4f,mask);
        Debug.DrawRay(this.transform.position, -Vector2.up);
        if (hit.collider == null)
        {
            Debug.Log("바닥에 아무것도 없다.");
            enemyRigid.gravityScale = 10;
            enemy.GetComponent<Collider2D>().isTrigger = false;
            
        }
        if (hit.collider != null)
        {
            Debug.Log("바닥에 무엇인가 존재 한다.");
            enemyRigid.gravityScale = 0;
            enemy.GetComponent<Collider2D>().isTrigger = true;
        }
    }
    void attackTarget()
    {
        //Vector2 ab = this.transform.forward;
        //Vector2 ac = target.transform.position - this.transform.position;
        //ac.Normalize();

        //float dist = target.transform.position.x - this.transform.position.x;

        //float cos = Vector3.Dot(ab, ac);
        //float cos_to_anlge = Mathf.Acos(cos);

        //float y = 180 * (cos_to_anlge / Mathf.PI);
        //Ray2D ray2 = new Ray2D(this.transform.forward, -Vector2.up);
        //RaycastHit2D hit = Physics2D.Raycast(ray2.origin, ray2.direction);
        //Debug.DrawRay(ab, ac);
        LayerMask Layer = 1 << 7;
        coll = Physics2D.OverlapCircle(transform.position, 30.0f, Layer);
        if (coll != null)
        {
            Debug.Log("닷았다");
        }
    }
    public void randomMove()
    {
        Debug.Log("무브 랜덤");
        moveNum = Random.Range(-1, 2);
        Invoke("randomMove", 5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            target = collision.gameObject;
            state = Enemystate.attack;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            state = Enemystate.attack;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

        }
    }
}

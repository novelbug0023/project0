using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform enemy;
    public Transform Playertarget;
    SpriteRenderer enemySprite;
    public float right;
    public float left;
    public bool isplayer;
    public float speed = 5.0f;
    public Vector2 StartPos;
    public Vector2 thisEnemy;
    public bool isTurn = false;
    // Start is called before the first frame update
    void Start()
    {
        enemy = this.GetComponent<Transform>();
        enemySprite = this.GetComponent<SpriteRenderer>();
        StartPos = this.transform.position;
       
    }
    float a = 1;
    // Update is called once per frame
    void Update()
    {
        
        if (!isplayer)
        {
            thisEnemy = transform.position;
            Ray2D ray = new Ray2D(enemy.position,Vector2.zero);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            
            if (hit.collider != null)
            {
                Debug.DrawRay(enemy.transform.position, enemy.right);
                Debug.Log(hit);
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


            //StartCoroutine(EnemyMovefor());
        }
        else
        {
            float Dir = enemy.position.x - Playertarget.position.x;
            if (Dir > 0)
            {
                enemySprite.flipX = true;
            }
            else if (Dir < 0)
            {
                enemySprite.flipX = false;
            }
            Vector3 dir = Playertarget.transform.position - this.transform.position;
            Vector3 moveVector = new Vector3(dir.x * speed * Time.deltaTime, dir.y * speed * Time.deltaTime, 0.0f);
            this.transform.Translate(moveVector);
        }
    }
    IEnumerator EnemyMovefor()
    {
        //Debug.Log("¿ÞÂÊ");
        yield return new WaitForSeconds(3);
        enemySprite.flipX = true;
        float delta = speed * Time.deltaTime;
        enemy.Translate(-enemy.right * delta);
        yield return new WaitForSeconds(3);
        //Debug.Log("¿À¸¥ÂÊ");
        enemySprite.flipX = false;
        enemy.Translate(enemy.right * delta);
        yield return new WaitForSeconds(3);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        enemySprite.flipX = !enemySprite.flipX;
    //        isplayer = true;
    //        Playertarget = other.gameObject.transform;
    //    }
    //}
}

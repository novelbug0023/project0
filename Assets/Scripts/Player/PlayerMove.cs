using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public SpwonEnemy Spwonenemy;
    public MapDatabass mapdb;
    public Transform PlayerPOS;
    public Rigidbody2D playerRigd;
    public SpriteRenderer player;
    public SystemManager systemManager;
    public float PlayerSpeed = 10.0f;
    public float JumpFowar = 5.0f;
    public bool isjumping = false;
    public int JumpCount = 0;
    public string eventKinds;
    public int enemyCount;
    public Animator myAnime;
    public int Hp;
    public bool isTurn = false;
    #region ΩÃ±€≈Ê
    private static PlayerMove instance = null;
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static PlayerMove Instance
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
        mapdb = GameObject.FindGameObjectWithTag("MapDB").GetComponent<MapDatabass>();
        Spwonenemy = GameObject.FindGameObjectWithTag("MapDB").GetComponent<SpwonEnemy>();
        systemManager = GameObject.FindGameObjectWithTag("SystemManager").GetComponent<SystemManager>();
        Hp = PlayerDB.Instance.DB.hp;
        if (systemManager.DB.isGames == true)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        else { return; }
    }

    // Update is called once per frame
    void Update()
    {
        if (Hp < 0)
        {
            Hp = 0;
        }
        PlayerDB.Instance.DB.hp = Hp; 
        if (systemManager.DB.isnarration) { myAnime.SetBool("move", false); return; }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                float delta = PlayerSpeed * Time.deltaTime;

                player.flipX = false;
                isTurn = false;
                PlayerPOS.Translate(PlayerPOS.right * delta);
                myAnime.SetBool("move", true);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {

                float delta = PlayerSpeed * Time.deltaTime;
                PlayerPOS.Translate(-PlayerPOS.right * delta);

                player.flipX = true;
                isTurn = true;


                myAnime.SetBool("move", true);


            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                myAnime.SetBool("move", false);
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                myAnime.SetBool("move", false);
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
                    this.gameObject.GetComponent<Rigidbody2D>().mass = 1;
                    playerRigd.AddForce(Vector2.up * JumpFowar, ForceMode2D.Impulse);
                    isjumping = true;
                    JumpCount++;
                }

            }
            
        }
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            this.gameObject.GetComponent<Rigidbody2D>().mass = 1000;
            isjumping = false;
            JumpCount = 0;
        }
    }

    public int mapLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (systemManager.DB.isFirst_story)
        {
            if (collision.gameObject.CompareTag("warf"))
            {
                //mapdb.SpwanPlayer();
                mapdb.DB.Player.position = mapdb.DB.falststoypos[0].transform.position;
                mapdb.DB.mapNum = 6;
                Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.falststoypos[0].transform.position.y + 3f, Camera.main.transform.position.z);
                mapdb.minmap.transform.position = new Vector3(mapdb.minmapPos[6].transform.position.x, mapdb.minmapPos[6].transform.position.y, -25.0f);
                mapdb.fadeMap();
                Spwonenemy.fadeEnemyIn();
            }
        }
        else
        {
            if (Spwonenemy.DB.mapEnemy.Count == 0)
            {
                if (collision.gameObject.CompareTag("warf"))
                {
                    Debug.Log("¿Ãµø");
                    mapLevel++;
                    if (mapLevel == 0)
                    {
                        mapdb.DB.SpwanNum = Random.Range(0, 5);
                        Debug.Log("∑£¥˝" + mapdb.DB.SpwanNum);
                        mapdb.SpwanPlayer();
                        Spwonenemy.spwonEnemys();
                    }
                    if (mapLevel == 1)
                    {

                        mapdb.DB.SpwanNum = Random.Range(0, 5);
                        mapdb.SpwanPlayer();
                        Spwonenemy.spwonEnemys();

                    }
                    if (mapLevel == 2)
                    {

                        mapdb.DB.SpwanNum = Random.Range(0, 5);
                        mapdb.SpwanPlayer();
                        Spwonenemy.spwonEnemys();

                    }
                    if (mapLevel == 3)
                    {
                        mapdb.DB.SpwanNum = Random.Range(0, 5);
                        mapdb.SpwanPlayer();
                        Spwonenemy.spwonEnemys();

                    }
                    if (mapLevel == 4)
                    {
                        mapdb.DB.SpwanNum = Random.Range(0, 5);
                        mapdb.SpwanPlayer();
                        Spwonenemy.spwonEnemys();

                    }
                    if (mapLevel == 5)
                    {
                        //if (SpwonEnemy.Instance.DB.mapEnemy == null)
                        //{
                        mapdb.homePlayer();

                        mapdb.DB.mapLevel = 0;
                        //}
                    }
                    if (mapLevel > 5) { mapLevel = 0; }
                }
            }

        }
        #region ¡÷ºÆ
        //if (collision.gameObject.CompareTag("Enemy"))
        //{
        //    enemyCount++;
        //    isEnemyAttack = true;
        //    target = collision.gameObject;
        //    //target.gameObject.GetComponent<EnemyMove>().isplayer = true;
        //    //target.gameObject.GetComponent<EnemyMove>().Playertarget = this.gameObject.transform;
        //}
        #endregion
    }
    #region ¡÷ºÆ
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        isEnemyAttack = false;
    //        collision.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    //        collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
    //    }
    //}
    #endregion

}


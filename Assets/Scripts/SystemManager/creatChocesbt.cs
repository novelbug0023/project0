using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class creatChocesbt : MonoBehaviour
{
    //#region ΩÃ±€≈Ê
    //private static creatChocesbt instance = null;
    //void Awake()
    //{
    //    if (null == instance)
    //    {
    //        instance = this;
    //        //DontDestroyOnLoad(this.gameObject);
    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}

    //public static creatChocesbt Instance
    //{
    //    get
    //    {
    //        return instance;
    //    }
    //}


    //#endregion
    public List<GameObject> chocesBTs = new List<GameObject>();
    public GameObject chocesBT;
    public Transform chocesBTpos;
    public DialogueManager DIAmanager;
    // Start is called before the first frame update
    void Start()
    {
        DIAmanager = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
    }
    public void create()
    {
        //close();
        for (int i = 0; i < DIAmanager.DB.chocesCOUNT; i++)
        {
            chocesBTs.Add(Instantiate(chocesBT, chocesBT.transform.position,Quaternion.identity));
            chocesBTs[i].transform.SetParent(chocesBTpos);
            chocesBTs[i].transform.position = Vector3.zero;
            int k = i;
            chocesBTs[i].GetComponent<ChocesNum>().num = i;
            chocesBTs[k].GetComponent<Button>().onClick.AddListener(() => chocesBTs[k].GetComponent<ChocesNum>().choceNUM(chocesBTs[i].GetComponent<ChocesNum>().num));
        }
    }
    public void close()
    {
        for (int i = 0; i < chocesBTs.Count; i++)
        {
            Destroy(chocesBTs[i]);
        }
        chocesBTs.Clear();
    }
    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocesNum : MonoBehaviour
{
    //#region ΩÃ±€≈Ê
    //private static ChocesNum instance = null;
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

    //public static ChocesNum Instance
    //{
    //    get
    //    {
    //        return instance;
    //    }
    //}


    //#endregion
    public int num;
    public ChocesDB db;
    public creatChocesbt CreatChocesbt;
    public ShowDialogue showdia;
    public DialogueManager DIAmanager;
    private void Start()
    {
        db = GameObject.FindGameObjectWithTag("creatChocesbt").GetComponent<ChocesDB>();
        CreatChocesbt = GameObject.FindGameObjectWithTag("creatChocesbt").GetComponent<creatChocesbt>();
        showdia = GameObject.FindGameObjectWithTag("ShowDialogue").GetComponent<ShowDialogue>();
        DIAmanager = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
    }
    public void choceNUM(int n_num)
    {
        n_num = num;
        switch (n_num)
        {
            case 0:
                CreatChocesbt.close();
                for (int i = 0; i < db.db.story[num].story.Count;i++)
                {
                    
                    showdia.dialogues.Add(db.db.story[0].story[i]);
                    showdia.startDialogues();
                }
                DIAmanager.DB.isch = false;
                break;
            case 1:
                CreatChocesbt.close();
                for (int i = 0; i < db.db.story[num].story.Count; i++)
                {
                    showdia.dialogues.Add(db.db.story[1].story[i]);
                    showdia.startDialogues();
                }
                DIAmanager.DB.isch = false;
                break;
            case 2:
                CreatChocesbt.close();
                for (int i = 0; i < db.db.story[num].story.Count; i++)
                {
                    showdia.dialogues.Add(db.db.story[2].story[i]);
                    showdia.startDialogues();
                }
                DIAmanager.DB.isch = false;
                break;

        }
    }
}

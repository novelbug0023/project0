using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDialogue : MonoBehaviour
{
    //#region ΩÃ±€≈Ê
    //private static ShowDialogue instance = null;
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

    //public static ShowDialogue Instance
    //{
    //    get
    //    {               
    //        return instance;
    //    }
    //}


    //#endregion
    public DialogueManager DIAmanager;
    public string dialogue;
    public Text dialogueT;
    public Text dialogueNameT;
    public GameObject dialoguePenal;
    public GameObject bt;
    public int dialogueCount;
    public List<string> dialogues = new List<string>();

    [Header("πˆ∆∞")]
    public bool isDialogueEND;
    public bool isDialogueNEXT;

    public creatChocesbt CreateChocesbt;
    public SystemManager systemManager;

    public void Start()
    {
        CreateChocesbt = GameObject.FindGameObjectWithTag("creatChocesbt").GetComponent<creatChocesbt>();
        DIAmanager = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
        systemManager = GameObject.FindGameObjectWithTag("SystemManager").GetComponent<SystemManager>();
        if (systemManager.DB.isTutorial)
        {
            startDI();
        }
        else
        {
            return;
        }
    }
    public void startDI()
    {
        if (systemManager.DB.isTutorial)
        {
            systemManager.DB.isnarration = true;
            for (int i = 0; i < DIAmanager.DB.Tutorial.Length; i++)
            {
                dialogues.Add(DIAmanager.DB.Tutorial[i].ToString());

            }
            startDialogues();
        }
        startDialogues();

    }
    public void startNPCDI(string npc)
    {
        switch (npc)
        {
            case "≥≤±√":
                break;
            case "∏∂±≥":
                break;
            case "∫œ«ÿ∫˘±√":
                break;
            case "«˜√µºˆ∂Û±≥":
                break;
        }
    }
    public void NpcDi()
    {

    }
    public void startDialogues()
    {
        systemManager.DB.isnarration = true;
        dialoguePenal.SetActive(true);
        if (dialogues != null)
        {
            if (dialogueCount < dialogues.Count)
            {
                Debug.Log("dialogueCount" + dialogueCount);
                dialogue = dialogues[dialogueCount];
                StartCoroutine(dialogueCouten());
                //if (dialogueCount == dialogues.Count)
                //{
                //    if (DialogueManager.Instance.DB.isch)
                //    {
                //        ChocesManager();
                //        Debug.Log("√ ¿ÃΩ∫");
                //    }
                //}
            }
            else if (dialogueCount >= dialogues.Count)
            {
                //Debug.Log("¡æ∑·");
                //isDialogueEND = true;
                //isDialogueNEXT = false;
                //isEnd();
                if (DIAmanager.DB.isch)
                {
                    ChocesManager();
                    Debug.Log("√ ¿ÃΩ∫");
                }
                else
                {
                    Debug.Log("¡æ∑·");
                    isDialogueEND = true;
                    isDialogueNEXT = false;
                    isEnd();
                }
            }
        }
        else { return; }
        
    }
    public IEnumerator dialogueCouten()
    {
        if (!isDialogueEND)
        {
            yield return new WaitForSeconds(0.5f);
            if (systemManager.DB.isnarration)
            {
                for (int i = 0; i < dialogue.Length; i++)
                {
                    yield return new WaitForSeconds(0.1f);
                    dialogueT.text = dialogue.Substring(0, i+1);
                }
                bt.SetActive(true);
            }
        }
    }
    public void isNext()
    {
        if (dialogueCount >= dialogues.Count)
        {
            if (DIAmanager.DB.isch)
            {
                ChocesManager();
                Debug.Log("√ ¿ÃΩ∫");
            }
            else { 
                Debug.Log("¡æ∑·");
                isDialogueEND = true;
                isDialogueNEXT = false;
                isEnd();
            }
        }
        if (dialogueCount < dialogues.Count)
        {
            Debug.Log("Next");
            isDialogueNEXT = true;
            isNexts();
            startDialogues();
            if (dialogueCount == dialogues.Count)
            {
                
            }
        }
        
    }
    public void isNexts()
    {
        if (isDialogueNEXT)
        {
            dialogueCount++;
            bt.SetActive(false);
        }
    }
    public void isEnd()
    {
        Debug.Log("¡æ∑·");
        dialoguePenal.SetActive(false);
        StopCoroutine(dialogueCouten());
        dialogues.Clear();
        dialogueT.text = "";
        dialogueCount = 0;
        systemManager.OnGameSystem();
        systemManager.DB.isnarration = false;
    }

    void ChocesManager()
    {
        CreateChocesbt.create();
        if (systemManager.DB.isJob == false)
        {
            //DialogueManager.Instance.DB.chocesCOUNT = 2;
            CreateChocesbt.create();
        }
    }
}

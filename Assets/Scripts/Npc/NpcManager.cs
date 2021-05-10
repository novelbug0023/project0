using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcManager : MonoBehaviour
{
    public DialogueManager DIAmanager;
    public ShowDialogue showdialogue;
    public SystemManager systemManager;
    public string NpcName;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        DIAmanager = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
        showdialogue = GameObject.FindGameObjectWithTag("ShowDialogue").GetComponent<ShowDialogue>();
        systemManager = GameObject.FindGameObjectWithTag("SystemManager").GetComponent<SystemManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            count++;
            switch (this.gameObject.GetComponent<NpcManager>().NpcName)
            {
                case "마을사람":
                    if (systemManager.DB.isFirst_story)
                    {
                        if (count == 1)
                        {
                            Debug.Log("마을 사람");
                            showdialogue.isDialogueEND = false;
                            for (int i = 0; i < DIAmanager.DB.NpcSTORY01.Length; i++)
                            {
                                showdialogue.dialogues.Add(DIAmanager.DB.NpcSTORY01[i].ToString());
                            }
                            showdialogue.startDialogues();
                            //count++;
                        }
                        if (count == 2)
                        {
                            DIAmanager.DB.chocesCOUNT = 3;
                            Debug.Log("마을 사람");

                            showdialogue.isDialogueEND = false;
                            for (int i = 0; i < DIAmanager.DB.JabStory.Length; i++)
                            {
                                showdialogue.dialogues.Add(DIAmanager.DB.JabStory[i].ToString());
                            }
                            showdialogue.startDialogues();
                            DIAmanager.DB.isch = true;
                        }
                        //ShowDialogue.Instance.startDI();
                    }
                    break;
            }
        }
    }
}

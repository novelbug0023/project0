using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSkill : MonoBehaviour
{
    public SkillDB skillDB;
    void Start()
    {
        skillDB = GameObject.FindGameObjectWithTag("PlayerDB").GetComponent<SkillDB>();
        //PDB = GameObject.FindGameObjectWithTag("PlayerDB").GetComponent<PlayerDataBass>();
    }
    //public PlayerMove.PlayerKinds kinds;
    void Update()
    {
        switch (PlayerDB.Instance.DB.KINDS)
        {
            case "����":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "���":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "�⺻":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
        }

    }
}
    


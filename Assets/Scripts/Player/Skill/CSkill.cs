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
            case "°ÅÁö":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "Æò¹Î":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "³²±Ã":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "ºù±Ã":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "¸¶±³":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "Ç÷±³":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
            case "±âº»":
                if (Input.GetKeyDown(KeyCode.C))
                {
                    skillDB.CskillKinds();
                }
                break;
        }

    }
}
    


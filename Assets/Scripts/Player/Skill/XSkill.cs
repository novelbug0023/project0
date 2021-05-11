using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XSkill : MonoBehaviour
{
    public SkillDB skillDB;
    void Start()
    {
        skillDB = GameObject.FindGameObjectWithTag("PlayerDB").GetComponent<SkillDB>();
        //PDB = GameObject.FindGameObjectWithTag("PlayerDB").GetComponent<PlayerDataBass>();
    }
    void Update()
    {
        switch (PlayerDB.Instance.DB.KINDS)
        {
            case "°ÅÁö":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "Æò¹Î":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "³²±Ã":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "ºù±Ã":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "¸¶±³":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "Ç÷±³":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "±âº»":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
        }
    }
    
}

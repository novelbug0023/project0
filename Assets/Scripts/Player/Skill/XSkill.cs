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
            case "����":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "���":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
            case "�⺻":
                if (Input.GetKeyDown(KeyCode.X))
                {
                    skillDB.XskillKinds();
                }
                break;
        }
    }
    
}

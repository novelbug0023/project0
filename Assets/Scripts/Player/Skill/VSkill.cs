using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VSkill : MonoBehaviour
{
    public SkillDB skillDB;
    void Start()
    {
        skillDB = GameObject.FindGameObjectWithTag("PlayerDB").GetComponent<SkillDB>();
        //PDB = GameObject.FindGameObjectWithTag("PlayerDB").GetComponent<PlayerDataBass>();
    }
    // Update is called once per frame
    void Update()
    {
        switch (PlayerDB.Instance.DB.KINDS)
        {
            case "����":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "���":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "����":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "�⺻":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
        }
    }
}

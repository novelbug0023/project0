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
            case "°ÅÁö":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "Æò¹Î":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "³²±Ã":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "ºù±Ã":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "¸¶±³":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "Ç÷±³":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
            case "±âº»":
                if (Input.GetKeyDown(KeyCode.V))
                {
                    skillDB.VskillKinds();
                }
                break;
        }
    }
}

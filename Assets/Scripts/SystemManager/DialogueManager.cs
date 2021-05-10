using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Json;

[System.Serializable]
public class DialoueDbList
{
    public Dictionary<bool, string[]> s1 = new Dictionary<bool, string[]>();
    public ArrayList list;
    public string[] Tutorial;
    public string[] Scenario_1;
    public string[] Scenario_2;
    public string[] Scenario_3;
    public string[] Scenario_4;
    [Header("마을 노인")]
    public string[] NpcSTORY01;

    [Header("직업선택")]
    public string[] JabStory;

    public int chocesCOUNT;
    public bool isch;
    public void start()
    {
        
        //s1.Add(false, Scenario_1);
        //s1.Add(false, Scenario_2);
        //s1.Add(false, Scenario_3);
        //s1.Add(false, Scenario_4);
        //s1.Add(false, NpcSTORY01);
        //s1.Add(true, JabStory);
        
    }
}
public class DialogueManager : MonoBehaviour
{
    public DialoueDbList DB;

    //#region 싱글톤
    //private static DialogueManager instance = null;
    //void Awake()
    //{
    //    if (null == instance)
    //    {
    //        instance = this;

    //        DontDestroyOnLoad(this.gameObject);
    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}

    //public static DialogueManager Instance
    //{
    //    get
    //    {
    //        if (null == instance)
    //        {
    //            return null;
    //        }
    //        return instance;
    //    }
    //}


    //#endregion
    #region json
    [ContextMenu("JsonSaveData")]
    public void JsonSaveData()
    {
        string path = Application.dataPath + "/SwordOfWar_DialogueDataBass.json";
        string jsondata = JsonUtility.ToJson(DB, true);
        File.WriteAllText(path, jsondata);
        Debug.Log(jsondata);

    }

    [ContextMenu("JsonLoadData")]
    public void JsonLoadData()
    {
        string path = Application.dataPath + "/SwordOfWar_DialogueDataBass.json";
        string jsondata = File.ReadAllText(path);
        DB = JsonUtility.FromJson<DialoueDbList>(jsondata);
    }
    #endregion
}

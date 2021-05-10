using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Json;

[System.Serializable]
public class SystemDb
{
    public bool isTutorial = true;
    public bool isFirst_story = false;
    public bool isJob = false;
    public bool isdistinguished = false;
    public bool isMain_story = false;
    public bool isScenario_1 = false;
    public bool isScenario_2 = false;
    public bool isScenario_3 = false;
    public bool isScenario_4 = false;
    public bool isnarration = true;
    public bool isGames = false;
    public bool isEvent = false;

}
public class SystemManager : MonoBehaviour
{
    //#region ΩÃ±€≈Ê
    //private static SystemManager instance = null;
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

    //public static SystemManager Instance
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
    private static SystemManager instance = null;
    void Awake()
    {
        if (null == instance)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public SystemDb DB;
    public void OnGameSystem()
    {
        if (DB.isTutorial == true)
        {
            DB.isTutorial = false;
            DB.isFirst_story = true;
        }
        
    }

    #region json
    [ContextMenu("JsonSaveData")]
    public void JsonSaveData()
    {
        string path = Application.dataPath + "/SwordOfWar_SystemDataBass.json";
        string jsondata = JsonUtility.ToJson(DB, true);
        File.WriteAllText(path, jsondata);
        Debug.Log(jsondata);

    }

    [ContextMenu("JsonLoadData")]
    public void JsonLoadData()
    {
        string path = Application.dataPath + "/SwordOfWar_SystemDataBass.json";
        string jsondata = File.ReadAllText(path);
        DB = JsonUtility.FromJson<SystemDb>(jsondata);
    }
    #endregion
}

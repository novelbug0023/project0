using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CHOCES_DB
{
    public List<List<string>> chosceList = new List<List<string>>();
    public List<string> chocesDialogue = new List<string>();
    public ChocesOBJ[] story;

    [Header("³²±Ã")]
    public ChocesOBJ[] storys1000;
    [Header("ºÏÇØ")]
    public ChocesOBJ[] storys2000;
    [Header("¸¶±³")]
    public ChocesOBJ[] storys3000;
    [Header("Ç÷±³")]
    public ChocesOBJ[] storys4000;

}
public class ChocesDB : MonoBehaviour
{
    public CHOCES_DB db;

    // Start is called before the first frame update
    void Start()
    {
        db.chosceList.Add(db.chocesDialogue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chosce()
    {

    }
}

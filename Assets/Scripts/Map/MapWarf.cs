using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MapWarf : MonoBehaviour
{
    public MapDatabass mapdb;
    private void Start()
    {
        //MapDatabass.Instance.DB.Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        mapdb = GameObject.FindGameObjectWithTag("MapDB").GetComponent<MapDatabass>();
        mapdb.DB.Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    
    public void SpwanPlayer()
    {
        //Debug.Log("¸Ê·»´ý ÀÌµ¿");
        if (mapdb.DB.SpwanNum == 0)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿1");
            Debug.Log("Ä«¸Þ¶ó À§Ä¡" + Camera.main.GetComponent<Camera>().transform.position);
            mapdb.DB.Player.position = mapdb.DB.spwan[0].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
        if (mapdb.DB.SpwanNum == 1)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿2");
            Debug.Log("Ä«¸Þ¶ó À§Ä¡" + Camera.main.GetComponent<Camera>().transform.position);
            mapdb.DB.Player.position = mapdb.DB.spwan[1].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
        if (mapdb.DB.SpwanNum == 2)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿3");
            mapdb.DB.Player.position = mapdb.DB.spwan[2].transform.position;
            Debug.Log("Ä«¸Þ¶ó À§Ä¡" + Camera.main.GetComponent<Camera>().transform.position);
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
        if (mapdb.DB.SpwanNum == 3)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿4");
            Debug.Log("Ä«¸Þ¶ó À§Ä¡" + Camera.main.GetComponent<Camera>().transform.position);
            mapdb.DB.Player.position = mapdb.DB.spwan[3].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
        if (mapdb.DB.SpwanNum == 4)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿5");
            Debug.Log("Ä«¸Þ¶ó À§Ä¡" + Camera.main.GetComponent<Camera>().transform.position);
            mapdb.DB.Player.position = mapdb.DB.spwan[4].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
    }
}

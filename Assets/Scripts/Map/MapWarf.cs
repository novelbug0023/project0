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
        //Debug.Log("�ʷ��� �̵�");
        if (mapdb.DB.SpwanNum == 0)
        {
            Debug.Log("�ʷ��� �̵�1");
            Debug.Log("ī�޶� ��ġ" + Camera.main.GetComponent<Camera>().transform.position);
            mapdb.DB.Player.position = mapdb.DB.spwan[0].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
        if (mapdb.DB.SpwanNum == 1)
        {
            Debug.Log("�ʷ��� �̵�2");
            Debug.Log("ī�޶� ��ġ" + Camera.main.GetComponent<Camera>().transform.position);
            mapdb.DB.Player.position = mapdb.DB.spwan[1].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
        if (mapdb.DB.SpwanNum == 2)
        {
            Debug.Log("�ʷ��� �̵�3");
            mapdb.DB.Player.position = mapdb.DB.spwan[2].transform.position;
            Debug.Log("ī�޶� ��ġ" + Camera.main.GetComponent<Camera>().transform.position);
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
        if (mapdb.DB.SpwanNum == 3)
        {
            Debug.Log("�ʷ��� �̵�4");
            Debug.Log("ī�޶� ��ġ" + Camera.main.GetComponent<Camera>().transform.position);
            mapdb.DB.Player.position = mapdb.DB.spwan[3].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
        if (mapdb.DB.SpwanNum == 4)
        {
            Debug.Log("�ʷ��� �̵�5");
            Debug.Log("ī�޶� ��ġ" + Camera.main.GetComponent<Camera>().transform.position);
            mapdb.DB.Player.position = mapdb.DB.spwan[4].transform.position;
            Camera.main.GetComponent<Camera>().transform.position = new Vector3(Camera.main.transform.position.x, mapdb.DB.spwan[0].transform.position.y - 2, Camera.main.transform.position.z);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MapWarf : MonoBehaviour
{

    private void Start()
    {
        MapDatabass.Instance.DB.Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    
    public void SpwanPlayer()
    {
        //Debug.Log("�ʷ��� �̵�");
        if (MapDatabass.Instance.DB.SpwanNum == 0)
        {
            Debug.Log("�ʷ��� �̵�1");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[0].transform.position;
        }
        if (MapDatabass.Instance.DB.SpwanNum == 1)
        {
            Debug.Log("�ʷ��� �̵�2");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[1].transform.position;
        }
        if (MapDatabass.Instance.DB.SpwanNum == 2)
        {
            Debug.Log("�ʷ��� �̵�3");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[2].transform.position;
        }
        if (MapDatabass.Instance.DB.SpwanNum == 3)
        {
            Debug.Log("�ʷ��� �̵�4");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[3].transform.position;
        }
        if (MapDatabass.Instance.DB.SpwanNum == 4)
        {
            Debug.Log("�ʷ��� �̵�5");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[4].transform.position;
        }
    }
}

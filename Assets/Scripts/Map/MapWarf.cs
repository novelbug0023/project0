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
        //Debug.Log("¸Ê·»´ý ÀÌµ¿");
        if (MapDatabass.Instance.DB.SpwanNum == 0)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿1");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[0].transform.position;
        }
        if (MapDatabass.Instance.DB.SpwanNum == 1)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿2");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[1].transform.position;
        }
        if (MapDatabass.Instance.DB.SpwanNum == 2)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿3");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[2].transform.position;
        }
        if (MapDatabass.Instance.DB.SpwanNum == 3)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿4");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[3].transform.position;
        }
        if (MapDatabass.Instance.DB.SpwanNum == 4)
        {
            Debug.Log("¸Ê·»´ý ÀÌµ¿5");
            MapDatabass.Instance.DB.Player.position = MapDatabass.Instance.DB.spwan[4].transform.position;
        }
    }
}

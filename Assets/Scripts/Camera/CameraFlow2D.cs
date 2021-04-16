using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow2D : MonoBehaviour
{
    public Transform CameTarget;
    Vector2 playerPOS;
    
    public float CameraSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        CameTarget = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerPOS = CameTarget.position;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(CameTarget);
        //this.transform.Translate(CameTarget.position);
        Vector3 dir = CameTarget.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * CameraSpeed * Time.deltaTime, dir.y * CameraSpeed * Time.deltaTime, 0.0f);
        this.transform.Translate(moveVector);
    }
}

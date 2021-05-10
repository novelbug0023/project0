using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow2D : MonoBehaviour
{
    public Transform CameTarget;
    Vector2 playerPOS;
    public Camera minmapCamera;
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
        #region 안된 부분
        //this.transform.LookAt(CameTarget);
        //this.transform.Translate(CameTarget.position);
        #endregion
        float delta = CameraSpeed * Time.deltaTime;
        #region 안된 부분
        //Vector3 dir = CameTarget.transform.position - this.transform.position;
        //Vector3 moveVector = new Vector3(dir.x /** delta*/, dir.y + 2/* * CameraSpeed * Time.deltaTime, 0.0f*/);
        //this.transform.position = new Vector3(moveVector.x, 0.0f, this.transform.position.z);
        #endregion
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(CameTarget.transform.position.x, this.transform.position.y, this.transform.position.z),delta);
        #region 안된 부분
        //new Vector3(CameTarget.transform.position.x, 0.0f, this.transform.position.z);
        
        //선영보관 ab를 보관
        //this.transform.Translate(moveVector);
        
        //if (CameTarget.transform.localPosition.y > 3.0f)
        //{
        //    this.transform.position = new Vector3(this.transform.position.x, (CameTarget.transform.position.y - 3.0f)+4.5f, -9.39f);
        //}
        //else if (CameTarget.transform.localPosition.y < -0.88f)
        //{
        //    this.transform.position = new Vector3(this.transform.position.x, CameTarget.transform.position.y - 1.01f+2, -9.39f);
        //}
        #endregion
        if (this.transform.position.x < -38.22f)
        {
            this.transform.position = new Vector3(-38.22f, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x > 46.89f)
        {
            this.transform.position = new Vector3(46.89f, this.transform.position.y, this.transform.position.z);
        }
        if (minmapCamera.transform.position.x < -31.7f)
        {
            minmapCamera.transform.position = new Vector3(-31.7f, minmapCamera.transform.position.y, minmapCamera.transform.position.z);
        }
        if (minmapCamera.transform.position.x > 41)
        {
            minmapCamera.transform.position = new Vector3(41, minmapCamera.transform.position.y, minmapCamera.transform.position.z);
        }
    }
}

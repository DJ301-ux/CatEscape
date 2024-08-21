using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//한글

public class ArrowController : MonoBehaviour
{
    public float moveSpeed = -0.01f;
    public float gizmos = 1f;
    public float radius = 1f;
    public Transform playerTrans;

    private void Start()
    {
        //길이
        float distanceY = playerTrans.position.y - this.transform.position.y;

        //this.radius;

        PlayerController playerController = this.playerTrans.gameObject.GetComponent<PlayerController>();

        //if(distanceY <= sumRadius)
    }

    void Update()
    {
        this.transform.Translate(0, moveSpeed, 0);

        bool = isCollieded = this.CheckCollsion;

        if (this.transform.position.y <= -6f)
        {
            Destroy(this.gameObject);
        }

        

            
    }
    private void OnDrawGizmos()
    {
        GizmosExtensions.DrawWireArc(this.transform.position, 360, gizmos);
    }
    //충돌 체크를 한 후에 충돌이 되었다면 bool타입을 true를 반환
    private bool CheckCollsion()
    {

    }
}

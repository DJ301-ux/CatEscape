using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//한글

public class PlayerController : MonoBehaviour
{
    public float gizmos = 1f;


    void Update()
    {
        bool isDownLeftArrow = Input.GetKeyDown(KeyCode.LeftArrow);

        bool isDownRightArrow = Input.GetKeyDown(KeyCode.RightArrow);

        if (isDownLeftArrow)
        {
            Debug.Log("왼쪽 화살표 키를 눌렀습니다");
            this.transform.Translate(-1, 0, 0);
        }else if (isDownRightArrow)
        {
            Debug.Log("오른쪽 화살표 키를 눌렀습니다");
            this.transform.Translate(1, 0, 0);
        }   
    }
    private void OnDrawGizmos()
    {
        GizmosExtensions.DrawWireArc(this.transform.position, 360, gizmos);
    }
}

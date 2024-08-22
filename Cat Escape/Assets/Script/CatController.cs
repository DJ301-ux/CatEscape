using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//한글

public class CatController : MonoBehaviour
{
    public Button btnR;

    // Start is called before the first frame update
    void Start()
    {
        //btnR.onClick.AddListener(RightButtonClick);

        btnR.onClick.AddListener(() => {
            Debug.Log("오른쪽 버튼 클릭됨");

            this.transform.Translate(1, 0, 0);
        });
    }

    public void LeftButtonClick()
    {
        Debug.Log("왼쪽 버튼 클릭됨");

        this.transform.Translate(-1, 0, 0);
    }

    public void RightButtonClick()
    {
        Debug.Log("오른쪽 버튼 클릭됨");
    }
}

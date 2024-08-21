using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//화살표 쏘기

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    private float elapsedTime;//경과시간

    private void Start()
    {
        //GameObject arrwGo = Object.Instantiate(arrowPrefab);
        //float randomPosX = Random.Range(-0.8f, 8.0f);
        //arrwGo.transform.position = new Vector3(randomPosX, 6.5f, 0);
    }

    private void Update()
    {
        this.elapsedTime += Time.deltaTime;

        Debug.Log($"{this.elapsedTime}초가 경과되었습니다");

        if (this.elapsedTime > 1f)
        {
            
            this.CreatArrow();
            this.elapsedTime = 0f;
        }
    }

    private void CreatArrow()
    {
        GameObject arrwGo = Object.Instantiate(arrowPrefab);
        float randomPosX = Random.Range(-8.0f, 8.0f);
        arrwGo.transform.position = new Vector3(randomPosX, 6.5f, 0);
    }
}

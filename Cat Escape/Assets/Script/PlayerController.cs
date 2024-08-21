using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float radius = 1f;
    public int hp;
    public int maxHp;
    public GameDirector gameDirector;

    private void Start()
    {
        this.maxHp = 100;
        this.hp = 100;
        Debug.Log($"플레이어의 체력 : {this.hp}/{this.maxHp}");
    }

    void Update()
    {
        bool isDownLeftArrow = Input.GetKeyDown(KeyCode.LeftArrow);

        bool isDownRightArrow = Input.GetKeyDown(KeyCode.RightArrow);

        if (isDownLeftArrow)
        {
            Debug.Log("왼쪽 화살표 키를 눌렀습니다.");
            this.transform.Translate(-1, 0, 0);
        }
        else if (isDownRightArrow)
        {
            Debug.Log("오른쪽 화살표 키를 눌렀습니다.");
            this.transform.Translate(1, 0, 0);
        }


    }

    private void OnDrawGizmos()
    {
        GizmosExtensions.DrawWireArc(this.transform.position, 360, radius);
    }

    public void HitDamage(float damage)
    {
        this.hp -=(int)damage;
        float fillAmount = (float)this.hp / this.maxHp;
        this.gameDirector.UpdateHpGauge(fillAmount);
    }
}
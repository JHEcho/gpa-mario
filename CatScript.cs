using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{

    GameObject Cha;
    GameObject Cat;
    GameObject footprint;

    int disx;
    int disy;
    float speed = 3; // 게임 테스트 후 속도 조정
    float k = 4; // 회피 거리 상수

    private float dist(GameObject Cha, GameObject Cat) // 거리 계산
    {
        Vector3 a = Cha.transform.position;
        Vector3 b = Cat.transform.position;

        disx = (int)((a.x - b.x) * 100);
        disy = (int)((a.y - b.y) * 100);
        float dis = (disx * disx + disy * disy) / 10000f;


        return dis;
    }

    private void Translate(int x)
    {
        if (x == 1)
            this.transform.Translate(speed * Time.deltaTime, 0, 0);

        else if (x == 2)
            this.transform.Translate(-speed * Time.deltaTime, 0, 0);

        else if (x == 3)
            this.transform.Translate(0, speed * Time.deltaTime, 0);

        else if (x == 4)
            this.transform.Translate(0, -speed * Time.deltaTime, 0);
        //else 0일경우 이동X 가만히 서있는 경우

    }

    //충돌검사 함수

    private int abs(int x)
    {
        int a;
        if (x < 0)
            a = -x;
        else
            a = x;

        return a;
    }

    IEnumerator FootPrint() // 발자국 생성 함수
    {
        while(true)
        {
            Instantiate(footprint, Cat.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }

    }

    // Use this for initialization
    void Start()
    {
        Cat = GameObject.Find("Cat");
        Cha = GameObject.Find("Player");
        footprint = GameObject.Find("FootPrint");

        StartCoroutine(FootPrint()); // 발자국 생성 시작 코루틴
    }

    float time = -1;
    int act = 0;
    // Update is called once per frame
    void Update()
    {


        if (dist(Cha, Cat) > k) // 일정거리 밖 랜덤 이동
        {
            if (time < 0)
            {
                time = Random.Range(0.5f, 1); // 0.5~2초 동안 한가지 행동만 수행
                act = Random.Range(0, 4); // 5가지 케이스 중 하나를 선택
            }
            else
            {
                Translate(act);
                time -= Time.deltaTime;
            }

        }

        else // 일정거리 안 회피
        {

            if (abs(disx) > abs(disy))
            {

                if (disx > 0)
                    this.transform.Translate(-speed * Time.deltaTime, 0, 0);
                else
                    this.transform.Translate(speed * Time.deltaTime, 0, 0);

            }
            else
            {
                if (disy > 0)
                    this.transform.Translate(0, -speed * Time.deltaTime, 0);
                else
                    this.transform.Translate(0, speed * Time.deltaTime, 0);
            }

        }

    }
}

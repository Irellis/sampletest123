using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherTrigger : MonoBehaviour
{
   
    public GameObject bullet;
    public Transform firePos;
    public float Attack_Gauge = 3.0f;
    public bool M_on = false;
    public bool A_on = false;
    GameManager gamemanager;

    // Use this for initialization
    void Start()
    {
        //gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        /* if(gamemanager.monsteralive==false)
         {
             M_on = false;
         }*/
        gamemanager = GameManager.GetInstance();

        if (A_on == false)
        {
            Attack_Gauge = Attack_Gauge + Time.deltaTime * 1;
            if (Attack_Gauge >= 3.0f)
            {
                A_on = true;
                Attack_Gauge = 0f;
            }
        }


        if (M_on == true && A_on == true)
        {
            Fire();
            A_on = false;
        }
    }

    void Fire()
    {
        CreateBullet();
        Debug.Log("화살생성!");
    }

    void CreateBullet()
    {
        Instantiate(bullet, firePos.position, firePos.rotation);
    }

    private void OnTriggerStay(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "E1")
        {
            Debug.Log("플레이어가 몬스터감지");
            M_on = true;
        }
    }
    private void OnTriggerExit(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "E1")
        {
            Debug.Log("몬스터가나감");
            M_on = false;
        }
    }
}
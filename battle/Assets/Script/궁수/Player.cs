using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float P_Mhp = 100;
    public float P_hp = 0;
    public float P_Damege = 5;
    float hpbar;

    public GameObject Hpbar;
    EnemyStatus enemystatus;
    GameManager gamemanager;
    static Player m_Instance;
    bool PlayerIdle = true;

    // Use this for initialization
    void Start()
    {
        m_Instance = this;

        P_hp = P_Mhp;
    }

    // Update is called once per frame
    void Update()
    {
        if(gamemanager==null)
           gamemanager = GameManager.GetInstance(); //게임매니저 스크립트불러오기


        if (gamemanager.monsteralive == true)
        {
            enemystatus = EnemyStatus.GetInstance();
        }

       
        hpbar = P_hp / P_Mhp;
        Debug.Log("남은hp퍼센트" + hpbar);
        Hpbar.transform.localScale = new Vector3(0.2f * hpbar, 0.1f, 0.1f);
    }

    public static Player GetInstance() //싱글톤 생성자
    {
        return m_Instance;
    }

    void Colorchange()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.white;
        PlayerIdle = true;
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "E1" && PlayerIdle==true)
        {
            P_hp = P_hp - enemystatus.M_Damege;
            PlayerIdle = false;
            Debug.Log("몬스터가떄림");
            this.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log(P_hp + "플레이어 체력");

            Debug.Log("플레이어red");
            Invoke("Colorchange", 1f);
        }
    }
}

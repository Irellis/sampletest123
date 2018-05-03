using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool monsteralive = false;
    public Transform Monsterpos;
    public GameObject enemy;
    ScrollMove scrollmove;
    static GameManager m_Instance; //게임매니저 싱글톤
    
	void Start ()
    {
        m_Instance = this;

        scrollmove = GameObject.Find("BackGround").GetComponent<ScrollMove>();
        MonsterSponner();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public static GameManager GetInstance() //싱글톤 생성자
    {
         return m_Instance;
    }

    public void m_spone()
    {
        monsteralive = true;
        scrollmove.scrollSpeed = 0f;

        Instantiate(enemy, Monsterpos.position, Monsterpos.rotation);
        Debug.Log("몬스터스폰!");
    }

    public void MonsterSponner()
    {
        if (monsteralive == false)
        {
            scrollmove.scrollSpeed = 0.1f;
            Invoke("m_spone", 3f);
        }
    }
}

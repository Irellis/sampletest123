using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool monsteralive = false;
    public Transform Monsterpos;
    public GameObject enemy;
    ScrollMove scrollmove;
	// Use this for initialization
	void Start ()
    {
        scrollmove = GameObject.Find("BackGround").GetComponent<ScrollMove>();
        MonsterSponner();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void m_spone()
    {
        scrollmove.scrollSpeed = 0f;

        Instantiate(enemy, Monsterpos.position, Monsterpos.rotation);
        Debug.Log("몬스터스폰!");
        monsteralive = true;
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

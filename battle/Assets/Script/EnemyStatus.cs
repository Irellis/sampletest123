using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour {

    public int M_hp = 20;
    public int M_Damege = 5;

    Player player;
    GameManager gameManager;

	// Use this for initialization
	void Start () {
       player = GameObject.Find("Player").GetComponent<Player>();
       gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   public  void enemyhpdown()
    {
        M_hp = M_hp - player.P_Damege;
        if (M_hp <= 0)
        {
            gameManager.monsteralive = false;
            Destroy(gameObject);
            Debug.Log("몬스터삭제");
            gameManager.MonsterSponner();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour {

    public float M_hp = 20;
    public float M_Damege = 5;
    public float enemyspeed = 2f;

    Player player;
    GameManager gamemanager;
    static EnemyStatus m_Instance; //게임매니저 싱글톤

    // Use this for initialization
    void Start () {
        m_Instance = this;
    }
	
	// Update is called once per frame
	void Update () {
        player = Player.GetInstance();
        gamemanager = GameManager.GetInstance();
        transform.Translate(Vector3.left * enemyspeed * Time.deltaTime);
    }

    public static EnemyStatus GetInstance() //싱글톤 생성자
    {
        return m_Instance;
    }

    public  void enemyhpdown()
    {
        M_hp = M_hp - player.P_Damege;
        if (M_hp <= 0)
        {
            gamemanager.monsteralive = false;
            Destroy(gameObject);
            Debug.Log("몬스터삭제");
            gamemanager.MonsterSponner();
        }
    }
}

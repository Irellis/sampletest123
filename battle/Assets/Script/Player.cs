using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    public int P_hp = 100;
    public int P_Damege = 5;
    EnemyStatus enemystatus;
    GameManager gameManager;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.monsteralive == true)
        {
            enemystatus = GameObject.Find("enemy(Clone)").GetComponent<EnemyStatus>();
        }
    }

    void Colorchange()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "E1")
        {
            P_hp = P_hp - enemystatus.M_Damege;
            Debug.Log("몬스터가떄림");
            this.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log(P_hp + "플레이어 체력");

            Debug.Log("플레이어red");
                
            Invoke("Colorchange", 1f);
            
        }
    }
}

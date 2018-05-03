using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPbar : MonoBehaviour {

    Player player;
    float hpbar;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        player = Player.GetInstance();

        hpbar = player.P_hp/player.P_Mhp;
        Debug.Log("남은hp퍼센트" + hpbar);
        this.transform.localScale = new Vector3(0.2f*hpbar,0.1f,0.1f);
	}
}

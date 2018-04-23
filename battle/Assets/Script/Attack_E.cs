using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_E : MonoBehaviour
{
    public GameObject Enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if(other.gameObject.tag == "W1")
        {
            Debug.Log("몬스터피격");
            Enemy.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Enemy.GetComponent<Rigidbody>().AddForce(7,5f, 0,ForceMode.VelocityChange);
            Enemy.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (other.gameObject.tag == "P1")
        {
            Debug.Log("몬스터가플레이어공격");
            Enemy.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Enemy.GetComponent<Rigidbody>().AddForce(7, 5f, 0, ForceMode.VelocityChange);
            
        }

        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("착지완료");
            Enemy.GetComponent<MeshRenderer>().material.color = Color.white;
        }

        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("몬스터가화살에맞음");
            Enemy.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Enemy.GetComponent<Rigidbody>().AddForce(7, 5f, 0, ForceMode.VelocityChange);
            Enemy.GetComponent<MeshRenderer>().material.color = Color.red;
            Destroy(other.gameObject);

        }
    }
}

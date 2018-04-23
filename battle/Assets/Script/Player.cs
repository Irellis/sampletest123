using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public GameObject m_Player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Colorchange()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "E1")
        {
            Debug.Log("몬스터가떄림");
            this.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("플레이어red");
            Invoke("Colorchange", 1f);


        }
    }
}

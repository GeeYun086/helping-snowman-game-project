using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    //public GameManager gameManager;
    //private Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        //rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerShrink(collision.gameObject); // 적에 부딪히면 플레이어 크기 감소
            Debug.Log("충돌, 플레이어 크기 20% 감소");
        }
    }

    void PlayerShrink(GameObject player)
    {
        Vector3 currentScale = player.transform.localScale;
        currentScale *= 0.9f; // 플레이어의 크기를 0.9배로 줄임
        player.transform.localScale = currentScale;
    }
    */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScripts : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;
    GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        rb.velocity = Vector2.down * (speed + gameManager.speedMultiplier);
    }


}

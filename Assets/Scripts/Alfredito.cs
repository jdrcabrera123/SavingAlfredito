using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alfredito : MonoBehaviour
{
    [SerializeField] PlayerLifeHearts playerLifeHearts;
    [SerializeField] Animator animatorAlfredito;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip alfreditoShock;

    BoxCollider2D alfreditoCollider;

    private void Start()
    {
        alfreditoCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rock"))
        {

            animatorAlfredito.SetTrigger("IsShock");
            playerLifeHearts.ReduceHearts(1);
            audioSource.PlayOneShot(alfreditoShock, 1f);
        }
    }

    private void Update()
    {
        if (playerLifeHearts.health == 0)
        {
            Debug.Log("Is dead");

            alfreditoCollider.enabled = false;
            animatorAlfredito.SetTrigger("IsDead");


        }
    }
}

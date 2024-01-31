using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Rock : MonoBehaviour
{

    [SerializeField] Animator animatorRock;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            animatorRock.SetTrigger("IsHit");

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Destroy(gameObject);
    }

}

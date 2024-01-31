using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ClickableObject : MonoBehaviour
{

  [SerializeField] Animator animationRock;
  [SerializeField] TextMeshProUGUI scoreText;
  int scoreValue = 0;
  int points = 10;

  [SerializeField] AudioSource audioSource;
  [SerializeField] AudioClip audioClip;

  public LayerMask mask;

 
  private void Update()
  {

    if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
    {
      Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


      RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, Mathf.Infinity, mask);

      if (hit.collider != null)
      {
        Debug.Log("Clicked");
        Animator hitAnimator = hit.collider.GetComponent<Animator>();
        if (hitAnimator != null)
        {
          hitAnimator.SetTrigger("IsHit");
          audioSource.PlayOneShot(audioClip, 1f);
        }

        scoreValue += points;
        scoreText.text = scoreValue.ToString();
       

        Destroy(hit.collider.gameObject, 0.1f);
      }
    }
  }
}

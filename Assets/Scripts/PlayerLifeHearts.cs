using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLifeHearts : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int numberOfHearts;

    [SerializeField] UnityEngine.UI.Image[] hearts;
    [SerializeField] Sprite fullHeart;
    [SerializeField] Sprite emptyHeart;
   

    void Update()
    {

        if (health > numberOfHearts)
        {
            health = numberOfHearts;

        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (health == 0)
        {
            
            StartCoroutine(NoLife());
        }
    }

    public void ReduceHearts(int reduceLife)
    {
        health = health - reduceLife;

    }

    IEnumerator NoLife()
    {

        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene(2);
    }
}

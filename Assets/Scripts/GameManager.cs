using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject spawnManager;
    [SerializeField] GameObject[] spawnPoints;
    [SerializeField] float timer;
    [SerializeField] public float timeBetweenSpawns;
    public float speedMultiplier;



    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;




    private void Update()
    {

        speedMultiplier += Time.deltaTime * 0.3f;
        timer += Time.deltaTime;
        timeBetweenSpawns -= Time.deltaTime * 0.05f;


        if (timer > timeBetweenSpawns)
        {
            audioSource.PlayOneShot(audioClip, 1f);
            timer = 0;
            int randomNumber = Random.Range(0, spawnPoints.Length);
            Instantiate(spawnManager, spawnPoints[randomNumber].transform.position, Quaternion.identity);
        }
    }
}
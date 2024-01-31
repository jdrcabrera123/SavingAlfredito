using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] public float speedParallax = 0.05f;

    Renderer rendererParallax;

    private void Awake()
    {
        rendererParallax = GetComponent<Renderer>();
    }

    private void Update()
    {
        //speedParallax += Time.deltaTime * 0.005f;
        rendererParallax.material.mainTextureOffset = new Vector2(Time.time * speedParallax, 0);
    }
}

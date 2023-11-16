using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private Vector2 scrollVelocity;

    private Material material;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    private IEnumerator Start()
    {
        //while (GameManager.GameState != GameState.GameOver)
        {
            material.mainTextureOffset += scrollVelocity * Time.deltaTime;

            yield return null;
        }
    }
}

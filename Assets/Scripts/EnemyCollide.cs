﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyCollide : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }

}
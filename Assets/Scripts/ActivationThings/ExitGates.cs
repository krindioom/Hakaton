using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGates : Gate
{
    [SerializeField]
    string next_scene;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            ExitSequence();
        }
    }
    public void ExitSequence()
    {
        SceneManager.LoadScene(next_scene);
    }
}

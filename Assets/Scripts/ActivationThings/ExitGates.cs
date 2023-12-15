using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGates : Gate
{
    [SerializeField]
    string next_scene;
    public void ExitSequence()
    {
        SceneManager.LoadScene(next_scene);
    }
}

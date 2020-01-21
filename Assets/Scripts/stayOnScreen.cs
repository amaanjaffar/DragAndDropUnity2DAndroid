using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stayOnScreen : MonoBehaviour
{
    private Scene level;

    void Start()
    {
        level = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void OnBecameInvisible()
    {
        SceneManager.LoadScene(level.name);
    }
}

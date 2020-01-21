using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    private int nextScenetoLoad;
    void Start()
    {
        nextScenetoLoad = SceneManager.GetActiveScene().buildIndex + 1;
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextScenetoLoad);

    }
}

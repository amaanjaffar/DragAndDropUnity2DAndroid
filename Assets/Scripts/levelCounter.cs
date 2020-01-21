using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelCounter : MonoBehaviour
{
    private Scene level;
    private Text levelCount;
    void Start()
    {
        level = SceneManager.GetActiveScene();
        levelCount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        levelCount.text = " " + level.name;
    }
}

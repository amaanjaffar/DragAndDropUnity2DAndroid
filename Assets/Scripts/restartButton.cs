using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartButton : MonoBehaviour
{

    private Scene level;

    // Start is called before the first frame update
    void Start()
    {
        level = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    public void RestartGame()
    {
            SceneManager.LoadScene(level.name);

    }
}

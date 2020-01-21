using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartTrigger : MonoBehaviour
{

    private Scene level;
      
    // Start is called before the first frame update
    void Start()
    {
        level = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "car")
        {
            SceneManager.LoadScene(level.name);
        }
        else
        {

        }

    }
}

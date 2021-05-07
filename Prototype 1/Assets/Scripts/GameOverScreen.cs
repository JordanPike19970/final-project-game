using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "ObstacleCollider")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

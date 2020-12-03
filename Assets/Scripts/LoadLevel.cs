using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class LoadLevel : MonoBehaviour
{
    public int levelNumber;
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(levelNumber);
        return;
    }
}

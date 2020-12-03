using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class NextLevel1 : MonoBehaviour
{
    string filename = "Score.txt";
    int InputScore = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(2);
        //var sr = File.Create(filename);
        var sr = File.AppendText(filename);
        sr.WriteLine(InputScore);
        return;
    }
}

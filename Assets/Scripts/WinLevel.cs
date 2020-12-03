using System.Collections;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    public Collider2D body;
    private void OnTriggerEnter2D(Collider2D body)
    {
        GameObject.Find("Player").SendMessage("Finish");
    }
}

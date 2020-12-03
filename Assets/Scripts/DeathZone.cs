using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform SpawnPoint;
    public Animator animator;
    public AnimationClip death;
    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(wait());
    }

    IEnumerator wait ()
    {
        animator.SetBool("IsDead", true);
        animator.Play(death.name);
        yield return new WaitForSeconds(1);
        animator.SetBool("IsDead", false);
        Player.transform.position = SpawnPoint.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettlementAirlockDoor : MonoBehaviour {

    private Animator animator;
    private AudioSource audioSource;
    private bool isLocked;
    
	void Start ()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        animator.speed = 0.28f;
    }

    void OnTriggerStay (Collider other)
    {
        if (Input.GetKeyDown(KeyCode.A) && other.CompareTag("Player") && !animator.GetBool("Open"))
        { 
            OpenDoor();
        }
    }

    public void OpenDoor()
    {
        if (!isLocked)
        {
            animator.SetBool("Open", true);
            audioSource.Play();
        }
    }

    public void CloseDoor()
    {
        if (!isLocked)
        {
            animator.SetBool("Open", false);
            audioSource.Play();
        }
    }

    public void LockDoor()
    {
        isLocked = true;
    }
}

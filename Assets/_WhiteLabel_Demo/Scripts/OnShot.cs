using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class OnShot : MonoBehaviour
{
    public GameObject parent;
    public GameObject objectToHide;
    public GameObject objectPrefab;
    
    private Animator animator;
    private Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = parent.GetComponent<Animator>();
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }
    
    [Button()]
    public void PerformOnShot()
    {
        animator.enabled = false;
        rigidbody.isKinematic = false;
        
        Instantiate(objectPrefab, transform.position, transform.localRotation);
        // Destroy(objectToHide);
        objectToHide.SetActive(false);
    }
}

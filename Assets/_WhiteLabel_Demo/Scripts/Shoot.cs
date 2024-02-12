using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootingOrigin;
    public LayerMask shootableMask;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(shootingOrigin.position, shootingOrigin.forward, out hit, Mathf.Infinity,
                    shootableMask))
            {
                hit.collider.gameObject.GetComponent<OnShot>().PerformOnShot();

            }
        }
    }
}
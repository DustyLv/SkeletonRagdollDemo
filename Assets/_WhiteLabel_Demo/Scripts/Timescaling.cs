using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timescaling : MonoBehaviour
{
    public float scale = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

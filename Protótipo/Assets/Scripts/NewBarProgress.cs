using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBarProgress : MonoBehaviour
{
    public float maxHeight = 1f;           
    public float decreaseRate = 0.1f;     
    public float delayBeforeStart = 2f;   

    private float currentHeight;
    private float elapsedTime = 0f;         

    void Start()
    {
        
        currentHeight = maxHeight;

        
        transform.localScale = new Vector3(transform.localScale.x, maxHeight, transform.localScale.z);

       
        transform.localPosition = new Vector3(transform.localPosition.x, maxHeight / 2f, transform.localPosition.z);
    }

    void Update()
    {
        
        elapsedTime += Time.deltaTime;

        
        if (elapsedTime >= delayBeforeStart)
        {
            
            currentHeight -= decreaseRate * Time.deltaTime;
            currentHeight = Mathf.Clamp(currentHeight, 0, maxHeight);

            
            UpdateScaleAndPosition();

            
            if (currentHeight <= 0)
            {
                enabled = false; 
            }
        }
    }

    void UpdateScaleAndPosition()
    {
       
        transform.localScale = new Vector3(transform.localScale.x, currentHeight, transform.localScale.z);

       
        transform.localPosition = new Vector3(transform.localPosition.x, currentHeight / 2f, transform.localPosition.z);
    }
}
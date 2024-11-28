using Unity.VisualScripting;
using UnityEngine;

public class HandSimulator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // trigger detection of the object
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        // Verify that the object is a sound player
        if (other.gameObject.GetComponent<PlaySound>() != null)
        {
            // Play the sound
            other.gameObject.GetComponent<PlaySound>().OnPointerClick(null);
        }
    }
}

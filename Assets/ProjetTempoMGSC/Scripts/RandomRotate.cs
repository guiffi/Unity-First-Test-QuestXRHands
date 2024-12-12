using UnityEngine;

public class RandomRotate : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // random start orientation
    }

    void Update()
    {
        // random rotation on all axis
        transform.Rotate(new Vector3(UnityEngine.Random.Range(-1, 1),UnityEngine.Random.Range(-1, 1), UnityEngine.Random.Range(-1, 1)));
    }

}

using UnityEngine;

public class Driver : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float moveSpeed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.5f);
        transform.Translate(0, moveSpeed, 0);
    }
}

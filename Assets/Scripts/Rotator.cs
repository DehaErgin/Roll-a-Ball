using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3(15, 30, 45);
        transform.Rotate(vector * Time.deltaTime);
    }
}

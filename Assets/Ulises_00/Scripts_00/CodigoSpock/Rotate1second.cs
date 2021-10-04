using UnityEngine;

public class Rotate1second : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        rotateSun();
    }

    void rotateSun() {
        // Rotate the object around its local X axis at 1 degree per second
        //transform.Rotate(Vector3.right * Time.deltaTime * speed);

        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * speed, Space.World);

        
    }
}
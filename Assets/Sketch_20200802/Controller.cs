using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject pivot;
    public float rotateSpeed= 20;
    
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            pivot.transform.Rotate(new Vector3(0, -rotateSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            pivot.transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
        }
    }
}

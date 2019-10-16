using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float speed = 5f;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveUP()
    {
        transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
    }
    public void MoveDown()
    {
        transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
    }
    public void MoveRight()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
    public void MoveLeft()
    {
        transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
    }
}

using UnityEngine;
using System.Collections;
public class Move : MonoBehaviour
{
    public GameObject MCharacter;
    public int speedRotation = 3;
    public int speed = 5;
    
    public int jumpSpeed = 50;

    void Start()
    {
        MCharacter = (GameObject)this.gameObject;
       
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            MCharacter.transform.position += MCharacter.transform.forward * speed * Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            MCharacter.transform.position -= MCharacter.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            MCharacter.transform.Rotate(Vector3.down * speedRotation);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            MCharacter.transform.Rotate(Vector3.up * speedRotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MCharacter.transform.position += MCharacter.transform.up * jumpSpeed * Time.deltaTime;
        }
    }
}
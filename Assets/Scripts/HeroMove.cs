using UnityEngine;
using System.Collections;
public class HeroMove : MonoBehaviour
{
    public GameObject MCharacter;
    public float speedRotation;
    public float speed;
    public float jumpSpeed;

    void Start()
    {
        MCharacter = (GameObject)this.gameObject;
       
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            MCharacter.transform.position -= Vector3.left * speed*Time.deltaTime;
  
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            MCharacter.transform.position -= Vector3.right * speed* Time.deltaTime;
            MCharacter.transform.Rotate(Vector3.down * speedRotation);
        }
        if (Input.GetKey(KeyCode.W))
        {
            MCharacter.transform.position += Vector3.up * jumpSpeed * Time.deltaTime;
        }
       // if (MCharacter.transform.position.y > 0.629) gi();
        
    }

    void gi ()
    {
      //  while(MCharacter.transform.position.y > 0.629)
            MCharacter.transform.position -= Vector3.up * Time.deltaTime;
    } 
}


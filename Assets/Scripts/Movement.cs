using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float tspeed = 10f;
    [SerializeField] private float rspeed = 25f;
    private bool canJump = true;
    
    Rigidbody rb;
    [SerializeField] float jumpForce = 10.0f;
    Vector3 originalPos;
    Vector3 originalRot;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {

        float translation = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");


        translation = translation * tspeed * Time.deltaTime;
        rotation = rotation * rspeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);


        if(canJump == true && Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
        }

        if(Input.GetKeyDown(KeyCode.R)){
        gameObject.transform.position = originalPos;
        gameObject.transform.rotation = Quaternion.Euler(0,0,0);

        }

        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "Ground Plane"){
            canJump = true;
        }
    }
}
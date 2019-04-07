using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    [SerializeField] private MeshCollider collider;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 tilt;
    [SerializeField] private Boundary boundary;

    private Rigidbody rb;
    private float moveHorizontal, moveVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.velocity = movement * speed;
        rb.rotation = Quaternion.Euler(moveVertical * tilt.x, 0, moveHorizontal * -tilt.y);
        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            transform.position.y,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );
    }
}

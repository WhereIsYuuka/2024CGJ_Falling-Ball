using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    public Transform player;
    public Transform playerObj;
    public Transform orientation;
    public Rigidbody rb;

    public float rotationSpeed = 5.0f; // 控制旋转的速度
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 viewDir = player.position - new Vector3(transform.position.x, player.position.y, transform.position.z);
        orientation.forward = viewDir.normalized;

        // 获取玩家输入
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = orientation.forward * verticalInput + orientation.right * horizontalInput;

        // 旋转角色
        if(direction != Vector3.zero)
            playerObj.forward = Vector3.Slerp(playerObj.forward, direction.normalized, Time.deltaTime * rotationSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float speed = 5.0f;
    public float rotationSpeed = 5.0f; // 控制旋转的速度
    private float minY = -10f; // 限制向下旋转的最小角度
    private float maxY = 20f; // 限制向上旋转的最大角度
    private float currentRotationX = 0f; // 当前绕X轴的旋转角度

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 target = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
        transform.position = smoothedPosition;

        // 获取鼠标输入来旋转摄像机
        // float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        // float mouseY = -Input.GetAxis("Mouse Y") * rotationSpeed; // 取反，因为鼠标向上移动时我们希望摄像机向下旋转

        // 累计旋转角度，并限制上下旋转角度
        // currentRotationX = Mathf.Clamp(currentRotationX + mouseY, minY, maxY);

        // 应用旋转
        // transform.LookAt(player);
        
        // player.Rotate(Vector3.up * mouseX); // 左右旋转角色
        // transform.localEulerAngles = new Vector3(currentRotationX, transform.localEulerAngles.y, 0); // 上下旋转摄像机
    }
}

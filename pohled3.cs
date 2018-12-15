using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohled3 : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public Transform DivatNa;
    public Transform rotace;
    public float vzdalenost = 10.0f;

    private float soucasnyX = 0.0f;
    private float soucasnyY = 20.0f;

    private void Start()
    {
        rotace = transform;
    }

    private void Update()
    {
        soucasnyX += Input.GetAxis("Mouse X");
        soucasnyY += Input.GetAxis("Mouse Y");

        soucasnyY = Mathf.Clamp(soucasnyY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -vzdalenost);
        Quaternion rotation = Quaternion.Euler(soucasnyY, soucasnyX, 0);
        rotace.position = DivatNa.position + rotation * dir;
        rotace.LookAt(DivatNa.position);
    }
}

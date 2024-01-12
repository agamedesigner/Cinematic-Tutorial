using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterkontrol : MonoBehaviour
{
    public float speed = 5.0f; // Karakterin yürüme hýzý
    public float rotationSpeed = 180.0f; // Karakterin dönme hýzý

    void Update()
    {
        // Yürüme ve dönme kontrolleri
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            // Karakterin yönünü belirleme ve hareket ettirme
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);

            transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}

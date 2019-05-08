using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kan användas till main menu också
public class CameraController : MonoBehaviour
{

    [SerializeField]
    [Header("Camera Settings")]
    public Camera adjustCamera;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float transitionSpeedIsometric;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float transitionSpeedThirdPerson;

    [SerializeField]
    private float rotationSpeed = 1f;

    [SerializeField]
    private Transform isoView;
    private Vector3 currentAngle;
    private Vector3 viewOffset = new Vector3(10f, 10f, 3f);


    private void Start()
    {
    }

    private void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, isoView.position, transitionSpeedIsometric * Time.deltaTime);

        CameraRotation();
    }

    private void CameraRotation()
    {

            currentAngle = new Vector3(
                    Mathf.LerpAngle(transform.rotation.eulerAngles.x, transform.eulerAngles.x, Time.deltaTime * transitionSpeedIsometric),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.y, transform.eulerAngles.y, Time.deltaTime * transitionSpeedIsometric),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.z, transform.eulerAngles.z, Time.deltaTime * transitionSpeedIsometric));
     

        transform.eulerAngles = currentAngle;
    }
}

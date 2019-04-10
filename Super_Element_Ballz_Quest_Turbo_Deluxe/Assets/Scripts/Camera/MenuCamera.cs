using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]
    private float transitionSpeed;

    [Header("Checkpoints for camera")]
    public Transform[] views;

    private Transform currentViewTransform;
    private Vector3 currentAngle;
    private int activeView;

    // Start is called before the first frame update
    private void Start()
    {
        currentViewTransform = views[0];
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            activeView--;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            activeView++;
        }
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        currentViewTransform = views[activeView];
        transform.position = Vector3.Lerp(transform.position, currentViewTransform.position, transitionSpeed * Time.deltaTime);

        currentAngle = new Vector3(
                    Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentViewTransform.eulerAngles.x, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentViewTransform.eulerAngles.y, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentViewTransform.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;
    }
}

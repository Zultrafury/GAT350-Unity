using Unity.Cinemachine;
using UnityEngine;

public class ViewToggle : MonoBehaviour
{
    public CinemachineCamera cam;

    private bool toggled;

    private Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = cam.Target.TrackingTarget;
        toggled = false;
        cam.Target.TrackingTarget = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (toggled)
            {
                cam.Target.TrackingTarget = null;
                toggled = false;
            }
            else
            {
                cam.Target.TrackingTarget = target;
                toggled = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroHeadAndroid : MonoBehaviour
{

#if UNITY_ANDROID || UNITY_IOS

    private float initialYAngle = 0f;
    private float appliedGyroYAngle = 0f;
    private float calibrationYAngle = 0f;
    private Quaternion PrevRotacion = Quaternion.identity;
    private Transform t;
      
    void Update()
    {
    
        ApplyGyroRotation();
        ApplyCalibration();

        transform.rotation = t.rotation;

    }
    void Start()
    {

        t = transform;
        Input.gyro.enabled = true;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.orientation = ScreenOrientation.LandscapeLeft;   
        Application.targetFrameRate = 60;

    }


    public void CalibrateYAngle()
    {
        calibrationYAngle = appliedGyroYAngle - initialYAngle; // Offsets y angle in case it wasn‘t
    }

    bool dif(float val, float val2, float tolerancia, ref float vari)
    {

        vari = Mathf.Abs(Mathf.Abs(val) - Mathf.Abs(val2));
        bool res = (vari > tolerancia);
        return res;
    }

    void ApplyGyroRotation()
    {
        t.rotation = Input.gyro.attitude;
        t.Rotate(0f, 0f, 180f, Space.Self); //Swap “handedness“ ofquaternionfromgyro.
        t.Rotate(90f, 180f, 0f, Space.World); //Rotate to make sense as a camera pointing out the back
        appliedGyroYAngle = t.eulerAngles.y; // Save the angle around y axis for use in calibration.

    }

    void ApplyCalibration()
    {
        t.Rotate(0f, -calibrationYAngle, 0f, Space.World); // Rotates y angle back however much it deviated
    }
#endif
}
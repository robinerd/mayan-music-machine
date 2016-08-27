using UnityEngine;
using System.Collections;

public class LevelSpin : MonoBehaviour {

    public float beatsPerMinute;
    public float beatsPerRevolution;

    float secondsPerRevolution;
    float neededAngularVelocity;

    // Use this for initialization
    void Start () {
        float secondsPerBeat = 60.0f / beatsPerMinute;
        secondsPerRevolution = secondsPerBeat * beatsPerRevolution;
        neededAngularVelocity = 360.0f / secondsPerRevolution;
        GetComponent<Rigidbody2D>().angularVelocity = neededAngularVelocity;
	}
	
	// Update is called once per frame
	void Update () {
        float seconds = Time.timeSinceLevelLoad;

        // Wrap the absolute music time into the revolution time interval.
        while(seconds > secondsPerRevolution)
        {
            seconds -= secondsPerRevolution;
        }
        float targetRevolutionProgress = seconds / secondsPerRevolution;
        float targetAngle = 360.0f * targetRevolutionProgress;

        float angle = GetComponent<Rigidbody2D>().rotation;
        while (angle < 0.0f)
            angle += 360.0f;
        while (angle > 360.0f)
            angle -= 360.0f;

        Debug.Log(targetAngle + " , " + angle);

        if (angle < targetAngle - 0.2f)
            GetComponent<Rigidbody2D>().angularVelocity = neededAngularVelocity * 1.1f;
        else if (angle > targetAngle + 0.2f)
            GetComponent<Rigidbody2D>().angularVelocity = neededAngularVelocity * 0.92f;

    }
}

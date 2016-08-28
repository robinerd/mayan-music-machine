using UnityEngine;
using System.Collections;

public class LevelSpin : MonoBehaviour {

    //set secondsPerRevolution instead, based on the length of the music file instead of calculating it, since the music program exports not the exactly correct tempo.
    //public float beatsPerMinute;
    //public float beatsPerRevolution;

    public float secondsPerRevolution;
    public AudioSource syncWithMusic;
    float neededAngularVelocity;

    // Use this for initialization
    void Start () {
        //float secondsPerBeat = 60.0f / beatsPerMinute;
        //secondsPerRevolution = secondsPerBeat * beatsPerRevolution;
        neededAngularVelocity = 360.0f / secondsPerRevolution;
        GetComponent<Rigidbody2D>().angularVelocity = neededAngularVelocity;
        Debug.Log("Revolution time: "+secondsPerRevolution);
	}
	
	// Update is called once per frame
	void Update () {
        float seconds = syncWithMusic.time;

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

        if (angle < targetAngle - 0.2f)
            GetComponent<Rigidbody2D>().angularVelocity = neededAngularVelocity * 1.3f;
        else if (angle > targetAngle + 0.2f)
            GetComponent<Rigidbody2D>().angularVelocity = neededAngularVelocity * 0.86f;

    }
}

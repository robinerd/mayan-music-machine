using UnityEngine;
using System.Collections;

public class BerryDoor : MonoBehaviour
{

    public Transform berryGroup;

    int prevBerriesLeft = -1;

    // Use this for initialization
    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
        CheckBerries();
    }

    public void CheckBerries()
    {
        int berriesLeft = 0;
        foreach(berry b in berryGroup.GetComponentsInChildren<berry>())
        {
            if (!b.isEaten)
            {
                berriesLeft++;
            }
        }
        if(berriesLeft != prevBerriesLeft)
        {
            GetComponentInChildren<TextMesh>().text = "" + berriesLeft;
        }
        if (berriesLeft == 0)
        {
            gameObject.SetActive(false);
        }
        prevBerriesLeft = berriesLeft;
    }
}

using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

    bool triggered = false;
    public float delay = 1.0f;
    public float shrinkTarget = 0.244f;
    public float shrinkTime = 1.6f;
    public GameObject currentLevel;
    public GameObject nextLevel;
    public AudioSource nextMusic;

    float startScale;
    float shrinkTimer = 0.0f;
    bool done = false;

	// Use this for initialization
	void Start () {
        startScale = currentLevel.transform.localScale.x; // assume quadradic scale
	}
	
	// Update is called once per frame
	void Update () {
	    if(triggered && !done)
        {
            if (delay > 0)
            {
                delay -= Time.deltaTime;
            }

            if(delay < 0)
            {
                shrinkTimer += Time.deltaTime;
                float shrinkProgress = shrinkTimer / shrinkTime;
                if(shrinkProgress < 1.0f)
                {
                    float newScale = Mathf.Lerp(startScale, shrinkTarget, shrinkProgress);
                    currentLevel.transform.localScale = new Vector3(newScale, newScale, 1.0f);
                    nextMusic.volume = shrinkProgress;
                }
                else
                {
                    EnableNextLevel();
                    done = true;
                }
            }
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            triggered = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    void DisableCurrentLevel()
    {
        
    }

    void EnableNextLevel()
    {
        nextLevel.SetActive(true);
        currentLevel.transform.parent = nextLevel.transform;
    }
}

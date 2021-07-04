using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int goalNumber;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager.gameManager.onScoreGoal += Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Destroy(other.gameObject);
            //add points to team score
        }
    }

    //public void Score(int teamNumber)
    //{
    //    Debug.Log("team " + teamNumber + " has scored");
    //  }
}

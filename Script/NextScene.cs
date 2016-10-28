using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

   
    void OnCollisionEnter2D(Collision2D coi)
    {
        Stat.CurrentState++;
        
       Application.LoadLevel(Stat.CurrentState);
    }

    void OnTriggerEnter2D(Collider2D coi)
    {
        Stat.CurrentState++;

        Application.LoadLevel(Stat.CurrentState);
    }

}

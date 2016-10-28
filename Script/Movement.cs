using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    GameObject thisCha;
	// Use this for initialization
	public Movement (GameObject Cha) {
        thisCha = Cha;
	}
	

  public void moveForward(int Speed)
    {
        thisCha.transform.rotation = Quaternion.Euler(0, 0, 0);
        thisCha.transform.Translate(Speed * Time.deltaTime, 0, 0);
    }

    public void moveBack(int Speed)
    {
        thisCha.transform.rotation = Quaternion.Euler(0, 180, 0);
        thisCha.transform.Translate(Speed * Time.deltaTime, 0, 0);
    }

}

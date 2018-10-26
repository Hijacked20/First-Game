using UnityEngine;

public class player_move : MonoBehaviour {
    public Rigidbody Rb;
    // Use this for initialization
    void Start()
    {
        Rigidbody.AddForce(0, 200, 500);
    }
	// Update is called once per frame
	void Update () {
		
	}
}

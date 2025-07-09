using UnityEngine;

public class Bus : Vehicle
{
    protected override void Move() {
        busName.text = "Bus";
        Debug.Log("Bus is moving on Button Press : B");
        base.Move();
    }

    //Inheritance
    protected override void Update() {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Move();
        }
    }
}

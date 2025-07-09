using UnityEngine;

public class Car : Vehicle
{
    protected override void Move() {
        busName.text = "Car";
        Debug.Log("Car is moving on Button Press : C");
        base.Move();
    }

    //Inheritance
    protected override void Update() {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Move();
        }
    }
}

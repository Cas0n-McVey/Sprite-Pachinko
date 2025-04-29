using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public int objectSpeed;
    public Vector3 direction;
    public bool goingRight = false;
    public float bounds = 30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("I AM CALLED ON START!", gameObject);
        goingRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * objectSpeed * Time.deltaTime);

        if (transform.position.x >= bounds && goingRight)
        {
            goingRight = false;
            objectSpeed = -objectSpeed;
        }
        else if (transform.position.x <= -bounds && goingRight == false)
        {
            goingRight = true;
            objectSpeed = -objectSpeed;
        }
    }
}

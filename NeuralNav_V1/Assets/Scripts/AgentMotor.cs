using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class AgentMotor : MonoBehaviour
{
    public float speed = 5f;

	void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float z = Input.GetAxis("Vertical");   // W/S or Up/Down

        Vector3 movement = new Vector3(x, 0f, z);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        
    }
}

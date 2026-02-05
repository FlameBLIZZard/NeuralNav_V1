using UnityEngine;

public class PrintPosition : MonoBehaviour
{
	void Start()
	{
		Debug.Log($"World Position -> X:{transform.position.x} Y:{transform.position.y} Z:{transform.position.z}");
	}
}

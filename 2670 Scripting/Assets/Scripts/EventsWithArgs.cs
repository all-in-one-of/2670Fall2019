using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsWithArgs : MonoBehaviour
{
	public UnityEvent<float> eventWithFloat;

	private void Start()
	{
		eventWithFloat.AddListener(delegate{PassFloat(10);});
	}

	// Use this for initialization
	void Update () {
		eventWithFloat.Invoke(10);
	}

	private void OnMouseDown()
	{
		eventWithFloat.RemoveListener(PassFloat);
	}

	public void PassFloat(float number)
	{
		print(number);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
	public Vector2 m_Position { get => transform.position; set => transform.position = value; }
	public Vector2 m_Velocity { get; set; } = Vector2.zero;
	public Vector2 m_Acceleration { get; set; } = Vector2.zero;
	public float m_Mass { get; set; } = 1;
	public void ApplyForce(Vector2 force)
	{
		m_Acceleration = force;
	}
}

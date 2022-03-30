using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulator : Singleton<Simulator>
{
	public List<Body> m_Bodies = new List<Body>();
	Camera m_ActiveCamera;

	private void Start()
	{
		m_ActiveCamera = Camera.main;
	}

	private void Update()
	{
		foreach(var body in m_Bodies)
		{
			Integrator.SemiImplicitEuler(body, Time.deltaTime);
		}
	}

	public Vector3 GetScreenToWorldPosition(Vector2 screen)
	{
		Vector3 world = m_ActiveCamera.ScreenToWorldPoint(screen);
		return new Vector3(world.x, world.y, 0);
	}
}

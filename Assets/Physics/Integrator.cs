using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Integrator
{
	public static void ExplicitEuler(Body body, float dt)
	{
		body.m_Position += body.m_Velocity * dt;
		body.m_Velocity += body.m_Acceleration * dt;
	}

	public static void SemiImplicitEuler(Body body, float dt)
	{
		body.m_Velocity += body.m_Acceleration * dt;
		body.m_Position += body.m_Velocity * dt;
	}
}

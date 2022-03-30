using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BodyCreator : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
	[SerializeField]
	private Body m_BodyPrefab;

	bool m_Action = false;
	bool m_Pressed = false;
	float m_Timer = 0;

	private void Update()
	{
		if(m_Action)
		{
			Vector3 postion = Simulator.Instance.GetScreenToWorldPosition(Input.mousePosition);
			Body body = Instantiate(m_BodyPrefab, postion, Quaternion.identity);
			body.ApplyForce(Random.insideUnitCircle.normalized);
			Simulator.Instance.m_Bodies.Add(body);
		}
	}

	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
		m_Action = true;
		m_Pressed = true;
	}

	void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
	{
		m_Action = false;
	}

	void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
	{
		m_Action = false;
	}
}

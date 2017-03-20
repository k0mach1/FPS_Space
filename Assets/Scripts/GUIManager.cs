﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {

	[SerializeField] private GameObject m_BulletUI;
	[SerializeField] private GameObject m_BulletBoxUI;
	[SerializeField] private GameObject m_PointUI;
	[SerializeField] private GameObject m_TimerUI;
	[SerializeField] private ScoreManager m_ScoreManager;
	[SerializeField] private GunController m_GunController;

	private float m_BulletNum;
	private float m_BulletBoxNum;
	private float m_TimeLimit = 90f;
	private float m_RemainingTime;
	private int m_Score;

	// Use this for initialization
	void Start () {
		m_RemainingTime = m_TimeLimit;
	}

	// Update is called once per frame
	void Update () {
		m_RemainingTime -= Time.deltaTime;
		m_BulletNum = m_GunController.m_CurrentBulletNum;
		m_BulletBoxNum = m_GunController.m_CurrentBulletBoxNum;
		m_Score = m_ScoreManager.m_GamePoint;
		m_BulletUI.GetComponent<Text>().text = "Bullet : " + m_BulletNum;
		m_BulletBoxUI.GetComponent<Text>().text = "BulletBox : " + m_BulletBoxNum;
		m_TimerUI.GetComponent<Text>().text = "Time : " + m_RemainingTime.ToString("f1");
		m_PointUI.GetComponent<Text>().text = "Pt : " + m_Score;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Taiko : MonoBehaviour {

	protected float speed = 200.0f;
	private Vector3 goalPos = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
		
	}

	public void SetGoalPos(GameObject baseLane){

		transform.SetParent(baseLane.transform);
		transform.localPosition = Vector3.zero;
		transform.localScale = Vector3.one;

		Vector3 basePos = baseLane.GetComponent<RectTransform>().localPosition;

		basePos.y = 0.0f;
		basePos.x += (baseLane.GetComponent<RectTransform>().sizeDelta.x / 2.0f);
		transform.localPosition = basePos;

		goalPos = baseLane.GetComponent<RectTransform>().localPosition;
		goalPos.x = 0.0f;
		goalPos.x -= (baseLane.GetComponent<RectTransform>().sizeDelta.x / 2.0f);
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 move = gameObject.GetComponent<RectTransform>().localPosition;
		move.x -= speed * Time.deltaTime;

		gameObject.GetComponent<RectTransform>().localPosition = move;

		if(gameObject.GetComponent<RectTransform>().localPosition.x < goalPos.x)
		{
			GameObject.Destroy(this.gameObject);
		}
	}

	void OnDestroy()
	{
		Call();
	}

	protected virtual void Call()
	{
		Debug.Log("ka");
	}

	//画面触った時にやるやつ
	protected void OnClick()
	{
		Call();
	}

}

using UnityEngine;
using System.Collections;

public class CookieScript : MonoBehaviour
{

	public AudioSource audioSourceToPlayOnClick;

	//private bool mouseWasDown = false;

	//public SpriteRenderer normalFrame;
	//public SpriteRenderer ClickFrame;

	//public GameObject underwearObject;
	//MeshRenderer underwearMeshRenderer;
	//public Material underwearNormalFrame;
	//public Material underwearClickFrame;

	public float ClickDuration = 1.0f;
	private float ClickEndTime = 0.0f;

	public Camera cam; 

	public bool ClickOn = false;

	// Use this for initialization
	void Start ()
	{
		//Debug.Log("VR Mission: " + GlobalInfo.VRMission);
		if (GlobalInfo.VRMission)
		{
			cam.backgroundColor = Color.yellow;
		}

		//underwearMeshRenderer = underwearObject.GetComponent<MeshRenderer>();

		//ClickFrame.color = new Color(1,1,1,0);
		//normalFrame.color = new Color(1,1,1,1);
	}

	public void Click()
	{
		audioSourceToPlayOnClick.PlayOneShot(audioSourceToPlayOnClick.clip);
		
		ClickEndTime = Time.time + ClickDuration;
		//ClickFrame.sortingOrder = 2;
		//normalFrame.sortingOrder = 0;
		//ClickFrame.color = new Color(1,1,1,1);
		//normalFrame.color = new Color(1,1,1,0);
		//underwearMeshRenderer.material = underwearClickFrame;
		ClickOn = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (ClickOn && Time.time > ClickEndTime)
		{
			//ClickFrame.sortingOrder = 0;
			//normalFrame.sortingOrder = 2;
			//ClickFrame.color = new Color(1,1,1,0);
			//normalFrame.color = new Color(1,1,1,1);
			//underwearMeshRenderer.material = underwearNormalFrame;
			ClickOn = false;
		}

		//if (Input.GetMouseButtonDown(0))
		//{
		//	Click();
		//}
	}
}

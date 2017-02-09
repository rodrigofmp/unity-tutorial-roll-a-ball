using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Chamado apos tudo que era para ter sido feito no update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}

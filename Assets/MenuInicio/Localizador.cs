using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Localizador : MonoBehaviour
{
	RectTransform myRectTransform; // UI
	Camera mainCamera;
	Color alpha; // temp color

	public Transform currentTarget;   // target
	public bool clampToScreen = true; // display offscreen target or not
	public float threshold = 10;      // sprite alpha control
	public Vector3 offset;

	[SerializeField]
	Vector2 clampBorderSize;

	void Awake()
	{
		myRectTransform = GetComponent<RectTransform>();
		mainCamera = Camera.main; // find the camera
	}

	void Update()
	{   // if the target has been destroyed, it disables the script and erases image
		if (currentTarget == null)
		{
			myRectTransform.GetComponent<Image>().color = new Color(0, 0, 0, 0);
			this.enabled = false;
		}

		Vector3 noClampPosition = mainCamera.WorldToScreenPoint(currentTarget.position + offset);
		// modify alpha according Z
		alpha = myRectTransform.GetComponent<Image>().color;
		alpha.a = noClampPosition.z / threshold;
		myRectTransform.GetComponent<Image>().color = alpha;

		Vector3 clampedPosition = new Vector3(Mathf.Clamp(noClampPosition.x, 0 + clampBorderSize.x, Screen.width - clampBorderSize.x), Mathf.Clamp(noClampPosition.y, 0 + clampBorderSize.y, Screen.height - clampBorderSize.y), noClampPosition.z);
		// display sprite on screen - or not
		myRectTransform.position = clampToScreen ? clampedPosition : noClampPosition;
	}
}

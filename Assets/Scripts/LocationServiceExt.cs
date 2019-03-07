using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// https://stackoverflow.com/questions/38828748/how-to-use-the-input-location-and-mock-location-in-the-unity-editor
/// </summary>
public class LocationServiceExt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public struct LocationInfoExt
{
    public float altitude { get; set; }
    public float horizontalAccuracy { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
    public double timestamp { get; set; }
    public float verticalAccuacy { get; set; }
}

public enum LocationServiceStatusExt
{
    Stopped = 0,
    Initializing = 1,
    Running = 2,
    Faild = 3
}

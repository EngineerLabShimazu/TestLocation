using UnityEngine;
using UnityEngine.UI;
using System;

public class LocationRenderer : MonoBehaviour {

    public LocationUpdator updater;
    public Text text;

    void Update()
    {
        text.text = updater.Status.ToString()
            + Environment.NewLine + "lat:" + updater.LocationInfo.latitude.ToString()
            + Environment.NewLine + "lng:" + updater.LocationInfo.longitude.ToString();

    }
}

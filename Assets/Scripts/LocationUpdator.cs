using System.Collections;
using UnityEngine;

public class LocationUpdator : MonoBehaviour {

    public float IntervalSecounds = 1.0f;
    public LocationServiceStatus Status;
    public LocationInfo LocationInfo;

    IEnumerator Start()
    {
        while (true)
        {
            this.Status = Input.location.status;
            if (Input.location.isEnabledByUser)
            {
                switch (this.Status)
                {
                    case LocationServiceStatus.Stopped:
                        Input.location.Start();
                        break;
                    case LocationServiceStatus.Running:
                        this.LocationInfo = Input.location.lastData;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Debug.Log("location is disabled by user");
            }

            yield return new WaitForSeconds(IntervalSecounds);
        }
    }
}

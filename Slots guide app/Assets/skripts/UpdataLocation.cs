using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdataLocation : MonoBehaviour
{
    public Text coordinates;
    private void Update()
    {
        coordinates.text = "Lat:" + Location.Instance.latitude.ToString() + "Long:" + Location.Instance.longitude.ToString();
    }
}

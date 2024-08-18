using System.Collections;
using UnityEngine;

public class AndroidPlugin : MonoBehaviour
{
    private IEnumerator Start()
    {
        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Vibration.Vibrate();
                Handheld.Vibrate();
            }

            yield return null;
        }
    }
}

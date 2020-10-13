using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Runtime.InteropServices;//Must be Defined

public class GetIdentertyControl : MonoBehaviour {

    // Use this for initialization
    public Text IDFA;
    public Text Verdorid;

    [DllImport("__Internal")]
    private static extern void _GetIDFA();

    public void GetIDFA(string str) {
        if (string.IsNullOrEmpty(str)) {
            Debug.Log("IDFA is NULL");
            return;
        }
        IDFA.text = str;
    }

    [DllImport("__Internal")]
    private static extern void _GetVerdorid();

    public void GetVerdorid(string str) {
        if (string.IsNullOrEmpty(str)) {
            Debug.Log("Verdorid is NULL");
            return;
        }
        Verdorid.text = str;
    }
    public void OnClickButton() {
        if (Application.platform != RuntimePlatform.OSXEditor) {
            _GetVerdorid();
            _GetIDFA();
        }
    }
}

using UnityEngine;
using System.Collections;


public static class ovladač
{
    //osy
    public static float HlavniHorizontal()
    {
        float r = 0.0f;
        r += Input.GetAxis("J_HlavniHorizontal");
        r += Input.GetAxis("K_HlavniHorizontal");
        return Mathf.Clamp(r, -1.0f, 1.0f);
    }
        public static float HlavniVertical()
        {
            float r = 0.0f;
            r += Input.GetAxis("J_HlavniVertical");
            r += Input.GetAxis("K_HlavniVertical");
            return Mathf.Clamp(r, -1.0f, 1.0f);
        }
    public static Vector3 HlavniJoystick() {
        return new Vector3(HlavniHorizontal(), 0, HlavniVertical());
            }

    //čudlíky
public static bool AButton()
    {
        return Input.GetButtonDown("A_Button");
    }
    public static bool BButton()
    {
        return Input.GetButtonDown("B_Button");
    }
    public static bool XButton()
    {
        return Input.GetButtonDown("X_Button");
    }
    public static bool YButton()
    {
        return Input.GetButtonDown("Y_Button");
    }
}
using UnityEngine;

public class menitpohled : MonoBehaviour
{

    public GameObject MainCamera;
    public GameObject Camera;


    void Start()
    {

        // Pozice kamery
        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    // update 1 za frame
    void Update()
    {
        //změnit Camera Keyboard
        switchCamera();
    }

    //Joysick UI
    public void cameraPositonM()
    {
        cameraChangeCounter();
    }

    //přepínání pohledů - klávesnice a ovladač
    void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            cameraChangeCounter();
        }
    }

    //pocítadlo
    void cameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        cameraPositionChange(cameraPositionCounter);
    }

    //menit
    void cameraPositionChange(int camPosition)
    {
        if (camPosition > 1)
        {
            camPosition = 0;
        }

        //nastaveni kamery databáze
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        //pozice 1
        if (camPosition == 0)
        {
            MainCamera.SetActive(true);

            Camera.SetActive(false);
        }

        //pozice 2
        if (camPosition == 1)
        {
            Camera.SetActive(true);

            MainCamera.SetActive(false);
        }

    }
}

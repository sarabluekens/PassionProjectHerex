
using UnityEngine;
using OpenCvSharp;

public class FaceDetector : MonoBehaviour
{
    // declare empty texture for webcam
    WebCamTexture _webCamTexture;
    CascadeClassifier cascade;
    // Start is called before the first frame update
    void Start() 
    {
        //array with webcam models?
        WebCamDevice[] devices = WebCamTexture.devices;

        //verbind een device aan de webcamtexture
        _webCamTexture = new WebCamTexture(devices[0].name);

        //start camera
        _webCamTexture.Play();

        cascade = new CascadeClassifier(Application.dataPath + @"/haarcascade_frontalface_default.xml");


    }

    // Update is called once per frame
    void Update()
    {
        //webcamtexture gebruiken als rendertexrure;
        GetComponent<Renderer>().material.mainTexture = _webCamTexture;

        //openCV mat to store current frame
        Mat frame = OpenCvSharp.Unity.TextureToMat(_webCamTexture);
        findNewFace(frame);
    }

    void findNewFace(Mat frame)
    {
        //matching image in frame? yes, store as face.
        var faces = cascade.DetectMultiScale(frame, 1.1, 2, HaarDetectionType.ScaleImage);

        if (faces.Length >= 1)
        {
            Debug.Log(faces[0].Location);
        }
        else

            Debug.Log("nobody home today");

    }
}

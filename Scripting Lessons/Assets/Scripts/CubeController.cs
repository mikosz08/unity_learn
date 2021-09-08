using UnityEngine;

public class CubeController : MonoBehaviour
{

    /*   Move the Cube based on the mouse input 
     *   -> based on mouse move on X and Y axis = move Cube along X/Y axis by pos/neg value respectively
     *   -> while mouse is moving on Y axis, rotate Main Camera along X axis, while mouse is moving on X axis, rotate Cube on Y axis
     *   -> by pressing 'R' button increase Cube's localScale by x amount
     */

    private float inputX;
    private float inputY;

    [SerializeField]
    private float cubeScaleIncrease = 2.5f;
    [SerializeField]
    private bool ShouldMoveCube = true, ShouldRotateCamAndCube = false, ShouldResizeCube = false;


    private GameObject cube, cam;

    void Start()
    {
        cube = GameObject.Find("Cube_Tester");
        cam = GameObject.Find("Main Camera");
    }


    void Update()
    {
        inputX = Input.GetAxis("Mouse X");
        inputY = Input.GetAxis("Mouse Y");

        if (ShouldMoveCube && ShouldRotateCamAndCube)
        {
            ShouldRotateCamAndCube = !ShouldRotateCamAndCube;
            ShouldMoveCube = !ShouldMoveCube;
        }

        if (ShouldMoveCube)
        {
            MoveCube();
        }
        else if (ShouldRotateCamAndCube)
        {
            RotateCameraAndCube();
        }
        else if (ShouldResizeCube)
        {
            ResizeCube();
        }
    }

    private void MoveCube()
    {
        var newPos = new Vector3(inputX, inputY, 0.0f);
        cube.transform.Translate(newPos * 0.1f);
    }

    private void RotateCameraAndCube()
    {
        if (inputY != 0)
            cam.transform.Rotate(inputY, 0.0f, 0.0f);

        if (inputX != 0)
            cube.transform.Rotate(0.0f, inputX, 0.0f);
    }

    private void ResizeCube()
    {
        if (Input.GetKey(KeyCode.R))
        {
            var s = cubeScaleIncrease;
            cube.transform.localScale = cube.transform.localScale + new Vector3(s, s, s);
        }
    }

}

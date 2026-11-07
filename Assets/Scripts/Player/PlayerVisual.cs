using UnityEngine;

public class PlayerVisual : MonoBehaviour
{

    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float sensitivity;
    [SerializeField] private float maxPitch;


    private InputScript input;
    private float pitch;

    private void Awake()
    {
        input = GetComponent<InputScript>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    void Update()
    {
        Vector2 look = input.Look * sensitivity;

        transform.Rotate(0f, look.x, 0);

        pitch -= look.y;
        pitch = Mathf.Clamp(pitch, -maxPitch, maxPitch);
        cameraTransform.localRotation = Quaternion.Euler(pitch, 0, 0);
                
    }
}

using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class XRCharacter : MonoBehaviour
{
    // Input values

    // References

    // Components

    // Values

    private void Awake()
    {
        // Collect our components
    }

    private void Update()
    {
        // If the controller is enabled, check for input
    }

    private void CheckForMovement(InputDevice device)
    {
        // Look for input, and potential value

        // Sets character direction, also factoring head

        // Apply character direction, and speed

        // Orient the character mesh seperately

        // Animate blend tree
    }

    private void CalculateDirection(Vector2 joystickDirection)
    {
        // Joystick direction

        // Look rotate

        // Rotate our joystick direction using the rotation of the head
    }

    private void MoveCharacter()
    {
        // Figure out how much we should move

        // Use simple move to include gravity, frame independent by default
    }

    private void OrientMesh()
    {
        // Set the direction the character should look, only with input
    }

    private void Animate()
    {
        // Blend between walk/run using length, which is a value between 0 - 1
    }
}

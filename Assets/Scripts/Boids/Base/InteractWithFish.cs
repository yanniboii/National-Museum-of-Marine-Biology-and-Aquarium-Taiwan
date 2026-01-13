using UnityEngine;
using UnityEngine.InputSystem;

public class InteractWithFish : MonoBehaviour
{
    [SerializeField] private InputActionReference scareActionReference;
    [SerializeField] private InputActionReference lureActionReference;
    [SerializeField] private Transform school;

    [SerializeField] private float scareRadius;
    [SerializeField] private float lureRadius;

    public void Scare(InputAction.CallbackContext context)
    {

        Vector3 pos = school.position;

        if (Mathf.Abs(Vector3.Distance(pos, transform.position)) < scareRadius)
        {
            school.position = new Vector3(Random.Range(-200, 200),
                                                            Random.Range(50, 150),
                                                            Random.Range(-200, 200));
        }
    }

    public void Lure(InputAction.CallbackContext context)
    {
        float closestDistance = float.PositiveInfinity;

        Vector3 pos = school.position;
        float distance = Mathf.Abs(Vector3.Distance(pos, transform.position));

        if (distance < closestDistance)
        {
            school.position = transform.position;
        }
    }
}

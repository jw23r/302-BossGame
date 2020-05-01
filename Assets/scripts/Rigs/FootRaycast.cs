using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class FootRaycast : MonoBehaviour
{
    TwoBoneIKConstraint iK;
    public Vector3 RaycastOffset;
    public float radiusOfSphereCast;
    public float Dis_To_Toes;
    public Transform ground;
    // Start is called before the first frame update
    void Start()
    {
        iK = GetComponent<TwoBoneIKConstraint>();
    }

    // Update is called once per frame
    void Update()
    {
        FindGround();
    }
    void FindGround()
    {
        float Ray_DIST_ABOVE_FOOT = 1f;
        float RAY_LENGTH = 2f;
        Vector3 directionToToeRaycastOrgin = iK.data.hint.position - transform.position;
        directionToToeRaycastOrgin.y = 0;
        directionToToeRaycastOrgin.Normalize();

        Ray ray = new Ray(transform.position + Vector3.up * Ray_DIST_ABOVE_FOOT, Vector3.down);
        bool heelHit = Physics.SphereCast(ray, radiusOfSphereCast, out RaycastHit hitHeel, RAY_LENGTH);
        Debug.DrawRay(ray.origin, ray.direction * RAY_LENGTH);

        ray.origin += directionToToeRaycastOrgin * Dis_To_Toes;
        bool toeHit = Physics.SphereCast(ray, radiusOfSphereCast, out RaycastHit hitToe, RAY_LENGTH);
        Debug.DrawRay(ray.origin, ray.direction * RAY_LENGTH);
        if(heelHit && toeHit)
        {
            Vector3 vectorToToe = hitToe.point - hitHeel.point;

            Vector3 groundFootPostion = transform.position;
            groundFootPostion.y = hitHeel.point.y;
            transform.position = groundFootPostion + RaycastOffset;

            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                Quaternion.LookRotation(vectorToToe, hitHeel.normal),
                90 * Time.deltaTime);

        }
        else
        {
            if(ground != null)
            {
                transform.position = new Vector3(transform.position.x, ground.position.y, transform.position.z) + RaycastOffset;
                transform.localRotation = Quaternion.identity;
            }
        }

    }
}

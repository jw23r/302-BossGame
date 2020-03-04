using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Transform earthMoon1;
    public Transform earthMoon2;
    public Transform earthMoon3;
    public Transform mecuryMoon;
    public Transform juiptiorMoon1;
    public Transform juiptiorMoon2;
    public Transform juiptiorMoon3;
    public Transform marsMoon;
    public Transform mercury;
    public Transform juiptior;
    public Transform venus;
    public Transform mars;
    public Transform earth;
    public Transform sun;
    public Transform galexy ;
    
    public static bool earthMoon1Target;
    public static bool earthMoon2Target;
    public static bool earthMoon3Target;
    public static bool mecuryMoonTarget;
    public static bool juiptiorMoon1Target;
    public static bool juiptiorMoon2Target;
    public static bool juiptiorMoon3Target;
    public static bool marsMoonTarget;
    public static bool mercuryTarget;
    public static bool juiptiorTarget;
    public static bool venusTarget;
    public static bool marsTarget;
    public static bool earthTarget;
    public static bool sunTarget;
    public static bool galexyTarget = true;
    float yaw = 0;
    // Update is called once per frame
    void Update()
    {
        CurrentCameraTarget();
    }

    public void EarthMoon1Target()
    {
     earthMoon1Target = true;
     earthMoon2Target = false;
     earthMoon3Target = false;
     mecuryMoonTarget = false;
     juiptiorMoon1Target = false;
     juiptiorMoon2Target = false;
     juiptiorMoon3Target = false;
     marsMoonTarget = false;
     mercuryTarget = false;
     juiptiorTarget = false;
     venusTarget = false;
     marsTarget = false;
     earthTarget = false;
     sunTarget = false;
     galexyTarget = false;
}
    public void EarthMoon2Target()
    {
        earthMoon1Target = false;
        earthMoon2Target = true;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void EarthMoon3Target()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = true;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void EarthTarget()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = true;
        sunTarget = false;
        galexyTarget = false;
    }
    public void MecuryMoonTarget()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = true;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void JuiptiorMoon1Target()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = true;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void JuiptiorMoon2Target()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = true;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void JuiptiorMoon3Target()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = true;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void MarsMoonTarget()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = true;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void MercuryTarget()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = true;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void JuiptiorTarget()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = true;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void VenusTarget()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }

    public void MarsTarget()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = true;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void SunTarget()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = true;
        sunTarget = true;
        galexyTarget = false;
    }
    public void GalexyTarget()
    {
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = true;
    }
    private void CurrentCameraTarget()
    {
        if (earthMoon1Target == true)
        {
            Vector3 vectorToTarget = earthMoon1.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (earthMoon2Target == true)
        {
            Vector3 vectorToTarget = earthMoon2.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (earthMoon3Target == true)
        {
            Vector3 vectorToTarget = earthMoon3.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (earthTarget == true)
        {
            Vector3 vectorToTarget = earth.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (juiptior == true)
        {
            Vector3 vectorToTarget = juiptior.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (juiptiorTarget == true)
        {
            Vector3 vectorToTarget = juiptior.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (juiptiorMoon1Target == true)
        {
            Vector3 vectorToTarget = juiptiorMoon1.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (juiptiorMoon2Target == true)
        {
            Vector3 vectorToTarget = juiptiorMoon2.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (juiptiorMoon2Target == true)
        {
            Vector3 vectorToTarget = juiptiorMoon3.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }

        if (mecuryMoonTarget == true)
        {
            Vector3 vectorToTarget = mecuryMoon.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (mercuryTarget == true)
        {
            Vector3 vectorToTarget = mercury.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (marsMoonTarget == true)
        {
            Vector3 vectorToTarget = marsMoon.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (marsTarget == true)
        {
            Vector3 vectorToTarget = mars.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }

        if (venusTarget == true)
        {
            Vector3 vectorToTarget = venus.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }

        if (sunTarget == true)
        {
            Vector3 vectorToTarget = sun.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (galexyTarget == true)
        {
            Vector3 vectorToTarget = galexy.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
    }
}

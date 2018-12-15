using UnityEngine;

public class letanigamepad : MonoBehaviour
{

    public bool kolize = true;
 
    PhysicMaterial Kulicka;

    void Start()
    {
        if (kolize == true)
        {
            Kulicka = new PhysicMaterial("ZeroFriction");
            Kulicka.dynamicFriction = 0f;
            Kulicka.staticFriction = 0f;
            Kulicka.bounciness = 0f;
            Kulicka.frictionCombine = PhysicMaterialCombine.Multiply;
            Kulicka.bounceCombine = PhysicMaterialCombine.Average;
            gameObject.AddComponent<SphereCollider>();
            gameObject.GetComponent<SphereCollider>().radius = 1f;
            gameObject.GetComponent<SphereCollider>().material = Kulicka;

            gameObject.AddComponent<Rigidbody>();
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }

    }
    void Update()
    {
        var x = Input.GetAxis("Gamepad Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Gamepad Vertical") * Time.deltaTime * 3.0f;
        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);

         var y = Input.GetAxis ("Nahoru") * Time.deltaTime * 3.0f;
        transform.Translate(0, y, 0);
        }
}

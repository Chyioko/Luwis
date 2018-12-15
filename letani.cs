using UnityEngine;

public class letani : MonoBehaviour
{

    public float rychlost = 3.0f; 
    public float dolu = 3.0f; 
    private float celkovyBeh = 1.0f;
    private float nasobicRychlosti; 

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
            Kulicka.bounceCombine = PhysicMaterialCombine.Average
;
            gameObject.AddComponent<SphereCollider>();
            gameObject.GetComponent<SphereCollider>().radius = 1f;
            gameObject.GetComponent<SphereCollider>().material = Kulicka;

            gameObject.AddComponent<Rigidbody>();
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }
    void Update()
    {
    //Klávesnice

        Vector3 p = GetBaseInput();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            
        }
        else
        {
            celkovyBeh = Mathf.Clamp(celkovyBeh * 0.5f, 1f, 1000f);
            p = p * rychlost;
            nasobicRychlosti = rychlost * Time.deltaTime; 
        }

        p = p * Time.deltaTime;
       

        Vector3 novaPozice = transform.position;
        transform.Translate(p);
        novaPozice.x = transform.position.x;
        novaPozice.z = transform.position.z;


        if (Input.GetKey(KeyCode.LeftShift))
        {
            novaPozice.y += -nasobicRychlosti;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            novaPozice.y += nasobicRychlosti;
        }

        transform.position = novaPozice;
    }

    private Vector3 GetBaseInput()
    { //0= není aktivní
        Vector3 p_rychlost = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            p_rychlost += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_rychlost += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_rychlost += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_rychlost += new Vector3(1, 0, 0);
        }
        return p_rychlost;
    }
}
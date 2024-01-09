using UnityEngine;

public class Blue_Leg : MonoBehaviour
{
    //public float scaleFactor = 1.5f; // Facteur d'agrandissement sur l'axe Y
    public float speed = 5f;
    public float resetSpeed = 5f;



    public float limite = 0;
    public int sat = 8;
    private int compteur = 0;

    [SerializeField] public bool G3;
    public Transform _parent;
    FMOD.Studio.EventInstance Extrude;


    private void Start()
    {
        Extrude = FMODUnity.RuntimeManager.CreateInstance("event:/player/limb/limb_stretch");
    }
    void Update()
    {
        // Mouse
        if (Input.GetKey(KeyCode.Q))
        {
            // Redimensionne le cube sur l'axe Y
            ScaleOnY();
            //compteur += 1;
            //fmod_stretch();
        }


        // Controller
        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            // Redimensionne le cube sur l'axe Y
            ScaleOnY();
            //compteur += 1;
            //fmod_stretch();

        }

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            fmod_stretch();
        }
        
        if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            Extrude.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/player/limb/limb_retract");
        }

        if (Input.GetKey(KeyCode.R))
        {
            Reset();
        }
        if (Input.GetKey(KeyCode.Joystick1Button3))
        {
            Reset();
        }
    }

    void ScaleOnY()
    {
        // Redimensionne le cube uniquement sur l'axe Y
        if (transform.localScale.y < limite)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + speed * Time.deltaTime, transform.localScale.z);
        }



        ////Limite
        //if (compteur == limite)
        //{
        //    compteur = 0;
        //    transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);
        //    transform.localScale = new Vector3(0.20f, 0.30f, 0.20f);

        //}
        if (compteur == sat)
        {
            //FMODUnity.RuntimeManager.PlayOneShot("event:/saturation");
        }



    }
    void fmod_stretch()
    {
        if (transform.localScale.y < limite)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/player/limb/limb_stretch_beg");
            Extrude.start();
        }
        else
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/player/limb/limit");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        G3 = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //FMODUnity.RuntimeManager.PlayOneShot("event:/boing");
        G3 = true;
    }
    void Reset()
    {
        compteur = 0;
        transform.position = new Vector3(_parent.position.x, _parent.position.y, _parent.position.z);

        // Retour taille initiale
        if (transform.localScale.y > 0.09712829f)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y - resetSpeed * Time.deltaTime, 1.137281f);
        }
    }

}




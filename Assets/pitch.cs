using UnityEngine;
using System.Collections;

public class pitch : MonoBehaviour {

    public enum Note
    {
        C0,
        Cs0,
        D0,
        Ds0,
        E0,
        F0,
        Fs0,
        G0,
        Gs0,
        A0,
        As0,
        B0,
        C1,
        Cs1,
        D1,
        Ds1,
        E1,
        F1,
        Fs1,
        G1,
        Gs1,
        A1,
        As1,
        B1,
        C2,
        Cs2,
        D2,
        Ds2,
        E2,
        F2,
        Fs2,
        G2,
        Gs2,
        A2,
        As2,
        B2,
    }

    public Note note;

	// Use this for initialization
	void Start () {
        float ratio = 1.0f;
	    switch(note)
        {
            case Note.C0: ratio = 0.5f; break;
            case Note.Cs0: ratio = 0.529729461139184f; break;
            case Note.D0: ratio = 0.561228624066416f; break;
            case Note.Ds0: ratio = 0.594600689533915f; break;
            case Note.E0: ratio = 0.629960325044147f; break;
            case Note.F0: ratio = 0.667418375849495f; break;
            case Note.Fs0: ratio = 0.707104798452753f; break;
            case Note.G0: ratio = 0.749153371606798f; break;
            case Note.Gs0: ratio = 0.793697874064504f; break;
            case Note.A0: ratio = 0.840895018079243f; break;
            case Note.As0: ratio = 0.890897693654301f; break;
            case Note.B0: ratio = 0.943874079793293f; break;
            case Note.C1: ratio = 1f; break;
            case Note.Cs1: ratio = 1.05946274452845f; break;
            case Note.D1: ratio = 1.12246107038291f; break;
            case Note.Ds1: ratio = 1.18920520131791f; break;
            case Note.E1: ratio = 1.25992065008829f; break;
            case Note.F1: ratio = 1.33483675169899f; break;
            case Note.Fs1: ratio = 1.41420959690551f; break;
            case Note.G1: ratio = 1.49830292096351f; break;
            case Note.Gs1: ratio = 1.58739957037909f; break;
            case Note.A1: ratio = 1.68179003615849f; break;
            case Note.As1: ratio = 1.7817953873086f; break;
            case Note.B1: ratio = 1.8877443373365f; break;
            case Note.C2: ratio = 1.99999617774992f; break;
            case Note.Cs2: ratio = 2.11892166680682f; break;
            case Note.D2: ratio = 2.24492214076583f; break;
            case Note.Ds2: ratio = 2.37841040263582f; break;
            case Note.E2: ratio = 2.51983747792651f; break;
            case Note.F2: ratio = 2.66967350339798f; break;
            case Note.Fs2: ratio = 2.8284230160611f; break;
            case Note.G2: ratio = 2.99660966417711f; break;
            case Note.Gs2: ratio = 3.1747953185081f; break;
            case Note.A2: ratio = 3.36358007231697f; break;
            case Note.As2: ratio = 3.5635907746172f; break;
            case Note.B2: ratio = 3.77549249692309f; break;
            default:
                Debug.LogError("Unsupported note (enum value " + note + ")");
                break;
        }
        GetComponent<AudioSource>().pitch = ratio;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

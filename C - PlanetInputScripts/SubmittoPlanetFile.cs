using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;

public class SubmittoPlanetFile : MonoBehaviour {
    public static int submitcount = 0;
    //public static bool submitCplanethappened = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void Restart()
    {
        
        //GUI.Label (new Rect(25, 25, 100, 30), "Label");
        //Display
        /*
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", System.Environment.NewLine);
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", "OBJECT");
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", " ");
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", XInput.inputs[0]);

        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", " ");
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", XInput.inputs[1]);

        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", " ");
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", XInput.inputs[2]);

        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", " ");
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", XInput.inputs[3]);


        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", " ");
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", XInput.inputs[4]);

        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", " ");
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", XInput.inputs[5]);


        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", " ");
        File.AppendAllText(@"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\inputC.txt", XInput.inputs[6]);
        */

        Vector3 temp_pos = new Vector3(float.Parse(XInput.inputs[0]), float.Parse(XInput.inputs[1]), float.Parse(XInput.inputs[2]));
        Vector3 temp_vel = new Vector3(float.Parse(XInput.inputs[3]), float.Parse(XInput.inputs[4]), float.Parse(XInput.inputs[5]));
        float temp_mass = float.Parse(XInput.inputs[6]);

        ModelActions.CPlanetsPositions[submitcount] = temp_pos;
        ModelActions.CPlanetsVelocities[submitcount] = temp_vel;
        ModelActions.CPlanetsMasses[submitcount] = temp_mass;

        submitcount++;

        SceneManager.LoadScene(4);

        //submitCplanethappened = true;
               
    }
}

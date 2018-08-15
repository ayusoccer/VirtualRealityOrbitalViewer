using UnityEngine;
using System.Collections;
using System.IO;
using System;


public class SaveToNewFile : MonoBehaviour {
    int Cnumasters = 0;

    

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CAsteroidsSaveIt()
    {
        //while (SubmitoAsteroidFile.submitCasteroidshappened == true)
        //{
        //    continue;
        //}

        string fileName = @"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\"+FilenameInputScript.filename+".txt";
        
        if (!File.Exists(fileName))
        {
            File.Copy("Assets/inputC.txt", fileName);
            //File.AppendAllText(fileName, System.Environment.NewLine);
        }         
           
            Cnumasters = int.Parse(AsteroidAmountInput.inputs[0]);
            for (int i = 0; i < Cnumasters; i++)
            {

                File.AppendAllText(fileName, System.Environment.NewLine);

                File.AppendAllText(fileName, "PLANET");
                File.AppendAllText(fileName, " ");
                File.AppendAllText(fileName, ModelActions.CAsteroidsPositions[i].x.ToString("N5"));

                File.AppendAllText(fileName, " ");
                File.AppendAllText(fileName, ModelActions.CAsteroidsPositions[i].y.ToString("N5"));

                File.AppendAllText(fileName, " ");
                File.AppendAllText(fileName, ModelActions.CAsteroidsPositions[i].z.ToString("N5"));

                File.AppendAllText(fileName, " ");
                File.AppendAllText(fileName, ModelActions.CAsteroidsVelocities[i].x.ToString("N5"));


                File.AppendAllText(fileName, " ");
                File.AppendAllText(fileName, ModelActions.CAsteroidsVelocities[i].y.ToString("N5"));

                File.AppendAllText(fileName, " ");
                File.AppendAllText(fileName, ModelActions.CAsteroidsVelocities[i].z.ToString("N5"));


                File.AppendAllText(fileName, " ");
                File.AppendAllText(fileName, ModelActions.CAsteroidsMasses[i].ToString("N5"));

                File.AppendAllText(fileName, System.Environment.NewLine);
                       
        }
    }

    public void CPlanetSaveIt()
    {
        //while (SubmittoPlanetFile.submitCplanethappened == true)
        //{
          //  continue;
        //}

        string fileName = @"C:\Users\N\Documents\orbital-viewer\Orbital Viewer 1.1 - MANY CHANGES\Assets\" + FilenameInputScript.filename + ".txt";
                
        if (!File.Exists(fileName))
            File.Copy("Assets/inputC.txt", fileName);

        File.AppendAllText(fileName, System.Environment.NewLine);
             

            File.AppendAllText(fileName, "PLANET");
            File.AppendAllText(fileName, " ");
            File.AppendAllText(fileName, ModelActions.CPlanetsPositions[SubmittoPlanetFile.submitcount-1].x.ToString("N5"));

            File.AppendAllText(fileName, " ");
            File.AppendAllText(fileName, ModelActions.CPlanetsPositions[SubmittoPlanetFile.submitcount-1].y.ToString("N5"));

            File.AppendAllText(fileName, " ");
            File.AppendAllText(fileName, ModelActions.CPlanetsPositions[SubmittoPlanetFile.submitcount-1].z.ToString("N5"));

            File.AppendAllText(fileName, " ");
            File.AppendAllText(fileName, ModelActions.CPlanetsVelocities[SubmittoPlanetFile.submitcount-1].x.ToString("N5"));


            File.AppendAllText(fileName, " ");
            File.AppendAllText(fileName, ModelActions.CPlanetsVelocities[SubmittoPlanetFile.submitcount-1].y.ToString("N5"));

            File.AppendAllText(fileName, " ");
            File.AppendAllText(fileName, ModelActions.CPlanetsVelocities[SubmittoPlanetFile.submitcount-1].z.ToString("N5"));


            File.AppendAllText(fileName, " ");
            File.AppendAllText(fileName, ModelActions.CPlanetsMasses[SubmittoPlanetFile.submitcount-1].ToString("N5"));

            File.AppendAllText(fileName, System.Environment.NewLine);
        
    }
 }



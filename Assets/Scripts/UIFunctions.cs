using UnityEngine;
using UnityEngine.SceneManagement;

//this script needs to bee attached to a Game Object in the scene. sually an Empty Game object you create called "Game Manager" or "UI Manager"

public class UIFunctions : MonoBehaviour
{
    public string sceneName; //this will give us the field to edit the script. It will create a txt field on the object that you add the script to and if you choose to load scene by name with OnClick() btn fucntion, it will put a text field on the button (which is where you will edit the text field to load a specific scene by name using btns)
    
    void Update()
    {
        PressKeyToSetActive();//this is calling a custom method, written on line 38, to Press Q on the keyboard to open the menu

    }

    public void LoadSceneByName(string sceneName) //this passes in our sceneName string variable to allow us load scenes by name
    {
        SceneManager.LoadScene(sceneName);// This method access the using UnityEngine.SceneManagement libraries through SceneManager, to allow us to call the Load Scene() method and we are specifying how we want to Load the scene by passing in a "string" variable called sceneName, to enable us to load a scene by name. Remember we will have a public field that we can use the name of a scene to load on the GameObject we attach the script to and where we use it (for instance, on a btn).
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //this will load the next scene in the build index. 0 is always loaded first, the 1 and so on. It works by first checking what scene is currently active and adding 1 to the index value of the active scene to switch to the next consecutive scene.
    }

    public void QuitGameBtn()
    {
        Application.Quit(); // this only quits the Build. When testing in the editor you will only see the Debug.Log statement
        Debug.Log("Application has Quit. This will only quit when running Build");
    }

    public GameObject objectToToggle; //give us a public field to slot in a game object in the inspector. 
    public void ActivateObjectBtn() //The allows us to SetActive a GameObject through 
    {
        objectToToggle.SetActive(true);
    }

    public GameObject UIMenu;
    public void PressKeyToSetActive()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            UIMenu.SetActive(true);
        }

    }
}

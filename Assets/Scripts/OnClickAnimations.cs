using UnityEngine;



/*This script is going to access the animator component, and change the bool parameter we set to true.
To do this we need to create a reference for the animator in script
We need to assign the animator in script to be the specific animator on the gameObject
Then, when the object is clicked, we need to change the bool state of the animator parameter on this game object
Watch out - for on mouse down method to work our object also needs to have a collider.
*/
public class OnClickAnimations : MonoBehaviour
{

    public Animator thisAnimator;
     //this is us storing an animator type object in memory in the script and assigning a variable name
   
    void Start()
    {
        thisAnimator = gameObject.GetComponent<Animator>(); //this is us taking that variable name and assigning the specifc animator thats on this gameObject as the animator we want to access
    }

    void OnMouseDown()
    {
        thisAnimator.SetBool("IsClicked", true); //This accesses the specific animator and it searches for the parameter we set earlier, so the orange text needs to match the name of the parameter we set earlier exactly. It assigns the bool state to true.
    }


}

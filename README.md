# HW4-angry-birds

tis is a small game of angry birds made of two levels,which mean you must throw the ball(yellow bird) towards the other birds trying to smash them.

its made just from 3 scripts:

throw ball:responsible of throwing the bird by using onmouseUp\onmouseDown which gives you the possibility to drag the bird and throw it to the other side

 ScenceController:it just swich scenes

destroy: 

public class DestoryBirds : MonoBehaviour

{

    private void OnCollisionEnter2D(Collision2D collision)
    
    {
    
        if (collision.gameObject.tag == "Ground" && enabled)
        
        {
            Destroy(collision.gameObject);
            
            ScenceController.Instance.NextLevel();
            
        }
    }
    ---

    as you can see when the bird is hit and collapse at the ground(which has edge collider ) it go to the next level.

   

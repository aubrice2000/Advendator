var firstTex: Texture2D;
var secondTex: Texture2D;
var startS : AudioSource;
var stopS : AudioSource;
var wheels :Animation;


function Update()
{
	if(Input.GetKeyDown(KeyCode.S))
	{
	guiTexture.texture = secondTex;
	 startS.Play();
	 rotationWheels();
	
 	}
	
	if(Input.GetKeyDown(KeyCode.A))
	{
	guiTexture.texture = firstTex;
	 stopS.Play();
	 
	}
	
	
}

function rotationWheels()
{	
	animation.Play("wheel");

}

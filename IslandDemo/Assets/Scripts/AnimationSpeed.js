var statename = "defaulto";
var speed_modify = 0.5;

function Start () 
{
	GetComponent.<Animation>()[statename].speed = speed_modify;
}
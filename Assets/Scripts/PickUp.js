var target : Transform;

function Update () {

}

function OnMouseDown () {
	this.transform.position = target.position;
	this.transform.parent = GameObject.Find("FPSController").transform;
	this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
}

function OnMouseUp () {
	this.transform.parent = GameObject.Find("FPSController").transform;
	this.transform.parent = null;
}
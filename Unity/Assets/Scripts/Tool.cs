using UnityEngine;

[CreateAssetMenu(fileName = "New Tool", menuName = "Tool", order = 3)]
public class Tool : ScriptableObject
{
	public bool Vessel;
	public bool Cookware;
	public bool Utensil;
	public bool Appliance;
}
